using System;

namespace Domain.MetaData
{
    public interface IUserData
    {
        int TotalMessages { get; set; }

        int MessagesAnswered { get; set; }

        int MessagesAnonymous { get; set; }

        DateTime CreationDate { get; set; }

        int SentMessages { get; set; }
    }
}
