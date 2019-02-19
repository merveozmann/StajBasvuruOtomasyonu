<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="firmaMail.aspx.cs" Inherits="ogrenci.firmalistele" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        
        <p>
        <asp:Label ID="Label1" runat="server" Text="Alıcı"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Konu"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Mesaj"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="CV"></asp:Label>
&nbsp;<asp:FileUpload ID="FileUpload1" runat="server" />
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="GÖNDER" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" style="margin-left: 33px" Text="GERİ DÖN" />
        
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        
    </form>
</body>
</html>
