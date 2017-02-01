using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Chat.BU;

namespace Chat.CC
{
    public class CCSendMessage
    {
        public void CCSendMessages(int messageid, int userid, int chatid, string messagecontent, BU.Chat chat)
        {
            Message BU = new Message();
            BU.SendMessage(1, 1, 1, messagecontent, chat);
        }
    }
}