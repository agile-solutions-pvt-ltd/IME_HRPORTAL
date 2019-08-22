using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.ServiceModel;
using Companies;
using HRMgmt;
using HRSystem.Helper;
using HRSystem.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using EmployeeList;

namespace HRSystem.Controllers
{
    public class AccountController : Controller
    {
        readonly BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
        readonly Config config = ConfigJSON.Read();
        readonly NetworkCredential credential = new NetworkCredential();

        public AccountController()
        {
            basicHttpBinding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Ntlm;
            basicHttpBinding.MaxReceivedMessageSize = int.MaxValue;
        }
        
        public companies_PortClient Companies_PortClientService()
        {
            credential.UserName = config.Default_Config.Username;
            credential.Password = config.Default_Config.Password;
            credential.Domain = config.Integration_Setup.Domain;

            var integrationService = config.Default_Config.Integration_Services
                .Where(x => x.Integration_Type == "Company")
                .FirstOrDefault();

            config.Default_Config.Type = integrationService.Type;

            string URL = ConfigJSON.GetURL(config, integrationService.Service_Name);

            EndpointAddress endpoint = new EndpointAddress(URL);

            var client = new companies_PortClient(basicHttpBinding, endpoint);
            client.ClientCredentials.Windows.ClientCredential = credential;
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            return client;
        }

        public hrmgt_PortClient Hrmgt_PortClientService()
        {
            credential.UserName = config.Default_Config.Username;
            credential.Password = config.Default_Config.Password;
            credential.Domain = config.Integration_Setup.Domain;

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

        private employeelist_PortClient EmployeeList_PortClientService()
        {
            credential.UserName = config.Default_Config.Username;
            credential.Password = config.Default_Config.Password;
            credential.Domain = config.Integration_Setup.Domain;

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

        public List<companies> GetCompaniesList()
        {
            List<companies> companiesCardList = new List<companies>();
            try
            {
                Config mainConfig = ConfigJSON.Read();
                config.Default_Config.Username = mainConfig.Default_Config.Username;
                config.Default_Config.Password = mainConfig.Default_Config.Password;
                config.Default_Config.Type = mainConfig.Default_Config.Type;
                config.Default_Config.Company_Name = mainConfig.Default_Config.Company_Name;

                companies_Filter[] filters = new companies_Filter[0];
                companiesCardList = Companies_PortClientService()
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
            return companiesCardList;
        }

        public employeelist GetEmployeeByEmployeeNo(string employeeNo)
        {
            employeelist employee = new employeelist();
            try
            {
                employeelist_Filter[] filters = {
                    new employeelist_Filter
                    {
                        Field = employeelist_Fields.No,
                        Criteria = employeeNo
                    }
                };

                employee = EmployeeList_PortClientService()
                    .ReadMultipleAsync(filters, "", 1)
                    .GetAwaiter()
                    .GetResult()
                    .ReadMultiple_Result1
                    .FirstOrDefault();
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            return employee;
        }

        public IActionResult Login(string ReturnUrl = "")
        {
            if(User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            Login login = new Login
            {
                ReturnUrl = ReturnUrl,
                Companies = GetCompaniesList().Select(x => new SelectListItem { Value = x.Key, Text = x.Name })
            };
            return View(login);
        }

        [HttpPost]
        public IActionResult Login(Login obj)
        {
            try
            {
                string applogin_ResultValue;

                string companyRecID = Companies_PortClientService()
                    .GetRecIdFromKeyAsync(obj.Company)
                    .GetAwaiter()
                    .GetResult()
                    .GetRecIdFromKey_Result1;

                config.Default_Config.Company_Name = Companies_PortClientService()
                    .ReadByRecIdAsync(companyRecID)
                    .GetAwaiter()
                    .GetResult()
                    .companies.Name;

                config.Default_Config.Username = obj.Username;
                config.Default_Config.Password = obj.Password;

                applogin_ResultValue = Hrmgt_PortClientService()
                    .ApploginAsync(config.Default_Config.Username)
                    .GetAwaiter()
                    .GetResult()
                    .return_value;

                if (applogin_ResultValue != null && applogin_ResultValue != "")
                {
                    var employeeDetails = GetEmployeeByEmployeeNo(applogin_ResultValue);
                    SignInUser(obj.RememberMe, employeeDetails);

                    if (obj.ReturnUrl != "" && obj.ReturnUrl != null)
                        return Redirect(obj.ReturnUrl);
                    else
                        return RedirectToAction("Index", "Home");
                }
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Invalid Login", text = "Invalid Username or Password or Company.", type = "error" });
            }
            catch (Exception ex)
            {
                TempData["Notify"] = JsonConvert.SerializeObject(new Notify { title = "Exception Error", text = ex.Message, type = "error" });
            }
            obj.Companies = GetCompaniesList().Select(x => new SelectListItem { Value = x.Key, Text = x.Name });
            return View(obj);
        }
        
        public async void SignInUser(bool rememberMe, employeelist employeelist)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, employeelist.Full_Name),
                new Claim("UserName", config.Default_Config.Username),
                new Claim("EmployeeNo", employeelist.No),
                new Claim("Password", config.Default_Config.Password),
                new Claim("CompanyName", config.Default_Config.Company_Name)
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties {
                IsPersistent = rememberMe
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity)
                ,authProperties);
        }

        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(Login));
        }
    }
}