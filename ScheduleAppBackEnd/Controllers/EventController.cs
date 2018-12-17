using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd;
using Microsoft.AspNetCore.Mvc;

namespace ScheduleAppBackEnd.Controllers
{
    [Route("api/event")]
    public class EventController : Controller
    {
        private readonly IRepository _repo;

        public EventController(IRepository repository)
        {
            _repo = repository;
        }


        // GET api/values
        [HttpGet]
        public ActionResult<List<CalendarEvent>> Get()
        {
            return _repo.ReadAllEvents().ToList();
        }

        // POST api/values
        [HttpPost]
        public ActionResult<CalendarEvent> Post([FromBody] CalendarEvent evnt)
        {
            return _repo.NewEvent(evnt);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repo.DeleteEvent(id);
        }
    }
}
