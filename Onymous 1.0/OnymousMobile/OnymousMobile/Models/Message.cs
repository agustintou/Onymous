using System;

namespace OnymousMobile.Models
{
    public class Message : EntityBase
    {
        public string Content { get; set; }

        public bool Answered { get; set; }

        public long PersonAddressee { get; set; }

        public long PersonSender { get; set; }

        public DateTime Date { get; set; }

        public int Likes { get; set; }
    }
}
