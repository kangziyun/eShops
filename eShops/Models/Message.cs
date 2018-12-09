

namespace eShops.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public int Sent{ get; set; }
        public int Recipient { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
