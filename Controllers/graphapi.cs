using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HRCentral_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class graphapi : ControllerBase
    {
        public static string clientID = "4068c3c6-98bb-4996-b3e1-8c95fcf4506e";
        public static string clientSecret = "u2z7Q~xbYwhOb7YWfYna6aXLuxCR0xe-LfZEv";
        public static string tenantId = "e273b27e-58f5-4705-83f5-7d25543afa6e";
        ////string msGraphResourceUrl = "https://graph.microsoft.com";
        string authority = $"https://login.microsoftonline.com/{tenantId}";
        private static HttpClient httpClient = new HttpClient();

        public async void test()
        {
            ClientCredential cc = new ClientCredential(clientID, clientSecret);
            var context = new AuthenticationContext("https://login.microsoftonline.com/" + tenantId + "/oauth2/v2.0/token");
            var result = context.AcquireTokenAsync("https://management.azure.com/", cc);
            var graphAccessToken = result.Result.AccessToken;

            if (graphAccessToken != null)
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", graphAccessToken);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var request = new HttpRequestMessage(HttpMethod.Get, $"https://graph.microsoft.com/v1.0/me?$select=displayName");
                var response = await httpClient.SendAsync(request);
                string responseString = await response.Content.ReadAsStringAsync();              


            }
            

        }

    }

}
