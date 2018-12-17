using BackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public static class FakeDB
    {   
        public static List<User> UserList = new List<User>();
        public static List<Note> NoteList = new List<Note>();
        public static List<CalendarEvent> CalendarEventList = new List<CalendarEvent>();
        private static int id = 0;
        public static  void SeedDB()
        {
            var rebekaR = new User()
            {
                UserName = "Rebeka",
                Password = "1234",
                IsAdmin = true
            };
            var adnanR = new User()
            {
                UserName = "Adnan",
                Password = "1234",
                IsAdmin = false
            };
            var attilaR = new User()
            {
                UserName = "Attila",
                Password = "1234",
                IsAdmin = false
            };

            UserList.Add(rebekaR);
            UserList.Add(adnanR);
            UserList.Add(attilaR);

            //Adding some Test messages
            var msg1 = new Note()
            {
                MsgText = "This is a Test MSG",
                PostDate = DateTime.Now,
                User = "Rebeka"
            };
            var msg2 = new Note()
            {
                MsgText = "This is a Test MSG",
                PostDate = DateTime.Now,
                User = "Adnan"
            };
            NoteList.Add(msg1);
            NoteList.Add(msg2);

            var red = new CalendarColor()
            {
                Primary = "#ad2121",
                Secondary = "#FAE3E3"
            };

            var blue = new CalendarColor()
            {
                Primary = "#1e90ff",
                Secondary = "#D1E8FF"
            };

            var yellow = new CalendarColor()
            {
                Primary = "#e3bc08",
                Secondary = "#FDF1BA"
            };

            var event1 = new CalendarEvent()
            {
                ID = id++,
                title = "Adnan",
                color = yellow,
                start = "2018-12-15"
            };
    //    primary: '#ad2121',
    //secondary: '#FAE3E3'
            var event2 = new CalendarEvent()
            {
                ID = id++,
                title = "Rebeka",
                color = red,
                start = "2018-12-16"
            };
            var event3 = new CalendarEvent()
            {
                ID = id++,
                title = "Adnan",
                color = blue,
                start = "2018-12-17"
            };
            CalendarEventList.Add(event1);
            CalendarEventList.Add(event2);
            CalendarEventList.Add(event3);

        }
    }
}
