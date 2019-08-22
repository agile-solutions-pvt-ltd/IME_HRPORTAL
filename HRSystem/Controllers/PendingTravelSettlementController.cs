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
using PendingTravelVoucher;
using PostedTravelVoucherCard;

namespace HRSystem.Controllers
{
    [Authorize]
    public class PendingTravelSettlementController : Controller
    {
        private readonly IMapper _mapper;

        readonly BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
        readonly Config config = ConfigJSON.Read();
        readonly NetworkCredential credential = new NetworkCredential();

        public PendingTravelSettlementController(IMapper mapper)
        {
            _mapper = mapper;
            basicHttpBinding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Ntlm;
            basicHttpBinding.MaxReceivedMessageSize = int.MaxValue;
        }

        private pendingtravelvoucher_PortClient Pendingtravelvoucher_PortClientService()
        {
            credential.UserName = User.Identity.GetUserName();
            credential.Password = User.Identity.GetPassword();
            credential.Domain = config.Integration_Setup.Domain;

            config.Default_Config.Company_Name = User.Identity.GetCompanyName();

            var integrationService = config.Integration_Services
                .Where(x => x.Integration_Type == "Pending_Travel_Voucher" && x.Company_Name == config.Default_Config.Company_Name)
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new pendingtravelvoucher_PortClient(basicHttpBinding, endpoint);
            client.ClientCredentials.Windows.ClientCredential = credential;
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            return client;
        }

        private postedtravelvouchercard_PortClient Postedtravelvouchercard_PortClientService()
        {
            credential.UserName = User.Identity.GetUserName();
            credential.Password = User.Identity.GetPassword();
            credential.Domain = config.Integration_Setup.Domain;

            config.Default_Config.Company_Name = User.Identity.GetCompanyName();

            var integrationService = config.Integration_Services
                .Where(x => x.Integration_Type == "Posted_Travel_Voucher" && x.Company_Name == config.Default_Config.Company_Name)
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new postedtravelvouchercard_PortClient(basicHttpBinding, endpoint);
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
            List<pendingtravelvoucher> pendingtravelvouchers = new List<pendingtravelvoucher>();
            try
            {
                pendingtravelvoucher_Filter[] filter = new pendingtravelvoucher_Filter[0];
                pendingtravelvouchers = Pendingtravelvoucher_PortClientService()
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
            return View(pendingtravelvouchers);
        }

        public IActionResult RecommendRequest(string travelOrderNo)
        {
            PostedTravelVoucherViewModel vmObj = new PostedTravelVoucherViewModel();
            try
            {
                postedtravelvouchercard obj = new postedtravelvouchercard();
                obj = Postedtravelvouchercard_PortClientService()
                    .ReadAsync(travelOrderNo)
                    .GetAwaiter()
                    .GetResult()
                    .postedtravelvouchercard;

                vmObj = _mapper.Map<PostedTravelVoucherViewModel>(obj);
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return View(vmObj);
        }

        [HttpPost]
        public IActionResult RecommendRequest(PostedTravelVoucherViewModel vmObj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var obj = _mapper.Map<postedtravelvouchercard>(vmObj);
                    obj.Approved_Travel_ExpensesSpecified = true;
                    obj.Approved_Driver_AllowanceSpecified = true;
                    obj.Approved_Fuel_ExpensesSpecified = true;
                    obj.Approved_Guest_ExpensesSpecified = true;

                    PostedTravelVoucherCard.Update updateObj = new PostedTravelVoucherCard.Update
                    {
                        postedtravelvouchercard = obj
                    };

                    var result = Postedtravelvouchercard_PortClientService()
                        .UpdateAsync(updateObj)
                        .GetAwaiter()
                        .GetResult()
                        .postedtravelvouchercard;

                    if (result != null)
                    {
                        var postResult = Hrmgt_PortClientService()
                        .RecommendtravelvoucherwebAsync(result.Travel_Order_Form_No)
                        .GetAwaiter()
                        .GetResult()
                        .return_value;

                        if (postResult == 200)
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Recommend Travel Settlement", text = "Travel Settlement recommended successfully.", type = "success" });
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Recommend Travel Settlement", text = "Updating travel settlement succeeded but posting recommendation failed.", type = "error" });
                        }
                    }
                    else
                    {
                        TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Recommend Travel Settlement", text = "Updating travel settlement fields failed.", type = "error" });
                    }
                }
                else
                {
                    TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Recommend Travel Settlement", text = "Validation Error. Try Again.", type = "error" });
                }
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return RedirectToAction(nameof(RecommendRequest), new { travelOrderNo = vmObj.Travel_Order_Form_No });
        }

        public IActionResult RejectRequest(string travelOrderNo)
        {
            PostedTravelVoucherViewModel vmObj = new PostedTravelVoucherViewModel();
            try
            {
                postedtravelvouchercard obj = new postedtravelvouchercard();
                obj = Postedtravelvouchercard_PortClientService()
                    .ReadAsync(travelOrderNo)
                    .GetAwaiter()
                    .GetResult()
                    .postedtravelvouchercard;

                vmObj = _mapper.Map<PostedTravelVoucherViewModel>(obj);
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return View(vmObj);
        }

        [HttpPost]
        public IActionResult RejectRequest(PostedTravelVoucherViewModel vmObj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var obj = _mapper.Map<postedtravelvouchercard>(vmObj);
                    PostedTravelVoucherCard.Update updateObj = new PostedTravelVoucherCard.Update
                    {
                        postedtravelvouchercard = obj
                    };

                    var result = Postedtravelvouchercard_PortClientService()
                        .UpdateAsync(updateObj)
                        .GetAwaiter()
                        .GetResult()
                        .postedtravelvouchercard;

                    if (result != null)
                    {
                        var postResult = Hrmgt_PortClientService()
                            .RejecttravelvoucherwebAsync(result.Travel_Order_Form_No)
                            .GetAwaiter()
                            .GetResult()
                            .return_value;

                        if (postResult == 200)
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Reject Travel Settlement", text = "Travel settlement rejected successfully.", type = "success" });
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Reject Travel Settlement", text = "Reject details saved but posting rejection failed.", type = "error" });
                        }
                    }
                    else
                    {
                        TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Reject Travel Settlement", text = "Posting reject details failed.", type = "error" });
                    }
                }
                else
                {
                    TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Reject Travel Settlement", text = "Validation Error. Try Again.", type = "error" });
                }
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return RedirectToAction(nameof(RejectRequest), new { travelOrderNo = vmObj.Travel_Order_Form_No });
        }
    }
}