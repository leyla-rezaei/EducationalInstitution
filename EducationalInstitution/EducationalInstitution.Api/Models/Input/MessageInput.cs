using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Models.Entities;

namespace EducationalInstitution.Api.Models.Input
{
    public class MessageInput
    {

        public DateTimeOffset Timestamp { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public MessageType MessageType { get; set; }
        public byte[]? ImageFile { get; set; }
      
        //Relations 
        public User UserSender { get; set; }
        public int UserSenderId { get; set; }
        public User UserReceiver { get; set; }
        public int UserReceiverId { get; set; }
    }
}