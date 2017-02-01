using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Chat.BU;

namespace Chat.CC
{
    public class CCRecieveMessage
    {
        private Message recievemessages = new Message();

        public List<string> GetMessages(int chatid)
        {
            List<string> messages = new List<string>();
            int i = 0;
            Message[] input;
            input = recievemessages.RecieveMessage(chatid);
            while (i <= (input.Length - 1))
            {
                messages.Add(input[i].Content);
                i++;
            }
            return messages;

        }
    }
}