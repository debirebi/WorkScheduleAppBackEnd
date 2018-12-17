using BackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public class CalendarEvent
    {
        public int ID { get; set; }
        public string title { get; set; }
        public CalendarColor color { get; set; }
        public string start { get; set; }
    }
}
