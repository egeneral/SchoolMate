using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Schoolmate.Data.Models;
using Schoolmate.Data.Repositories;

namespace Schoolmate.Auth.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private ISchoolmateUserRepository Repository { get; }

        public AppUserController(ISchoolmateUserRepository repository)
        {
            Repository = repository;
        }

        [HttpGet]
        public IEnumerable<SchoolmateUser> Index()
        {
            return Repository.GetAll();
        }
    }
}