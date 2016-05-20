<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="DNPNew.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px"></asp:TextBox>
        <br />
        <br />
         <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>

        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
         <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Register" />

        </form>
</body>
</html>
