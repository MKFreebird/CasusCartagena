using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Chat.BU;

namespace Chat.CC
{
    public class CCCreateChatRoom
    {
        public BU.Chat CCCreateRoom(int chatid, string globalchat)
        {
            BU.Chat MyBU = new BU.Chat();
            BU.Chat currentChat = MyBU.CreateChat(chatid, globalchat);
            return currentChat;
        }
    }
}