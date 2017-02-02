namespace Chat.BU
{
    using System;
    using System.Linq;

    public partial class Message
    {
        /// <summary>
        /// Write chatmessage to database
        /// </summary>
        /// <param name="messageid"> ID of the message itself</param>
        /// <param name="userid"> ID of the user that sends the message </param>
        /// <param name="chatid"> ID of the chatroom </param>
        /// <param name="messagecontent"> The actual content of the message </param>
        /// <param name="chat"> Object of current chatroom </param>
        /// <returns></returns>
        public bool SendMessage(int messageid, int userid, int chatid, string messagecontent) //, Chat chat)
        {
            using (ChatModelContainer context = new ChatModelContainer())
            {
                IQueryable<Chat> chatroom = context.ChatSet;
                var chatroomDestination = (from room in context.ChatSet
                                           where room.Id == chatid
                                           select room).First();
                IQueryable<Message> messageq = context.MessageSet;
                var record = new Message();
                record.Id = messageid;
                record.Content = messagecontent;
                record.TimeStamp = DateTime.Now;
                record.IsReceived = false;
                record.Chat = chatroomDestination;
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

        /// <summary>
        /// Receive a chatmessage
        /// </summary>
        /// <param name="chatid"> ID of the chatroom </param>
        /// <returns> New messages in database </returns>
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

        /// <summary>
        /// Delete a message from chat
        /// </summary>
        /// <param name="messageid"> ID of message </param>
        /// <returns> Bool to determine success of operation </returns>
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