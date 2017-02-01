using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Chat.CC;

namespace Chat.BU
{
    public partial class Chat
    {
        public Chat CreateChat(int chatroomid, string chatroomname)
        {
            using (ChatModelContainer context = new ChatModelContainer())
            {
                IQueryable<Chat> chatq = context.ChatSet;
                var record = new Chat();
                record.Id = chatroomid;
                record.ChatRoomName = chatroomname;
                context.ChatSet.Add(record);
                context.SaveChanges();
                return record;
            }
        }


        public bool RemoveChat(int chatid)
        {
            // Verwijder alle berichten
            ChatModelContainer context = new ChatModelContainer();
            context.MessageSet.RemoveRange(context.MessageSet.Where(x => x.Chat.Id == chatid));
            var VerwijderChat = context.ChatSet.FirstOrDefault(f => f.Id == chatid);

            if (VerwijderChat != null)
            {
                context.ChatSet.Attach(VerwijderChat);
                context.ChatSet.Remove(VerwijderChat);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}