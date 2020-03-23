using System;
using Microsoft.AspNetCore.Identity;

namespace Schoolmate.Data.Models
{
    public partial class SchoolmateUser : IdentityUser
    {
        public SchoolmateUser()
        {
        }

        public string GivenNames { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
    }
}
