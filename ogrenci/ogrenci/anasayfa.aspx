<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="anasayfa.aspx.cs" Inherits="ogrenci.anasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <a href ="firmaMail.aspx">FİRMAYA BAŞVURU</a><asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" style="margin-left: 674px" Text="ÇIKIŞ" Width="131px" />
             <br />
             <br />
        <a href ="defteryaz.aspx" > DEFTER GÖRÜNTÜLE</a><br /><br />
            <a href ="stajbasvurusu.aspx" > STAJ BAŞVURUSU</a><br /><br /><br />
        </div>
    </form>
</body>
</html>
