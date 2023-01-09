<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="card.aspx.cs" Inherits="imageWriter.cards.card" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    

        <asp:Image ID="imgBarcode" runat="server" ImageUrl="https://qrcode.tec-it.com/API/QRCode?data=BEGIN%3aVCARD%0d%0aVERSION%3a2.1%0d%0aN%3aSalman%0d%0aTEL%3bHOME%3bVOICE%3a591610187%0d%0aTEL%3bWORK%3bVOICE%3a591610187%0d%0aEMAIL%3am.salman%40aictec.ocm%0d%0aORG%3aAICTec%0d%0aTITLE%3aIT+Manager%0d%0aADR%3aRiyadh%0d%0aURL%3ahttps%3a%2f%2fwww.aictec.com%0d%0aEND%3aVCARD&backcolor=%23ffffff"/>

    </form>
</body>
</html>
