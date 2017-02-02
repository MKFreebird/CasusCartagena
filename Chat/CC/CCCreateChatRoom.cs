namespace Chat.CC
{
    public class CCCreateChatRoom
    {
        public void CCCreateRoom(int chatid, string globalchat)
        {
            BU.Chat MyBU = new BU.Chat();
            MyBU.CreateChat(chatid, globalchat);
        }
    }
}