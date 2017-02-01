using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat.BU
{
    public partial class Message
    {
        public bool SendMessage(int messageid, int userid, int chatid, string messagecontent, Chat chat)
        {
            using (ChatModelContainer context = new ChatModelContainer())
            {
                IQueryable<Message> messageq = context.MessageSet;
                var record = new Message();
                record.Id = messageid;
                record.Content = messagecontent;
                record.TimeStamp = DateTime.Now;
                record.IsReceived = false;
                record.Chat = chat;
                IQueryable<User> userq = context.UserSet;
                var account_test = (from act in context.UserSet
                                    where act.Id == 2  // Currently the id has been hardcoded, needs to change when account component is finished
                                    select act).First();
                record.User = account_test;
                context.MessageSet.Add(record);
                context.SaveChanges();
                return true;
            }
        }

        public Message[] RecieveMessage(int chatid)
        {
            using (ChatModelContainer context = new ChatModelContainer())
            {
                IQueryable<Message> messages = context.MessageSet;

                Message[] messageArray = (
                   from m in messages
                   where m.Chat.Id == chatid
                   select m).ToArray();
                return messageArray;
            }
        }

        public bool DeleteMessage(int messageid)
        {
            using (ChatModelContainer context = new ChatModelContainer())
            {
                var messagecheck = context.MessageSet.Where(b => b.Id == messageid).Count();
                if (messagecheck > 0)
                {
                    // bericht verwijderen
                    var verwijder = context.MessageSet.RemoveRange(context.MessageSet.Where(x => x.Id == messageid));
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    // Kan niet verwijderd worden?
                    return false;
                }
            }
        }
    }
}