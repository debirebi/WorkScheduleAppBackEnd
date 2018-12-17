using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public class Repository: IRepository
    {

        private List<Note> _notes = FakeDB.NoteList;
        private List<User> _users = FakeDB.UserList;
        private List<CalendarEvent> _events = FakeDB.CalendarEventList;
        static int eventID = 2;
        public IEnumerable<Note> ReadAllNotes()
        {
            return _notes;
        }
        public IEnumerable<User> ReadAllUsers()
        {
            return _users;
        }
        public IEnumerable<CalendarEvent> ReadAllEvents()
        {
            return _events;
        }

        public Note NewNote(Note msg)
        {
            _notes.Add(msg);
            return msg;
        }

        public User NewUser(User user)
        {
            _users.Add(user);
            return user;
        }

        public CalendarEvent NewEvent(CalendarEvent evnt)
        {
            eventID++;
            evnt.ID = eventID;
            _events.Add(evnt);
            return evnt;
        }

        public CalendarEvent DeleteEvent(int id)
        {
            var eventFound = this.FindEventByID(id);
            if(eventFound != null)
            {
                _events.Remove(eventFound);
                return eventFound;
            }
            return null;
        }

        public User Login(User user)
        {
            foreach(var usr in _users)
            {
                if(user.UserName == usr.UserName && user.Password == usr.Password)
                {
                    return usr;
                }
            }
            return null;
        }

        public CalendarEvent FindEventByID(int id)
        {
            foreach(var evnt in _events)
            {
                if(evnt.ID == id)
                {
                    return evnt;
                }
            }

            return null;
        }

        public Note DeleteNote(int id)
        {
            var msgFound = this.FindNoteByID(id);
            if (msgFound != null)
            {
                _notes.Remove(msgFound);
                return msgFound;
            }
            return null;
        }

        public Note FindNoteByID(int id)
        {
            foreach (var msg in _notes)
            {
                if (msg.ID == id)
                {
                    return msg;
                }
            }

            return null;
        }
    }
}
