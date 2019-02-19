<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stajbasvurusu.aspx.cs" Inherits="ogrenci.stajbasvurusu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label1" runat="server" Text="İŞ YERİ ADI:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 36px" Width="281px"></asp:TextBox>
        </div>
        <p>
             <asp:Label ID="Label2" runat="server" Text="İŞ YERİ İL:"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" style="margin-left: 35px">
                <asp:ListItem Selected="True">Adana</asp:ListItem>
                <asp:ListItem>Adıyaman</asp:ListItem>
                <asp:ListItem>Afyonkarahisar</asp:ListItem>
                <asp:ListItem>Ağrı</asp:ListItem>
                <asp:ListItem>Amasya</asp:ListItem>
                <asp:ListItem>Ankara</asp:ListItem>
                <asp:ListItem>Antalya</asp:ListItem>
                <asp:ListItem>Artvin</asp:ListItem>
                <asp:ListItem>Aydın</asp:ListItem>
                <asp:ListItem>Balıkesir</asp:ListItem>
                <asp:ListItem>Bilecik</asp:ListItem>
                <asp:ListItem>Bingöl</asp:ListItem>
                <asp:ListItem>Bitlis</asp:ListItem>
                <asp:ListItem>Bolu</asp:ListItem>
                <asp:ListItem>Burdur</asp:ListItem>
                <asp:ListItem>Bursa</asp:ListItem>
                <asp:ListItem>Çanakkale</asp:ListItem>
                <asp:ListItem>Çankırı</asp:ListItem>
                <asp:ListItem>Çorum</asp:ListItem>
                <asp:ListItem>Denizli</asp:ListItem>
                <asp:ListItem>Diyarbakır</asp:ListItem>
                <asp:ListItem>Edirne</asp:ListItem>
                <asp:ListItem>Elazığ</asp:ListItem>
                <asp:ListItem>Erzincan</asp:ListItem>
                <asp:ListItem>Erzurum</asp:ListItem>
                <asp:ListItem>Eskişehir</asp:ListItem>
                <asp:ListItem>Gaziantep</asp:ListItem>
                <asp:ListItem>Giresun</asp:ListItem>
                <asp:ListItem>Gümüşhane</asp:ListItem>
                <asp:ListItem>Hakkari</asp:ListItem>
                <asp:ListItem>Hatay</asp:ListItem>
                <asp:ListItem>Isparta</asp:ListItem>
                <asp:ListItem>Mersin</asp:ListItem>
                <asp:ListItem>İstanbul</asp:ListItem>
                <asp:ListItem>İzmir</asp:ListItem>
                <asp:ListItem>Kars</asp:ListItem>
                <asp:ListItem>Kastamonu</asp:ListItem>
                <asp:ListItem>Kayseri</asp:ListItem>
                <asp:ListItem>Kırklareli</asp:ListItem>
                <asp:ListItem>Kırşehir</asp:ListItem>
                <asp:ListItem>Kocaeli</asp:ListItem>
                <asp:ListItem>Konya</asp:ListItem>
                <asp:ListItem>Kütahya</asp:ListItem>
                <asp:ListItem>Malatya</asp:ListItem>
                <asp:ListItem>Manisa</asp:ListItem>
                <asp:ListItem>Kahramanmaraş</asp:ListItem>
                <asp:ListItem>Mardin</asp:ListItem>
                <asp:ListItem>Muğla</asp:ListItem>
                <asp:ListItem>Muş</asp:ListItem>
                <asp:ListItem>Nevşehir</asp:ListItem>
                <asp:ListItem>Niğde</asp:ListItem>
                <asp:ListItem>Ordu</asp:ListItem>
                <asp:ListItem>Rize</asp:ListItem>
                <asp:ListItem>Sakarya</asp:ListItem>
                <asp:ListItem>Samsun</asp:ListItem>
                <asp:ListItem>Siirt</asp:ListItem>
                <asp:ListItem>Sinop</asp:ListItem>
                <asp:ListItem>Sivas</asp:ListItem>
                <asp:ListItem>Tekirdağ</asp:ListItem>
                <asp:ListItem>Tokat</asp:ListItem>
                <asp:ListItem>Trabzon</asp:ListItem>
                <asp:ListItem>Tunceli</asp:ListItem>
                <asp:ListItem>Şanlıurfa</asp:ListItem>
                <asp:ListItem>Uşak</asp:ListItem>
                <asp:ListItem>Van</asp:ListItem>
                <asp:ListItem>Yozgat</asp:ListItem>
                <asp:ListItem>Zonguldak</asp:ListItem>
                <asp:ListItem>Aksaray</asp:ListItem>
                <asp:ListItem>Bayburt</asp:ListItem>
                <asp:ListItem>Karaman</asp:ListItem>
                <asp:ListItem>Kırkkale</asp:ListItem>
                <asp:ListItem>Batman</asp:ListItem>
                <asp:ListItem>Şırnak</asp:ListItem>
                <asp:ListItem>Bartın</asp:ListItem>
                <asp:ListItem>Ardahan</asp:ListItem>
                <asp:ListItem>Iğdır</asp:ListItem>
                <asp:ListItem>Yalova</asp:ListItem>
                <asp:ListItem>Karabük</asp:ListItem>
                <asp:ListItem>Kilis</asp:ListItem>
                <asp:ListItem>Osmaniye</asp:ListItem>
                <asp:ListItem>Düzce</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
             <asp:Label ID="Label3" runat="server" Text="FAALİYET ALANI:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 29px" Width="281px"></asp:TextBox>
        </p>
        <p>
             <asp:Label ID="Label4" runat="server" Text="E-POSTA:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 24px" Width="320px"></asp:TextBox>
        </p>
        <p>
             <asp:Label ID="Label12" runat="server" Text="TELEFON:"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 28px" Width="281px"></asp:TextBox>
        </p>
        <p>
             <asp:Label ID="Label6" runat="server" Text="PROGRAM"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" style="margin-left: 39px">
                <asp:ListItem>Anadal</asp:ListItem>
                <asp:ListItem>İkinci Anadal</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
             <asp:Label ID="Label7" runat="server" Text="STAJ DÖNEMİ:"></asp:Label>
            <asp:DropDownList ID="DropDownList3" runat="server" style="margin-left: 39px">
                <asp:ListItem>1. Staj</asp:ListItem>
                <asp:ListItem>2.Staj</asp:ListItem>
                <asp:ListItem>3.Staj</asp:ListItem>
                <asp:ListItem>4.Staj</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
             <asp:Label ID="Label8" runat="server" Text="STAJ GÜN SAYISI:"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 32px" Width="281px"></asp:TextBox>
        </p>
        <p>
             <asp:Label ID="Label9" runat="server" Text="HAFTALIK ÇALIŞMA GÜN SAYISI:"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server" style="margin-left: 32px" Width="281px"></asp:TextBox>
        </p>
        <p>
             <asp:Label ID="Label10" runat="server" Text="STAJ BAŞLAMA TARİHİ:"></asp:Label>
             <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        </p>
        <p>
             <asp:Label ID="Label11" runat="server" Text="STAJ BİTİŞ TARİHİ:"></asp:Label>
             <asp:TextBox ID="TextBox9" runat="server" Width="295px" style="margin-left: 27px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="GERİ DÖN" OnClick="Button1_Click" Width="156px" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="BAŞVUR" style="margin-left: 57px" Width="166px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
