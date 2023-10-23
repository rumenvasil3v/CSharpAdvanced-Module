using System.Text;

namespace MailClient
{
    public class Mail
    {
        public Mail(string sender, string receiver, string body)
        {
            this.Sender = sender;
            this.Receiver = receiver;
            this.Body = body;
        }

        public string Sender { get; set; }

        public string Receiver { get; set; }

        public string Body { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"From: {this.Sender} / To: {this.Receiver}");
            stringBuilder.Append($"Message: {this.Body}");

            return stringBuilder.ToString().Trim();
        }
    }
}
