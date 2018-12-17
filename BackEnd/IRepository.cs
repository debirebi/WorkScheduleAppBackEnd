using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public interface IRepository
    {
        IEnumerable<User> ReadAllUsers();
        IEnumerable<Note> ReadAllNotes();
        IEnumerable<CalendarEvent> ReadAllEvents();
        Note DeleteNote(int id);
        Note FindNoteByID(int id);
        Note NewNote(Note msg);
        User NewUser(User user);
        User Login(User user);
        CalendarEvent NewEvent(CalendarEvent evnt);
        CalendarEvent FindEventByID(int id);
        CalendarEvent DeleteEvent(int id);

    }
}
