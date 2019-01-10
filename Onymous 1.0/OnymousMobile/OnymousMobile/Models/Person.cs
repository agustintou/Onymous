namespace OnymousMobile.Models
{
    public class Person : EntityBase
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public byte[] Image { get; set; }

        public int MessageAnswered { get; set; }

        public int MessagesAnonymous { get; set; }

        public int TotalMessages { get; set; }

    }
}
