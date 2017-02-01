using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat.CC
{
    public class CCRemoveChatRoom
    {
        public void CCRemoveChat(int chatid)
        {
            BU.Chat MyBU = new BU.Chat();
            MyBU.RemoveChat(chatid);
        }
    }
}