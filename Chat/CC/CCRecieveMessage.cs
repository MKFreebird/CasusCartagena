namespace Chat.CC
{
    using System.Collections.Generic;
    using BU;

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