namespace OnymousMobile.Models
{
    public class EntityBase
    {
        public long Id { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
