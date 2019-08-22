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
using PendingTravelOrder;
using PostedTravelOrderCard;

namespace HRSystem.Controllers
{
    [Authorize]
    public class PendingTravelOrderController : Controller
    {
        private readonly IMapper _mapper;

        readonly BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
        readonly Config config = ConfigJSON.Read();
        readonly NetworkCredential credential = new NetworkCredential();

        public PendingTravelOrderController(IMapper mapper)
        {
            _mapper = mapper;
            basicHttpBinding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Ntlm;
            basicHttpBinding.MaxReceivedMessageSize = int.MaxValue;
        }

        private pendingtravelorder_PortClient Pendingtravelorder_PortClientService()
        {
            credential.UserName = User.Identity.GetUserName();
            credential.Password = User.Identity.GetPassword();
            credential.Domain = config.Integration_Setup.Domain;

            config.Default_Config.Company_Name = User.Identity.GetCompanyName();

            var integrationService = config.Integration_Services
                .Where(x => x.Integration_Type == "Pending_Travel" && x.Company_Name == config.Default_Config.Company_Name)
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new pendingtravelorder_PortClient(basicHttpBinding, endpoint);
            client.ClientCredentials.Windows.ClientCredential = credential;
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            return client;
        }

        private postedtravelordercard_PortClient Postedtravelordercard_PortClientService()
        {
            credential.UserName = User.Identity.GetUserName();
            credential.Password = User.Identity.GetPassword();
            credential.Domain = config.Integration_Setup.Domain;

            config.Default_Config.Company_Name = User.Identity.GetCompanyName();

            var integrationService = config.Integration_Services
                .Where(x => x.Integration_Type == "Posted_Travel" && x.Company_Name == config.Default_Config.Company_Name)
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new postedtravelordercard_PortClient(basicHttpBinding, endpoint);
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
            List<pendingtravelorder> result = new List<pendingtravelorder>();
            try
            {
                pendingtravelorder_Filter[] filter = new pendingtravelorder_Filter[0];
                result = Pendingtravelorder_PortClientService()
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
            return View(result);
        }

        public IActionResult RecommendRequest(string travelOrderNo)
        {
            PostedTravelOrderViewModel vmObj = new PostedTravelOrderViewModel();
            try
            {
                postedtravelordercard obj = new postedtravelordercard();
                postedtravelordercard_Filter[] filter = {
                    new postedtravelordercard_Filter
                    {
                        Field = postedtravelordercard_Fields.Travel_Order_No,
                        Criteria = travelOrderNo
                    }
                };

                obj = Postedtravelordercard_PortClientService()
                    .ReadMultipleAsync(filter, "", 1)
                    .GetAwaiter()
                    .GetResult()
                    .ReadMultiple_Result1
                    .FirstOrDefault();

                vmObj = _mapper.Map<PostedTravelOrderViewModel>(obj);
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return View(vmObj);
        }

        [HttpPost]
        public IActionResult RecommendRequest(PostedTravelOrderViewModel vmObj)
        {
            try
            {
                ModelState.Remove("Rejection_Remarks");
                if (ModelState.IsValid)
                {
                    var obj = _mapper.Map<postedtravelordercard>(vmObj);
                    obj.Local_Transportation_NrsSpecified = true;
                    obj.Fuel_NrsSpecified = true;
                    obj.Other_Expenses_NrsSpecified = true;

                    Update updateObj = new Update
                    {
                        postedtravelordercard = obj
                    };

                    var result = Postedtravelordercard_PortClientService()
                        .UpdateAsync(updateObj)
                        .GetAwaiter()
                        .GetResult()
                        .postedtravelordercard;

                    if(result != null)
                    {
                        var postResult = Hrmgt_PortClientService()
                        .RecommendtravelorderewebAsync(result.Travel_Order_No)
                        .GetAwaiter()
                        .GetResult()
                        .return_value;

                        if (postResult == 200)
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Recommend Travel Order", text = "Travel Request recommended successfully.", type = "success" });
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Recommend Travel Order", text = "Updating travel order succeeded but posting recommendation failed.", type = "error" });
                        }
                    }
                    else
                    {
                        TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Recommend Travel Order", text = "Updating travel order fields failed.", type = "error" });
                    }
                }
                else
                {
                    TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Recommend Travel Order", text = "Validation Error. Try Again.", type = "error" });
                }
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return RedirectToAction(nameof(RecommendRequest), new { travelOrderNo = vmObj.Travel_Order_No });
        }

        public IActionResult RejectRequest(string travelOrderNo)
        {
            PostedTravelOrderViewModel vmObj = new PostedTravelOrderViewModel();
            try
            {
                postedtravelordercard obj = new postedtravelordercard();
                postedtravelordercard_Filter[] filter = {
                    new postedtravelordercard_Filter
                    {
                        Field = postedtravelordercard_Fields.Travel_Order_No,
                        Criteria = travelOrderNo
                    }
                };

                obj = Postedtravelordercard_PortClientService()
                    .ReadMultipleAsync(filter, "", 1)
                    .GetAwaiter()
                    .GetResult()
                    .ReadMultiple_Result1
                    .FirstOrDefault();

                vmObj = _mapper.Map<PostedTravelOrderViewModel>(obj);
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return View(vmObj);
        }

        [HttpPost]
        public IActionResult RejectRequest(PostedTravelOrderViewModel vmObj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var obj = _mapper.Map<postedtravelordercard>(vmObj);
                    Update updateObj = new Update {
                        postedtravelordercard = obj
                    };

                    var result = Postedtravelordercard_PortClientService()
                        .UpdateAsync(updateObj)
                        .GetAwaiter()
                        .GetResult()
                        .postedtravelordercard;

                    if (result != null)
                    {
                        var postResult = Hrmgt_PortClientService()
                            .RejecttravelorderwebAsync(result.Travel_Order_No)
                            .GetAwaiter()
                            .GetResult()
                            .return_value;

                        if (postResult == 200)
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Reject Travel Order", text = "Travel Request rejected successfully.", type = "success" });
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Reject Travel Order", text = "Reject details saved but rejection failed.", type = "error" });
                        }
                    }
                    else
                    {
                        TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Reject Travel Order", text = "Posting reject details failed.", type = "error" });
                    }
                }
                else
                {
                    TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Reject Travel Order", text = "Validation Error. Try Again.", type = "error" });
                }
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return RedirectToAction(nameof(RejectRequest), new { travelOrderNo = vmObj.Travel_Order_No });
        }
    }
}