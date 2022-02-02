using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace HRCentral_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class graphapi : ControllerBase
    {
        public static string clientID = "4068c3c6-98bb-4996-b3e1-8c95fcf4506e";
        public static string clientSecret = "u2z7Q~xbYwhOb7YWfYna6aXLuxCR0xe-LfZEv";
        public static string tenantId = "e273b27e-58f5-4705-83f5-7d25543afa6e";
        string msGraphResourceUrl = "https://graph.microsoft.com";
        string authority = $"https://login.microsoftonline.com/{tenantId}";        

        public void test()
        {
            ClientCredential cc = new ClientCredential(clientID, clientSecret);
            var context = new AuthenticationContext("https://login.microsoftonline.com/" + tenantId + "/oauth2/v2.0/token");
            var result = context.AcquireTokenAsync("https://graph.microsoft.com/.default", cc);

            if(result.Result==null)
            {

                
            }
            

        }

    }

}
