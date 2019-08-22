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
using SalaryAdvanceRequest;
using SalaryAdvanceStatus;

namespace HRSystem.Controllers
{
    [Authorize]
    public class SalaryAdvanceController : Controller
    {
        private readonly IMapper _mapper;

        readonly BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
        readonly Config config = ConfigJSON.Read();
        readonly NetworkCredential credential = new NetworkCredential();

        public SalaryAdvanceController(IMapper mapper)
        {
            _mapper = mapper;
            basicHttpBinding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Ntlm;
            basicHttpBinding.MaxReceivedMessageSize = int.MaxValue;
        }

        private salaryadvancestatus_PortClient Salaryadvancestatus_PortClientService()
        {
            credential.UserName = User.Identity.GetUserName();
            credential.Password = User.Identity.GetPassword();
            credential.Domain = config.Integration_Setup.Domain;

            config.Default_Config.Company_Name = User.Identity.GetCompanyName();

            var integrationService = config.Integration_Services
                .Where(x => x.Integration_Type == "Salary_Status" && x.Company_Name == config.Default_Config.Company_Name)
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new salaryadvancestatus_PortClient(basicHttpBinding, endpoint);
            client.ClientCredentials.Windows.ClientCredential = credential;
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            return client;
        }

        private salaryadvancerequest_PortClient Salaryadvancerequest_PortClientService()
        {
            credential.UserName = User.Identity.GetUserName();
            credential.Password = User.Identity.GetPassword();
            credential.Domain = config.Integration_Setup.Domain;

            config.Default_Config.Company_Name = User.Identity.GetCompanyName();

            var integrationService = config.Integration_Services
                .Where(x => x.Integration_Type == "Salary_Advance" && x.Company_Name == config.Default_Config.Company_Name)
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new salaryadvancerequest_PortClient(basicHttpBinding, endpoint);
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
            List<salaryadvancestatus> salaryAdvances = new List<salaryadvancestatus>();
            try
            {
                salaryadvancestatus_Filter[] filter = {
                    new salaryadvancestatus_Filter {
                        Field = salaryadvancestatus_Fields.Employee_No,
                        Criteria = User.Identity.GetEmployeeNo()
                    }
                };

                salaryAdvances = Salaryadvancestatus_PortClientService()
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
            return View(salaryAdvances);
        }

        public IActionResult Submit()
        {
            SalaryAdvanceViewModel vmObj = new SalaryAdvanceViewModel();
            try
            {
                Getapplicablesalaryadvamountandmonthlydeductionweb filter = new Getapplicablesalaryadvamountandmonthlydeductionweb
                {
                    employeeNo = User.Identity.GetEmployeeNo(),
                    applicableAmt = 0,
                    monthlyDeduction = 0
                };

                var result = Hrmgt_PortClientService()
                    .GetapplicablesalaryadvamountandmonthlydeductionwebAsync(filter)
                    .GetAwaiter()
                    .GetResult();

                vmObj.Applicable_Amount = result.applicableAmt;
                vmObj.Monthly_Deduction = result.monthlyDeduction;
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return View(vmObj);
        }

        [HttpPost]
        public IActionResult Submit(SalaryAdvanceViewModel vmObj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var obj = _mapper.Map<salaryadvancerequest>(vmObj);
                    obj.Claimed_AmountSpecified = true;
                    obj.Employee_Name = null;
                    obj.Employee_No = User.Identity.GetEmployeeNo();

                    SalaryAdvanceRequest.Create createObj = new SalaryAdvanceRequest.Create
                    {
                        salaryadvancerequest = obj
                    };

                    var result = Salaryadvancerequest_PortClientService()
                        .CreateAsync(createObj)
                        .GetAwaiter()
                        .GetResult()
                        .salaryadvancerequest;

                    if (result != null)
                    {
                        var postResult = Hrmgt_PortClientService()
                            .PostsalaryadvancewebAsync(result.No)
                            .GetAwaiter()
                            .GetResult()
                            .return_value;

                        if (postResult == 200)
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Salary Advance", text = "Salary advance posted successfully.", type = "success" });
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Error", text = "Salary advance created but submitting failed.", type = "error" });
                        }
                    }
                    else
                    {
                        TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Error", text = "Creating salary advance failed. Try again.", type = "error" });
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