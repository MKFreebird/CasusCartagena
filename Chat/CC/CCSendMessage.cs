namespace Chat.CC
{
    using BU;

    public class CCSendMessage
    {
        public void CCSendMessages(int messageid, int userid, int chatid, string messagecontent, BU.Chat chatroom)
        {
            Message BU = new Message();
            BU.SendMessage(1, 1, 1, messagecontent, chatroom);
        }
    }
}