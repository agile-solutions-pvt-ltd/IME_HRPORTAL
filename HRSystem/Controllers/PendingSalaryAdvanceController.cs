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
using PendingSalaryAdvance;
using PostedSalaryAdvance;

namespace HRSystem.Controllers
{
    [Authorize]
    public class PendingSalaryAdvanceController : Controller
    {
        private readonly IMapper _mapper;

        readonly BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
        readonly Config config = ConfigJSON.Read();
        readonly NetworkCredential credential = new NetworkCredential();

        public PendingSalaryAdvanceController(IMapper mapper)
        {
            _mapper = mapper;
            basicHttpBinding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Ntlm;
        }

        private pendingsalaryadvance_PortClient Pendingsalaryadvance_PortClientService()
        {
            credential.UserName = User.Identity.GetUserName();
            credential.Password = User.Identity.GetPassword();
            credential.Domain = config.Integration_Setup.Domain;

            config.Default_Config.Company_Name = User.Identity.GetCompanyName();

            var integrationService = config.Integration_Services
                .Where(x => x.Integration_Type == "Pending_Salary" && x.Company_Name == config.Default_Config.Company_Name)
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new pendingsalaryadvance_PortClient(basicHttpBinding, endpoint);
            client.ClientCredentials.Windows.ClientCredential = credential;
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            return client;
        }

        private postedsalaryadvancecard_PortClient Postedsalaryadvancecard_PortClientService()
        {
            credential.UserName = User.Identity.GetUserName();
            credential.Password = User.Identity.GetPassword();
            credential.Domain = config.Integration_Setup.Domain;

            config.Default_Config.Company_Name = User.Identity.GetCompanyName();

            var integrationService = config.Integration_Services
                .Where(x => x.Integration_Type == "Posted_Salary_Advance" && x.Company_Name == config.Default_Config.Company_Name)
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new postedsalaryadvancecard_PortClient(basicHttpBinding, endpoint);
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
            List<pendingsalaryadvance> result = new List<pendingsalaryadvance>();
            try
            {
                pendingsalaryadvance_Filter[] filter = new pendingsalaryadvance_Filter[0];
                result = Pendingsalaryadvance_PortClientService()
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

        public IActionResult RecommendRequest(string salaryAdvanceNo)
        {
            PostedSalaryAdvanceViewModel vmObj = new PostedSalaryAdvanceViewModel();
            try
            {
                postedsalaryadvancecard obj = new postedsalaryadvancecard();
                postedsalaryadvancecard_Filter[] filter = {
                    new postedsalaryadvancecard_Filter
                    {
                        Field = postedsalaryadvancecard_Fields.No,
                        Criteria = salaryAdvanceNo
                    }
                };

                obj = Postedsalaryadvancecard_PortClientService()
                    .ReadMultipleAsync(filter, "", 1)
                    .GetAwaiter()
                    .GetResult()
                    .ReadMultiple_Result1
                    .FirstOrDefault();

                vmObj = _mapper.Map<PostedSalaryAdvanceViewModel>(obj);
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return View(vmObj);
        }

        [HttpPost]
        public IActionResult RecommendRequest(PostedSalaryAdvanceViewModel vmObj)
        {
            try
            {
                ModelState.Remove("Reason_for_Rejection");
                if (ModelState.IsValid)
                {
                    var obj = _mapper.Map<postedsalaryadvancecard>(vmObj);
                    obj.Approved_AmountSpecified = true;
                    obj.No_of_MonthsSpecified = true;
                    obj.Fixed_Deduction_in_SalarySpecified = true;
                    obj.Employee_Name = null;

                    Update updateObj = new Update
                    {
                        postedsalaryadvancecard = obj
                    };

                    var result = Postedsalaryadvancecard_PortClientService()
                        .UpdateAsync(updateObj)
                        .GetAwaiter()
                        .GetResult()
                        .postedsalaryadvancecard;

                    if (result != null)
                    {
                        var postResult = Hrmgt_PortClientService()
                        .RecommendsalaryadvancewebAsync(result.No)
                        .GetAwaiter()
                        .GetResult()
                        .return_value;

                        if (postResult == 200)
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Recommend Salary Advance", text = "Salary advance recommended successfully.", type = "success" });
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Recommend Salary Advance", text = "Updating salary advance succeeded but posting recommendation failed.", type = "error" });
                        }
                    }
                    else
                    {
                        TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Recommend Salary Advance", text = "Updating salary advance fields failed.", type = "error" });
                    }
                }
                else
                {
                    TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Recommend Salary Advance", text = "Validation Error. Try Again.", type = "error" });
                }
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return RedirectToAction(nameof(RecommendRequest), new { salaryAdvanceNo = vmObj.No });
        }

        public IActionResult RejectRequest(string salaryAdvanceNo)
        {
            PostedSalaryAdvanceViewModel vmObj = new PostedSalaryAdvanceViewModel();
            try
            {
                postedsalaryadvancecard obj = new postedsalaryadvancecard();
                postedsalaryadvancecard_Filter[] filter = {
                    new postedsalaryadvancecard_Filter
                    {
                        Field = postedsalaryadvancecard_Fields.No,
                        Criteria = salaryAdvanceNo
                    }
                };

                obj = Postedsalaryadvancecard_PortClientService()
                    .ReadMultipleAsync(filter, "", 1)
                    .GetAwaiter()
                    .GetResult()
                    .ReadMultiple_Result1
                    .FirstOrDefault();

                vmObj = _mapper.Map<PostedSalaryAdvanceViewModel>(obj);
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return View(vmObj);
        }

        [HttpPost]
        public IActionResult RejectRequest(PostedSalaryAdvanceViewModel vmObj)
        {
            try
            {
                ModelState.Remove("Approved_Amount");
                ModelState.Remove("No_of_Months");
                ModelState.Remove("Fixed_Deduction_in_Salary");
                if (ModelState.IsValid)
                {
                    var obj = _mapper.Map<postedsalaryadvancecard>(vmObj);
                    Update updateObj = new Update
                    {
                        postedsalaryadvancecard = obj
                    };

                    var result = Postedsalaryadvancecard_PortClientService()
                        .UpdateAsync(updateObj)
                        .GetAwaiter()
                        .GetResult()
                        .postedsalaryadvancecard;

                    if (result != null)
                    {
                        var postResult = Hrmgt_PortClientService()
                            .RejectsalaryadvancewebAsync(result.No)
                            .GetAwaiter()
                            .GetResult()
                            .return_value;

                        if (postResult == 200)
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Reject Salary Advance", text = "Salary advance rejected successfully.", type = "success" });
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Reject Salary Advance", text = "Reject details saved but rejection failed.", type = "error" });
                        }
                    }
                    else
                    {
                        TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Reject Salary Advance", text = "Posting reject details failed.", type = "error" });
                    }
                }
                else
                {
                    TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Reject Salary Advance", text = "Validation Error. Try Again.", type = "error" });
                }
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return RedirectToAction(nameof(RejectRequest), new { salaryAdvanceNo = vmObj.No });
        }
    }
}