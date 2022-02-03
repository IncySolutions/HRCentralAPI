using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRCentral_api.Model
{
    public class ResourcerRquest_post
    {
        public string JobCode { get; set; }
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public string JobProfile { get; set; }
        public string createdDate { get; set; }
        public string ClosurePeriod { get; set; }
        public string Experience { get; set; }
        public string JobType { get; set; }
        public string BudgetRange { get; set; }
        public string JobDescription { get; set; }
        public string Status { get; set; }

    }

    public class testDBData
    {
        public string PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

    }

    public class AdminRoles
    {
        // public int Emp_Id { get; set; }
        public string EmailID { get; set; }
        // public string Role { get; set; }

    }





}
