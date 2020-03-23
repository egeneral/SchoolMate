using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Schoolmate.Data.Models;

namespace Schoolmate.Data.Repositories
{
    public interface ISchoolmateUserRepository : IRepository<SchoolmateUser>
    {
        // other custom queries go here
    }

    public class SchoolmateUserRepository : Repository<SchoolmateUser>, ISchoolmateUserRepository
    {
        public SchoolmateUserRepository(SchoolmateAuthDbContext context)
            : base(context)
        {
        }
    }
}
