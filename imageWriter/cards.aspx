<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cards.aspx.cs" Inherits="imageWriter._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta property="og:title" content="شركة تقدم العالمية - تهنئة رأس السنة" />
<meta property="og:description" content="تصميم تهاني رأس السنة" />
<meta property="og:image" content="http://cards.aictec.com/aictec,aspx" />
<meta property="og:url" content="http://cards.aictec.com/cards,aspx" />
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous" />

    <title>Happy New Year!</title>
</head>
<body>
    <div style="max-width: 800px; margin: 0 auto; border: 1px solid black; padding: 20px">
        <form id="form1" runat="server">
            <div class="form-group">
                <label for="txtname">Your Name</label>
                <asp:TextBox ID="txtname" runat="server" CssClass="form-control"  ClientIDMode="static"  TextMode="SingleLine" MaxLength="25" required aria-describedby="namehelp"></asp:TextBox>
            </div>
    
                        <div class="form-group">
            <label class="my-1 mr-2" for="drpCompany">Company</label>
            <asp:DropDownList ID="drpCompany" runat="server"  class="custom-select my-1 mr-sm-2">
                <asp:ListItem Value="0" Selected>Choose...</asp:ListItem>
<asp:ListItem Value="1" >تقدم العالمية AICTec</asp:ListItem>
<asp:ListItem Value="2" >لين الخير Leen ALkhair</asp:ListItem>
<asp:ListItem Value="3">المنصة الزراعية</asp:ListItem>

            </asp:DropDownList>
  

</div>
                        <div class="form-group">
            <input type="button" onclick="dod()" value="Submit - ارسال" class="btn btn-primary my-1"/>

                            </div>

        </form>
        <a id="ddd" href="images/1.png" download>
        <img id="dd" src="images/1.png" style="max-width:100%"/>
            </a>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>
    <script>


        function dod() {
            var s = "aictec.aspx?";
            s += "name=" + document.getElementById("txtname").value;
            s += "&cmp=" + document.getElementById("drpCompany").value;



            document.getElementById("dd").src = s;
            document.getElementById("ddd").href = s;


        }
    </script>
</body>
</html>
