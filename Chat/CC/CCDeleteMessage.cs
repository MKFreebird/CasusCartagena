using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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