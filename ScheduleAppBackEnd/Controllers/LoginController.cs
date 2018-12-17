using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd;
using Microsoft.AspNetCore.Mvc;

namespace ScheduleAppBackEnd.Controllers
{
    [Route("api/login")]
    public class LoginController : Controller
    {
        private readonly IRepository _repo;

        public LoginController(IRepository repository)
        {
            _repo = repository;
        }
        // POST api/values
        [HttpPost]
        public ActionResult<User> Post([FromBody] User usr)
        {
            if (_repo.Login(usr) == null)
            {
                return Unauthorized();
            } else
            {
                return _repo.Login(usr);
            }
        }
    }
}
