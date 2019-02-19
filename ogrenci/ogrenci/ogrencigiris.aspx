<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ogrencigiris.aspx.cs" Inherits="ogrenci.ogrencigiris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label1" runat="server" Text="E-MAİL:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 32px" Width="281px"></asp:TextBox>
             <br />
             <br />
             <br />
        <asp:Label ID="Label2" runat="server" Text="ŞİFRE:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Width="279px" style="margin-left: 46px" TextMode="Password"></asp:TextBox>
             <br />
             <br />
             <br />
             <br />
        <asp:Button ID="Button1" runat="server" ForeColor="#990099" Height="26px" OnClick="Button1_Click" style="margin-left: 106px" Text="OTURUM AÇ" Width="124px" />
    

             <br />
    

        </div>
    </form>
</body>
</html>
