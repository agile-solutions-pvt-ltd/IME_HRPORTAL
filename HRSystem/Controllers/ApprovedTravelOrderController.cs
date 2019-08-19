using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using ApprovedTravelOrder;
using HRSystem.Helper;
using HRSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HRSystem.Controllers
{
    public class ApprovedTravelOrderController : Controller
    {
        readonly BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
        readonly Config config = ConfigJSON.Read();
        readonly NetworkCredential credential = new NetworkCredential();

        public ApprovedTravelOrderController()
        {
            basicHttpBinding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Ntlm;
        }

        private approvedtravelorder_PortClient Approvedleaverequest_PortClientService()
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

        public IActionResult Index()
        {
            List<approvedtravelorder> approvedtravelorders = new List<approvedtravelorder>();
            try
            {
                approvedtravelorder_Filter[] filter = new approvedtravelorder_Filter[0];
                approvedtravelorders = Approvedleaverequest_PortClientService()
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
    }
}