using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd;
using Microsoft.AspNetCore.Mvc;

namespace ScheduleAppBackEnd.Controllers
{
    [Route("api/user")]
    public class UserController : Controller
    {
        private readonly IRepository _repo;

        public UserController(IRepository repository)
        {
            _repo = repository;
        }
        // POST api/values
        [HttpPost]
        public ActionResult<User> Post([FromBody] User usr)
        {
            _repo.Login(usr);
            return usr;
        }
    }
}
