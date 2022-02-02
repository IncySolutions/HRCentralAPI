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
                string query = "INSERT INTO dbo.resourcerequest(Job_code,Emp_Id,Fname,Lname,EmailID,Designation,Job_Description,Job_profile,Created_Date,Closure_Period,Experience,Job_Type,Budget_Range,Status)" + "VALUES(@Job_code,@Emp_Id,@Fname,@Lname,@EmailID,@Designation,@Job_Description,@Job_profile,@Created_Date,@Closure_Period,@Experience,@Job_Type,@Budget_Range,@Status)";
                using (SqlConnection con = new SqlConnection("server=incyhrcentral.database.windows.net;database=hrcentral_Dev; uid=hrcentral;pwd=AmishAditya@123"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@Job_code", SqlDbType.Char).Value = obj.JobCode;
                        cmd.Parameters.Add("@Emp_Id", SqlDbType.Int).Value = obj.EmpId;
                        cmd.Parameters.Add("@Fname", SqlDbType.VarChar, 50).Value = obj.FirstName;
                        cmd.Parameters.Add("@Lname", SqlDbType.VarChar, 50).Value = obj.LastName;
                        cmd.Parameters.Add("@EmailID", SqlDbType.VarChar, 50).Value = obj.Email;
                        cmd.Parameters.Add("@Designation", SqlDbType.Char, 50).Value = obj.Designation;
                        cmd.Parameters.Add("@Job_Description", SqlDbType.VarChar, 50).Value = obj.JobDescription;
                        cmd.Parameters.Add("@Job_profile", SqlDbType.VarChar, 50).Value = obj.JobProfile;
                        cmd.Parameters.Add("@Created_Date", SqlDbType.DateTime, 50).Value = obj.createdDate;
                        cmd.Parameters.Add("@Closure_Period", SqlDbType.VarChar, 50).Value = obj.ClosurePeriod;
                        cmd.Parameters.Add("@Experience", SqlDbType.Char, 50).Value = obj.Experience;
                        cmd.Parameters.Add("@Job_Type", SqlDbType.Char, 50).Value = obj.JobType;
                        cmd.Parameters.Add("@Budget_Range", SqlDbType.Char, 50).Value = obj.BudgetRange;
                        cmd.Parameters.Add("@Status", SqlDbType.Char, 50).Value = obj.Status;
                        // open connection, execute INSERT, close connection
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }
                    // return Ok("Success");
                }
                //return Ok("Success");
            }
            catch (Exception ex)
            {
                return Ok(ex);

            }

            //string x = obj.name;
            //return obj.name;
            return Ok("Success");
        }
      
    }
}
