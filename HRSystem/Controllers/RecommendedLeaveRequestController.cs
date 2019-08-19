using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Threading.Tasks;
using AutoMapper;
using HRMgmt;
using HRSystem.Helper;
using HRSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PostedLeaveRequestCard;
using RecommendedLeaveRequest;

namespace HRSystem.Controllers
{
    public class RecommendedLeaveRequestController : Controller
    {
        private readonly IMapper _mapper;

        readonly BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
        readonly Config config = ConfigJSON.Read();
        readonly NetworkCredential credential = new NetworkCredential();

        public RecommendedLeaveRequestController(IMapper mapper)
        {
            _mapper = mapper;
            basicHttpBinding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Ntlm;
        }

        private recommendedleaverequest_PortClient Recommendedleaverequest_PortClientService()
        {
            credential.UserName = User.Identity.GetUserName();
            credential.Password = User.Identity.GetPassword();
            credential.Domain = config.Integration_Setup.Domain;

            config.Default_Config.Company_Name = User.Identity.GetCompanyName();

            var integrationService = config.Integration_Services
                .Where(x => x.Integration_Type == "Recommended_Leave" && x.Company_Name == config.Default_Config.Company_Name)
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new recommendedleaverequest_PortClient(basicHttpBinding, endpoint);
            client.ClientCredentials.Windows.ClientCredential = credential;
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            return client;
        }

        private postedleaverequestcard_PortClient Postedleaverequestcard_PortClientService()
        {
            credential.UserName = User.Identity.GetUserName();
            credential.Password = User.Identity.GetPassword();
            credential.Domain = config.Integration_Setup.Domain;

            config.Default_Config.Company_Name = User.Identity.GetCompanyName();

            var integrationService = config.Integration_Services
                .Where(x => x.Integration_Type == "Posted_Leave" && x.Company_Name == config.Default_Config.Company_Name)
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new postedleaverequestcard_PortClient(basicHttpBinding, endpoint);
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
            List<recommendedleaverequest> pendingleaverequests = new List<recommendedleaverequest>();
            try
            {
                recommendedleaverequest_Filter[] filters = new recommendedleaverequest_Filter[0];
                pendingleaverequests = Recommendedleaverequest_PortClientService()
                    .ReadMultipleAsync(filters, "", 0)
                    .GetAwaiter()
                    .GetResult()
                    .ReadMultiple_Result1
                    .ToList();
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return View(pendingleaverequests);
        }

        public IActionResult ApproveRequest(string leaveRequestNo)
        {
            PostedLeaveRequestViewModel vmObj = new PostedLeaveRequestViewModel();
            try
            {
                postedleaverequestcard obj = new postedleaverequestcard();
                postedleaverequestcard_Filter[] filter = {
                    new postedleaverequestcard_Filter
                    {
                        Field = postedleaverequestcard_Fields.Leave_Request_No,
                        Criteria = leaveRequestNo
                    }
                };

                obj = Postedleaverequestcard_PortClientService()
                    .ReadMultipleAsync(filter, "", 1)
                    .GetAwaiter()
                    .GetResult()
                    .ReadMultiple_Result1
                    .FirstOrDefault();

                vmObj = _mapper.Map<PostedLeaveRequestViewModel>(obj);
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return View(vmObj);
        }

        [HttpPost]
        public IActionResult ApproveRequest(PostedLeaveRequestViewModel vmObj)
        {
            try
            {
                ModelState.Remove("Rejection_Remarks");
                if (ModelState.IsValid)
                {
                    var obj = _mapper.Map<postedleaverequestcard>(vmObj);
                    obj.Pay_TypeSpecified = true;
                    PostedLeaveRequestCard.Update updateObj = new PostedLeaveRequestCard.Update {
                        postedleaverequestcard = obj
                    };

                    var result = Postedleaverequestcard_PortClientService()
                        .UpdateAsync(updateObj)
                        .GetAwaiter()
                        .GetResult()
                        .postedleaverequestcard;

                    if (result != null)
                    {
                        var postResult = Hrmgt_PortClientService()
                            .ApproveleaverequestwebAsync(result.Leave_Request_No)
                            .GetAwaiter()
                            .GetResult()
                            .return_value;

                        if (postResult == 200)
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Recommended Leave Request", text = "Leave request accepted successfully.", type = "success" });
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Recommended Leave Request", text = "Approval details saved but approval of request failed.", type = "error" });
                        }
                    }
                    else
                    {
                        TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Recommended Leave Request", text = "Posting approval details failed.", type = "error" });
                    }
                }
                else
                {
                    TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Recommended Leave Request", text = "Validation Error. Try Again.", type = "error" });
                }
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return RedirectToAction(nameof(ApproveRequest), new { leaveRequestNo = vmObj.Leave_Request_No });
        }

        public IActionResult RejectRequest(string leaveRequestNo)
        {
            PostedLeaveRequestViewModel vmObj = new PostedLeaveRequestViewModel();
            try
            {
                postedleaverequestcard obj = new postedleaverequestcard();
                postedleaverequestcard_Filter[] filter = {
                    new postedleaverequestcard_Filter
                    {
                        Field = postedleaverequestcard_Fields.Leave_Request_No,
                        Criteria = leaveRequestNo
                    }
                };

                obj = Postedleaverequestcard_PortClientService()
                    .ReadMultipleAsync(filter, "", 1)
                    .GetAwaiter()
                    .GetResult()
                    .ReadMultiple_Result1
                    .FirstOrDefault();

                vmObj = _mapper.Map<PostedLeaveRequestViewModel>(obj);
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return View(vmObj);
        }

        [HttpPost]
        public IActionResult RejectRequest(PostedLeaveRequestViewModel vmObj)
        {
            try
            {
                ModelState.Remove("Pay_Type");
                if (ModelState.IsValid)
                {
                    var obj = _mapper.Map<postedleaverequestcard>(vmObj);
                    PostedLeaveRequestCard.Update updateObj = new PostedLeaveRequestCard.Update {
                        postedleaverequestcard = obj
                    };

                    var result = Postedleaverequestcard_PortClientService()
                        .UpdateAsync(updateObj)
                        .GetAwaiter()
                        .GetResult()
                        .postedleaverequestcard;

                    if (result != null)
                    {
                        var postResult = Hrmgt_PortClientService()
                            .RejectleaverequestwebAsync(result.Leave_Request_No)
                            .GetAwaiter()
                            .GetResult()
                            .return_value;

                        if (postResult == 200)
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Reject Leave Request", text = "Leave request rejected successfully.", type = "success" });
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Reject Leave Request", text = "Reject details saved but rejection failed.", type = "error" });
                        }
                    }
                    else
                    {
                        TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Reject Leave Request", text = "Posting reject details failed.", type = "error" });
                    }
                }
                else
                {
                    TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Reject Leave Request", text = "Validation Error. Try Again.", type = "error" });
                }
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return RedirectToAction(nameof(RejectRequest), new { leaveRequestNo = vmObj.Leave_Request_No });
        }
    }
}