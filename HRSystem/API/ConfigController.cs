using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.ServiceModel;
using HRSystem.Helper;
using HRSystem.Models;
using IntegrationServices;
using IntegrationSetup;
using Microsoft.AspNetCore.Mvc;

namespace HRSystem.API
{
    public class ConfigSetup
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string BaseURL { get; set; }
        [Required]
        public string ServiceInstance { get; set; }
        [Required]
        public string Domain { get; set; }
    }

    [Route("~/api/Config")]
    public class ConfigController : Controller
    {
        public integrationsetup_PortClient Integrationsetup_PortClientService()
        {
            BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
            basicHttpBinding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Ntlm;

            Config config = ConfigJSON.Read();

            NetworkCredential credential = new NetworkCredential
            {
                UserName = config.Default_Config.Username,
                Password = config.Default_Config.Password,
                Domain = config.Integration_Setup.Domain
            };

            EndpointAddress endpoint = new EndpointAddress(
                config.URL + config.Default_Config.Integration_Services.Where(x => x.Integration_Type == "Integration_Setup").FirstOrDefault().Service_Name);

            var client = new integrationsetup_PortClient(basicHttpBinding, endpoint);
            client.ClientCredentials.Windows.ClientCredential = credential;
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            return client;
        }

        public integrationservice_PortClient Integrationservice_PortClientService()
        {
            BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
            basicHttpBinding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Ntlm;
            basicHttpBinding.MaxReceivedMessageSize = int.MaxValue;

            Config config = ConfigJSON.Read();

            NetworkCredential credential = new NetworkCredential
            {
                UserName = config.Default_Config.Username,
                Password = config.Default_Config.Password,
                Domain = config.Integration_Setup.Domain
            };

            EndpointAddress endpoint = new EndpointAddress(
                config.URL + config.Default_Config.Integration_Services.Where(x => x.Integration_Type == "Integration_Service").FirstOrDefault().Service_Name);

            var client = new integrationservice_PortClient(basicHttpBinding, endpoint);
            client.ClientCredentials.Windows.ClientCredential = credential;
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            return client;
        }

        [Route("~/api/Config/ConfigDefaultSetup")]
        [HttpPost]
        public IActionResult UpdateDefaultSetup(ConfigSetup obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Config config = ConfigJSON.Read();

                    config.Default_Config.Username = obj.Username;
                    config.Default_Config.Password = obj.Password;
                    config.Default_Config.Company_Name = obj.CompanyName;
                    config.Default_Config.Type = obj.Type;
                    config.Integration_Setup.Base_URL = obj.BaseURL;
                    config.Integration_Setup.Service_Instance = obj.ServiceInstance;
                    config.Integration_Setup.Domain = obj.Domain;

                    config.URL = obj.BaseURL
                        + '/'
                        + obj.ServiceInstance
                        + '/'
                        + config.Integration_Setup.Integration_Name
                        + '/'
                        + obj.CompanyName
                        + '/'
                        + obj.Type
                        + '/';

                    ConfigJSON.Write(config);
                    return StatusCode(Convert.ToInt32(HttpStatusCode.OK), config);
                }
                return StatusCode(Convert.ToInt32(HttpStatusCode.BadRequest), ModelState);
            }
            catch (Exception ex)
            {
                return StatusCode(Convert.ToInt32(HttpStatusCode.InternalServerError), ex.Message);
            }
        }

        [Route("~/api/Config/ConfigIntegrationSetup")]
        [HttpPost]
        public IActionResult UpdateIntegrationSetup()
        {
            try
            {
                integrationsetup_Filter[] filter = new integrationsetup_Filter[0];
                integrationsetup result = Integrationsetup_PortClientService()
                    .ReadMultipleAsync(filter, "", 0)
                    .GetAwaiter()
                    .GetResult()
                    .ReadMultiple_Result1
                    .FirstOrDefault();

                Config config = ConfigJSON.Read();
                config.Integration_Setup = new Integration_Setup
                {
                    Base_URL = result.Base_URL.Remove(result.Base_URL.Length - 1) + ':' + result.Port,
                    Service_Instance = result.Service_Instance,
                    Domain = result.Domain.Remove(result.Domain.Length - 1),
                    Integration_Name = "WS"
                };

                config.URL = config.Integration_Setup.Base_URL
                    + '/'
                    + config.Integration_Setup.Service_Instance
                    + '/'
                    + config.Integration_Setup.Integration_Name
                    + '/'
                    + config.Default_Config.Company_Name
                    + '/'
                    + config.Default_Config.Type
                    + '/';

                ConfigJSON.Write(config);
                return StatusCode(Convert.ToInt32(HttpStatusCode.OK), result);
            }
            catch(Exception ex)
            {
                return StatusCode(Convert.ToInt32(HttpStatusCode.InternalServerError), ex.Message);
            }
        }

        [Route("~/api/Config/ConfigIntegrationServices")]
        [HttpPost]
        public IActionResult UpdateIntegrationServices()
        {
            try
            {
                integrationservice_Filter[] filter = new integrationservice_Filter[0];
                var oldResult = Integrationservice_PortClientService()
                    .ReadMultipleAsync(filter, "", 0)
                    .GetAwaiter()
                    .GetResult();

                var newResult = oldResult.ReadMultiple_Result1;
                var result = newResult.ToList();

                Config config = ConfigJSON.Read();

                List<Integration_Service> integration_Services = new List<Integration_Service>();
                foreach (var item in result)
                {
                    integration_Services.Add(
                         new Integration_Service
                         {
                             Integration_Type = item.Integration_Type.ToString(),
                             Service_Name = item.Service_Name,
                             Type = item.Type.ToString(),
                             Company_Name = item.Company_Name
                         });
                }

                config.Integration_Services = integration_Services.ToArray();
                ConfigJSON.Write(config);

                return StatusCode(Convert.ToInt32(HttpStatusCode.OK), result);
            }
            catch (Exception ex)
            {
                return StatusCode(Convert.ToInt32(HttpStatusCode.InternalServerError), ex.Message);
            }
        }
    }
}