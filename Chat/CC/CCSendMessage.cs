namespace Chat.CC
{
    using BU;

    public class CCSendMessage
    {
        public void CCSendMessages(int messageid, int userid, int chatid, string messagecontent)
        {
            Message BU = new Message();
            BU.SendMessage(messageid, userid, chatid, messagecontent);
        }
    }
}