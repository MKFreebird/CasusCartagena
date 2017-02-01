namespace Chat.CC
{
    public class CCDeleteMessage
    {
        public void CCDeleteMessages(int messageid)
        {
            BU.Message MyBU = new BU.Message();
            MyBU.DeleteMessage(messageid);
        }
    }
}