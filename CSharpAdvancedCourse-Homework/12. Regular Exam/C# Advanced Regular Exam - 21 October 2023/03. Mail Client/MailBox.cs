using System.Runtime.CompilerServices;
using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public MailBox(int capacity)
        {
            this.Capacity = capacity;
            this.Inbox = new List<Mail>();
            this.Archive = new List<Mail>();
        }

        public int Capacity { get; set; }

        public List<Mail> Inbox { get; set; }

        public List<Mail> Archive { get; set; }

        public void IncomingMail(Mail mail)
        {
            if (this.Inbox.Count < this.Capacity)
            {
                this.Inbox.Add(mail);
            }
        }

        public bool DeleteMail(string sender)
        {
            bool isItRemoved = false;

            foreach (var mail in this.Inbox)
            {
                if (mail.Sender == sender)
                {
                    isItRemoved = true;
                    this.Inbox.Remove(mail);
                    break;
                }
            }

            return isItRemoved;
        }

        public int ArchiveInboxMessages()
        {
            int countOfMessages = this.Inbox.Count;

            this.Archive.AddRange(this.Inbox);
            this.Inbox.Clear();

            return countOfMessages;
        }

        public string GetLongestMessage()
        {
            var longestMessage = this.Inbox.MaxBy(m => m.Body);

            return longestMessage.ToString();
        }

        public string InboxView()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Inbox:");

            foreach (var mail in this.Inbox)
            {
                sb.AppendLine(mail.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}