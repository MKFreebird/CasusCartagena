<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UIChat.aspx.cs" Inherits="Chat.UI.UIChat" %>

<!DOCTYPE html>
<link href="../content/Styles.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <form id="chatApplication" runat="server">
            <div id="usernameContainer">
                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                    <asp:Button ID="btnRM" runat="server" OnClick="btnRM_Click" Text="ReiceveMessage" Font-Bold="True" />
                    <asp:Label ID="lbluname" runat="server" Font-Bold="True" ForeColor="White"></asp:Label>
                    <asp:Button ID="btnCCR" runat="server" OnClick="btnCCR_Click" Text="CCR" Font-Bold="True" />
                    <asp:Button ID="btnDelete" runat="server" OnClick="btnDC_Click" Text="DeleteChat" />
                    <asp:Button ID="btnDM" runat="server" OnClick="btnDM_Click" Text="DeleteMessage" />
            </div>
   
            <div id="chatboxContainer">
                <asp:TextBox ID="txtmsg" runat="server" ReadOnly="True" BorderStyle="None" CssClass="chatBox" TextMode="MultiLine" Enabled="False" Font-Names="Arial"></asp:TextBox>
            </div>
       
            <div id="userinputContainer">
                <asp:TextBox ID="txtsend" DefaultButton="btnsend" runat="server" CssClass="sendBox" BackColor="White" BorderStyle="None" TextMode="MultiLine" Font-Names="Arial"></asp:TextBox>
                <asp:Button ID="btnsend" runat="server" OnClick="btnsend_Click" Text="Send" Font-Bold="True" CssClass="sendButton" BackColor="#006600" BorderStyle="None" />
            </div>
        </form>
</body>
</html>
