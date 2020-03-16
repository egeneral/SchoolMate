using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Schoolmate.Data.Models;

namespace Schoolmate.Data
{
    public class SchoolmateAuthDbContext : IdentityDbContext<SchoolmateUser>
    {
        public SchoolmateAuthDbContext(DbContextOptions<SchoolmateAuthDbContext> options)
            : base(options)
        {
        }
    }
}
