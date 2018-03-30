<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StudentPatrolTest.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <iframe name="myIframe" id="myIframe" style="height:1200px;width:1000px" runat ="server"></iframe>
    <form id="form1" runat="server">
       <div>
            <asp:Label ID="lblUser" runat="server" Text="User"></asp:Label>
            <asp:TextBox ID="txtUser" runat="server" style="margin-left: 44px" Width="162px"></asp:TextBox>
           <br />
             <asp:Label ID="lblPass" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPass" runat="server" style="margin-left: 17px" Width="160px"></asp:TextBox>
           <br />
           <asp:Button ID="btnSubmit" runat="server" Text="Submit" Height="26px" OnClick="btnSubmit_Click" Width="142px" />
        </div>
    </form>
</body>
</html>
