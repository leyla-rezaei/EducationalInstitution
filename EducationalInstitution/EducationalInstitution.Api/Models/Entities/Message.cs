using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Models.Common;


namespace EducationalInstitution.Api.Models.Entities
{
    public class Message : BaseEntity
    {
        public DateTimeOffset Timestamp { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public MessageType MessageType { get; set; }
        public byte[]? ImageFile { get; set; }
        public bool IsRead { get; set; }
        public MessageDeliveryStatus MessageDeliveryStatus { get; set; }



        // Foreign key reference to User
        public User User { get; set; }
        public int UserId { get; set; }
    }
}