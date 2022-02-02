using HRCentral_api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.IdentityModel.clients.ActiveDirectory;

namespace HRCentral_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Graph
    {
        public string clientID = "";
        public string clientSecret = "";
        public string tenantId = "";
        ClientCredential cc=new ClientCredential(clientID, clientSecret)

        return ok("Success");
    }
}
