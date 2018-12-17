using System;

namespace BackEnd
{
    public class Note
    {
        public int ID { get; set; }
        public string User { get; set; }
        public string MsgText { get; set; }
        public DateTime PostDate { get; set; }
    }
}
