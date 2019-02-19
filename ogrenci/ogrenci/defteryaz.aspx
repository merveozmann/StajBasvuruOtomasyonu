<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="defteryaz.aspx.cs" Inherits="ogrenci.defteryaz" %>

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
            <asp:FileUpload ID="FileUpload1" runat="server" Height="47px" Width="296px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="DEFTER YÜKLE" Width="215px" OnClick="Button1_Click1" Height="49px" />
            </p>
        <p>
            &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" Visible="False">
        </asp:GridView>
    </form>
</body>
</html>
