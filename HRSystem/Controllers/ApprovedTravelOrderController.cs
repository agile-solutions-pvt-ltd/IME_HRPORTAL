using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using ApprovedTravelOrder;
using AutoMapper;
using HRMgmt;
using HRSystem.Helper;
using HRSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TravelVoucher;

namespace HRSystem.Controllers
{
    [Authorize]
    public class ApprovedTravelOrderController : Controller
    {
        private readonly IMapper _mapper;

        readonly BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
        readonly Config config = ConfigJSON.Read();
        readonly NetworkCredential credential = new NetworkCredential();

        public ApprovedTravelOrderController(IMapper mapper)
        {
            _mapper = mapper;
            basicHttpBinding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Ntlm;
            basicHttpBinding.MaxReceivedMessageSize = int.MaxValue;
        }

        private approvedtravelorder_PortClient Approvedtravelorder_PortClientService()
        {
            credential.UserName = User.Identity.GetUserName();
            credential.Password = User.Identity.GetPassword();
            credential.Domain = config.Integration_Setup.Domain;

            config.Default_Config.Company_Name = User.Identity.GetCompanyName();

            var integrationService = config.Integration_Services
                .Where(x => x.Integration_Type == "Approved_Travel" && x.Company_Name == config.Default_Config.Company_Name)
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new approvedtravelorder_PortClient(basicHttpBinding, endpoint);
            client.ClientCredentials.Windows.ClientCredential = credential;
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            return client;
        }

        private travelvoucher_PortClient Travelvoucher_PortClientService()
        {
            credential.UserName = User.Identity.GetUserName();
            credential.Password = User.Identity.GetPassword();
            credential.Domain = config.Integration_Setup.Domain;

            config.Default_Config.Company_Name = User.Identity.GetCompanyName();

            var integrationService = config.Integration_Services
                .Where(x => x.Integration_Type == "Travel_Voucher" && x.Company_Name == config.Default_Config.Company_Name)
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new travelvoucher_PortClient(basicHttpBinding, endpoint);
            client.ClientCredentials.Windows.ClientCredential = credential;
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            return client;
        }

        private hrmgt_PortClient Hrmgt_PortClientService()
        {
            credential.UserName = User.Identity.GetUserName();
            credential.Password = User.Identity.GetPassword();
            credential.Domain = config.Integration_Setup.Domain;

            config.Default_Config.Company_Name = User.Identity.GetCompanyName();

            var integrationService = config.Integration_Services
                .Where(x => x.Integration_Type == "HrMgt" && x.Company_Name == config.Default_Config.Company_Name)
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new hrmgt_PortClient(basicHttpBinding, endpoint);
            client.ClientCredentials.Windows.ClientCredential = credential;
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            return client;
        }

        public IActionResult Index()
        {
            List<approvedtravelorder> approvedtravelorders = new List<approvedtravelorder>();
            try
            {
                approvedtravelorder_Filter[] filter = new approvedtravelorder_Filter[0];
                approvedtravelorders = Approvedtravelorder_PortClientService()
                    .ReadMultipleAsync(filter, "", 0)
                    .GetAwaiter()
                    .GetResult()
                    .ReadMultiple_Result1
                    .ToList();
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return View(approvedtravelorders);
        }

        public IActionResult SubmitSettlement(string travelOrderNo)
        {
            TravelVoucherViewModel vmObj = new TravelVoucherViewModel();
            try
            {
                var result = Approvedtravelorder_PortClientService()
                    .ReadAsync(travelOrderNo)
                    .GetAwaiter()
                    .GetResult()
                    .approvedtravelorder;

                vmObj.Travel_Order_Form_No = result.Travel_Order_No;
                vmObj.Travelrs_ID_No = result.Employee_No;
                vmObj.Travelers_Name = result.Employee_Name;
                vmObj.Actual_Departure_Date_AD = result.Depature_Date_AD;
                vmObj.Actual_Arrival_Date_AD = result.Arrival_Date_AD;
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return View(vmObj);
        }

        [HttpPost]
        public IActionResult SubmitSettlement(TravelVoucherViewModel vmObj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var obj = _mapper.Map<travelvoucher>(vmObj);

                    Create createObj = new Create
                    {
                        travelvoucher = obj
                    };

                    createObj.travelvoucher.Actual_Departure_Date_ADSpecified = true;
                    createObj.travelvoucher.Actual_Arrival_Date_ADSpecified = true;
                    createObj.travelvoucher.Claimed_Travel_ExpensesSpecified = true;
                    createObj.travelvoucher.Claimed_Driver_AllowanceSpecified = true;
                    createObj.travelvoucher.Claimed_Fuel_ExpensesSpecified = true;
                    createObj.travelvoucher.Guest_Expenses_NrsSpecified = true;

                    var result = Travelvoucher_PortClientService()
                        .CreateAsync(createObj)
                        .GetAwaiter()
                        .GetResult()
                        .travelvoucher;

                    if (result != null)
                    {
                        var postResult = Hrmgt_PortClientService()
                            .PosttravelvoucherwebAsync(result.Travel_Order_Form_No)
                            .GetAwaiter()
                            .GetResult()
                            .return_value;

                        if (postResult == 200)
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Travel Settlement", text = "Travel settlement submitted successfully.", type = "success" });
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Error", text = "Travel settlement created but submitting failed.", type = "error" });
                        }
                    }
                    else
                    {
                        TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Error", text = "Creating travel settlement failed. Try again.", type = "error" });
                    }
                }
                else
                {
                    TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Validation Error", text = "Insert proper values for each fields.", type = "error" });
                }
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return RedirectToAction(nameof(SubmitSettlement), new { travelOrderNo = vmObj.Travel_Order_Form_No });
        }
    }
}