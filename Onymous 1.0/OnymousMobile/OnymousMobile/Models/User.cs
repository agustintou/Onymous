﻿namespace OnymousMobile.Models
{
    public class User : EntityBase
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool Locked { get; set; }
    }
}
