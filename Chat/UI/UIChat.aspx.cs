using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Chat.CC;
using Chat.BU;
using System.Diagnostics;

namespace Chat.UI
{
    public partial class UIChat : System.Web.UI.Page
    {
       
        BU.Chat CurrentChat;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            CurrentChat = (BU.Chat)Session["currentchat"];
        }

        protected void btnRM_Click(object sender, EventArgs e)
        {
            CCRecieveMessage cchat = new CCRecieveMessage();
            List<string> afdrukken = new List<string>();
            afdrukken = cchat.GetMessages(1); // is nu nog hardcoded
            foreach (string i in afdrukken)
            {
                txtmsg.Text += i + Environment.NewLine;
            }
        }

        protected void btnCCR_Click(object sender, EventArgs e)
        {
            CCCreateChatRoom cchat = new CCCreateChatRoom();
            Session["currentchat"] = cchat.CCCreateRoom(1, "GlobalChat");
            Debug.WriteLine(CurrentChat);
        }

        protected void btnDC_Click(object sender, EventArgs e)
        {
            CCRemoveChatRoom cchat = new CCRemoveChatRoom();
            cchat.CCRemoveChat(2); // dit is nu nog hardcoded
        }

        protected void btnDM_Click(object sender, EventArgs e)
        {
            CCDeleteMessage cchat = new CCDeleteMessage();
            cchat.CCDeleteMessages(3); // dit is nu nog hardcoded
        }

        protected void btnsend_Click(object sender, EventArgs e)
        {
            string message = txtsend.Text;
            DateTime TimeStamp = DateTime.Now;
            CCSendMessage cchat = new CCSendMessage();
            cchat.CCSendMessages(1, 1, 1, message, CurrentChat);
            txtsend.Text = "";
        }
    }
}