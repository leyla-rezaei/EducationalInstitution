using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Validations;

namespace EducationalInstitution.Api.Models.Input
{
    public class MessageInput
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public MessageType MessageType { get; set; }
        [ImageFile(1024 * 1024)]
        public byte[]? ImageFile { get; set; }
      
        public User UserSender { get; set; }
        public int UserSenderId { get; set; }
        public User UserReceiver { get; set; }
        public int UserReceiverId { get; set; }
    }
}