using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Models.Entities;

namespace EducationalInstitution.Api.Models.Output
{
    public class MessageOutput
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public MessageType MessageType { get; set; }
        public byte?[] ImageFile { get; set; }
        public bool IsRead { get; set; }
        public MessageDeliveryStatus MessageDeliveryStatus { get; set; }

        public User UserSender { get; set; }
        public int UserSenderId { get; set; }

        public User UserReceiver { get; set; }
        public int UserReceiverId { get; set; }
    }
}