using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using AutoMapper;
using HRMgmt;
using HRSystem.Helper;
using HRSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TravelOrderCard;
using TravelOrderStatus;

namespace HRSystem.Controllers
{
    [Authorize]
    public class TravelOrderController : Controller
    {
        private readonly IMapper _mapper;

        readonly BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
        readonly Config config = ConfigJSON.Read();
        readonly NetworkCredential credential = new NetworkCredential();

        public TravelOrderController(IMapper mapper)
        {
            _mapper = mapper;
            basicHttpBinding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Ntlm;
        }

        private travelorderstatus_PortClient Travelorderstatus_PortClientService()
        {
            credential.UserName = User.Identity.GetUserName();
            credential.Password = User.Identity.GetPassword();
            credential.Domain = config.Integration_Setup.Domain;

            config.Default_Config.Company_Name = User.Identity.GetCompanyName();

            var integrationService = config.Integration_Services
                .Where(x => x.Integration_Type == "Travel_Status" && x.Company_Name == config.Default_Config.Company_Name)
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new travelorderstatus_PortClient(basicHttpBinding, endpoint);
            client.ClientCredentials.Windows.ClientCredential = credential;
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            return client;
        }

        private travelordercard_PortClient Travelordercard_PortClientService()
        {
            credential.UserName = User.Identity.GetUserName();
            credential.Password = User.Identity.GetPassword();
            credential.Domain = config.Integration_Setup.Domain;

            config.Default_Config.Company_Name = User.Identity.GetCompanyName();

            var integrationService = config.Integration_Services
                .Where(x => x.Integration_Type == "Travel_Order" && x.Company_Name == config.Default_Config.Company_Name)
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new travelordercard_PortClient(basicHttpBinding, endpoint);
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
            List<travelorderstatus> travelorders = new List<travelorderstatus>();
            try
            {
                travelorderstatus_Filter[] filter = {
                    new travelorderstatus_Filter {
                        Field = travelorderstatus_Fields.Employee_No,
                        Criteria = User.Identity.GetEmployeeNo()
                    }
                };

                travelorders = Travelorderstatus_PortClientService()
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
            return View(travelorders);
        }

        public IActionResult Submit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(TravelOrderViewModel vmObj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var obj = _mapper.Map<travelordercard>(vmObj);

                    TravelOrderCard.Create createObj = new TravelOrderCard.Create {
                        travelordercard = obj
                    };

                    createObj.travelordercard.Employee_Name = null;
                    createObj.travelordercard.Employee_No = User.Identity.GetEmployeeNo();
                    createObj.travelordercard.Depature_Date_ADSpecified = true;
                    createObj.travelordercard.Arrival_Date_ADSpecified = true;
                    createObj.travelordercard.Travel_TypeSpecified = true;
                    createObj.travelordercard.Reason_for_TravelSpecified = true;
                    createObj.travelordercard.Mode_Of_TransportationSpecified = true;
                    createObj.travelordercard.Approved_TypeSpecified = true;
                    createObj.travelordercard.Travel_StatusSpecified = true;
                    createObj.travelordercard.Exchange_RateSpecified = true;
                    createObj.travelordercard.Claimed_Local_TransportationSpecified = true;
                    createObj.travelordercard.Claimed_FuelSpecified = true;
                    createObj.travelordercard.Claimed_Other_ExpensesSpecified = true;

                    var result = Travelordercard_PortClientService()
                        .CreateAsync(createObj)
                        .GetAwaiter()
                        .GetResult()
                        .travelordercard;

                    if (result != null)
                    {
                        var postResult = Hrmgt_PortClientService()
                            .PosttravelorderwebAsync(result.Travel_Order_No)
                            .GetAwaiter()
                            .GetResult()
                            .return_value;

                        if (postResult == 200)
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Leave Request", text = "Travel order posted successfully.", type = "success" });
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Error", text = "Travel order created but submitting failed.", type = "error" });
                        }
                    }
                    else
                    {
                        TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Error", text = "Creating travel order failed. Try again.", type = "error" });
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
            return View(vmObj);
        }
    }
}