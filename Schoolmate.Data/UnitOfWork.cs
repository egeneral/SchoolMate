using System;
using Schoolmate.Data.Repositories;

namespace Schoolmate.Data
{
    public interface IUnitOfWork : IDisposable
    {
        ISchoolmateUserRepository SchoolmateUsers { get; }
        int Complete();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolmateAuthDbContext _context;

        public UnitOfWork(SchoolmateAuthDbContext context)
        {
            _context = context;
            SchoolmateUsers = new SchoolmateUserRepository(_context);
        }

        public ISchoolmateUserRepository SchoolmateUsers { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
