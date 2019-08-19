using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using AutoMapper;
using EmployeeList;
using HRMgmt;
using HRSystem.Helper;
using HRSystem.Models;
using LeaveRequestCard;
using LeaveStatus;
using LeaveTypeCode;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HRSystem.Controllers
{
    [Authorize]
    public class LeaveRequestController : Controller
    {
        private readonly IMapper _mapper;

        readonly BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
        readonly Config config = ConfigJSON.Read();
        readonly NetworkCredential credential = new NetworkCredential();

        public LeaveRequestController(IMapper mapper)
        {
            this._mapper = mapper;
            basicHttpBinding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Ntlm;
            basicHttpBinding.MaxReceivedMessageSize = int.MaxValue;
        }

        private leavestatus_PortClient Leavestatus_PortClientService ()
        {
            credential.UserName = User.Identity.GetUserName();
            credential.Password = User.Identity.GetPassword();
            credential.Domain = config.Integration_Setup.Domain;

            config.Default_Config.Company_Name = User.Identity.GetCompanyName();

            var integrationService = config.Integration_Services
                .Where(x => x.Integration_Type == "Leave_Status" && x.Company_Name == config.Default_Config.Company_Name)
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new leavestatus_PortClient(basicHttpBinding, endpoint);
            client.ClientCredentials.Windows.ClientCredential = credential;
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            return client;
        }

        private leavetypecode_PortClient Leavetypecode_PortClientService()
        {
            credential.UserName = User.Identity.GetUserName();
            credential.Password = User.Identity.GetPassword();
            credential.Domain = config.Integration_Setup.Domain;

            config.Default_Config.Company_Name = User.Identity.GetCompanyName();

            var integrationService = config.Integration_Services
                .Where(x => x.Integration_Type == "Leave_Type" && x.Company_Name == config.Default_Config.Company_Name)
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new leavetypecode_PortClient(basicHttpBinding, endpoint);
            client.ClientCredentials.Windows.ClientCredential = credential;
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            return client;
        }

        private employeelist_PortClient Employeelist_PortClientService()
        {
            credential.UserName = User.Identity.GetUserName();
            credential.Password = User.Identity.GetPassword();
            credential.Domain = config.Integration_Setup.Domain;

            config.Default_Config.Company_Name = User.Identity.GetCompanyName();

            var integrationService = config.Integration_Services
                .Where(x => x.Integration_Type == "Employee_List" && x.Company_Name == config.Default_Config.Company_Name)
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new employeelist_PortClient(basicHttpBinding, endpoint);
            client.ClientCredentials.Windows.ClientCredential = credential;
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            return client;
        }

        private leaverequestcard_PortClient Leaverequestcard_PortClientService()
        {
            credential.UserName = User.Identity.GetUserName();
            credential.Password = User.Identity.GetPassword();
            credential.Domain = config.Integration_Setup.Domain;

            config.Default_Config.Company_Name = User.Identity.GetCompanyName();

            var integrationService = config.Integration_Services
                .Where(x => x.Integration_Type == "Leave_Request" && x.Company_Name == config.Default_Config.Company_Name)
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new leaverequestcard_PortClient(basicHttpBinding, endpoint);
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

        public List<leavetypecode> GetLeavetypecodes()
        {
            List<leavetypecode> leavetypecodes = new List<leavetypecode>();
            try
            {
                leavetypecode_Filter[] filter = new leavetypecode_Filter[0];
                leavetypecodes = Leavetypecode_PortClientService()
                    .ReadMultipleAsync(filter, "", 0)
                    .GetAwaiter()
                    .GetResult()
                    .ReadMultiple_Result1
                    .ToList();
            }
            catch(Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return leavetypecodes;
        }

        public List<employeelist> GetEmployeelists()
        {
            List<employeelist> employeelists = new List<employeelist>();
            try
            {
                employeelist_Filter[] filter = new employeelist_Filter[0];
                employeelists = Employeelist_PortClientService()
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
            return employeelists;
        }

        public IActionResult Index()
        {
            List<leavestatus> leavestatuses = new List<leavestatus>();
            try
            {
                leavestatus_Filter[] filter = {
                    new leavestatus_Filter {
                        Field = leavestatus_Fields.Employee_No,
                        Criteria = User.Identity.GetEmployeeNo()
                    }
                };

                leavestatuses = Leavestatus_PortClientService()
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
            return View(leavestatuses);
        }

        public IActionResult Submit()
        {
            ViewBag.LeaveTypeCodes = GetLeavetypecodes();
            ViewBag.EmployeeList = GetEmployeelists();
            return View();
        }

        [HttpPost]
        public IActionResult Submit(LeaveRequestViewModel vmObj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var obj = _mapper.Map<leaverequestcard>(vmObj);
                    obj.Leave_Start_DateSpecified = true;
                    obj.Leave_End_DateSpecified = true;
                    obj.Leave_TypeSpecified = true;

                    LeaveRequestCard.Create createObj = new LeaveRequestCard.Create {
                        leaverequestcard = obj
                    };

                    var result = Leaverequestcard_PortClientService()
                        .CreateAsync(createObj)
                        .GetAwaiter()
                        .GetResult()
                        .leaverequestcard;

                    if(result != null)
                    {
                        var postResult = Hrmgt_PortClientService()
                            .PostleaverequestwebAsync(result.Leave_Request_No)
                            .GetAwaiter()
                            .GetResult()
                            .return_value;
                        if (postResult == 200)
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Success", text = "Leave request posted successfully.", type = "success" });
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Error", text = "Leave request created but submitting failed.", type = "error" });
                        }
                    }
                    else
                    {
                        TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Error", text = "Creating leave request failed. Try Again.", type = "error" });
                    }
                }
                else
                {
                    TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Validation Error", text = "Insert proper values for each fields.", type = "error" });
                }
            }
            catch(Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }

            ViewBag.LeaveTypeCodes = GetLeavetypecodes();
            ViewBag.EmployeeList = GetEmployeelists();
            return View(vmObj);
        }
    }
}