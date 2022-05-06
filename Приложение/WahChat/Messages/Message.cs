using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahChat.Messages
{
    public class ChatMessage
    {
        public string msgTime;
        public int authorID;
        public string msgText;

        public ChatMessage(string time, int author, string msg)
        {
            this.msgTime = time;
            this.authorID = author;
            this.msgText = msg;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}) {2}", this.msgTime, this.authorID, this.msgText);
        }
    }
}
