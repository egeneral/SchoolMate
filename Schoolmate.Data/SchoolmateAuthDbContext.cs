using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Schoolmate.Data
{
    public class SchoolmateAuthDbContext : IdentityDbContext<IdentityUser>
    {
        public SchoolmateAuthDbContext(DbContextOptions<SchoolmateAuthDbContext> options)
            : base(options)
        {
        }
    }
}
