using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahChat.Messages
{
    public class Message
    {
        public string msgTime;
        public int authorID;
        public string msgText;

        public Message(string time, int author, string msg)
        {
            this.msgTime = time;
            this.authorID = author;
            this.msgText = msg;
        }
    }
}
