using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd;
using Microsoft.AspNetCore.Mvc;

namespace ScheduleAppBackEnd.Controllers
{
    [Route("api/note")]
    public class NoteController : Controller
    {
        private readonly IRepository _repo;

        public NoteController(IRepository repository)
        {
            _repo = repository;
        }

        // GET api/note
        [HttpGet]
        public ActionResult <List<Note>> Get()
        {
            return _repo.ReadAllNotes().ToList();
        }

        // POST api/note
        [HttpPost]
        public ActionResult<Note> Post([FromBody] Note msg)
        {
            return _repo.NewNote(msg);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             _repo.DeleteNote(id);
        }
    }
}
