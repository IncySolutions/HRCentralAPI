using HRCentral_api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HRCentral_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class resourcerequestpost : ControllerBase
    {
        [HttpPost]     
            
        public IActionResult Temp(ResourcerRquest_post obj)
        {
            try
            {
                string query = "INSERT INTO dbo.Test(PersonID,LastName,FirstName,Address,City)" + "VALUES(@PersonID,@LastName,@FirstName,@Address,@City)";
                using (SqlConnection con = new SqlConnection("server=incyhrcentral.database.windows.net;database=hrcentral_Dev; uid=hrcentral;pwd=AmishAditya@123"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@PersonID", SqlDbType.Int).Value = 12345;
                        cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = "AMISH";
                        cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = "RAJ";
                        cmd.Parameters.Add("@Address", SqlDbType.VarChar, 50).Value = "Test Address";
                        cmd.Parameters.Add("@City", SqlDbType.VarChar,50).Value = "Test Address city1";
                        
                        // open connection, execute INSERT, close connection
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                      
                    }
                   // return Ok("Success");
                }
                //return Ok("Success");
            }
            catch(Exception ex)
            {
                return Ok(ex);

            }

            //string x = obj.name;
            //return obj.name;
            return Ok("Success");
        }
    }
}
