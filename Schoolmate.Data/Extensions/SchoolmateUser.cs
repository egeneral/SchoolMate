using System;

namespace Schoolmate.Data.Models
{
    public partial class SchoolmateUser
    {
        public int Age => new DateTime(DateTime.Now.Subtract(Birthdate).Ticks).Year - 1;
    }
}
