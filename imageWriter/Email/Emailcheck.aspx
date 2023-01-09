<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Emailcheck.aspx.cs" Inherits="imageWriter.Email.check" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta property="og:title" content="شركة تقدم العالمية - تصميم توقيع الشركة" />
<meta property="og:description" content="تصميم توقيع الشركة" />
<meta property="og:image" content="http://aictec.com/images/email.png" />
<meta property="og:url" content="http://aictec.com/email/emailcheck,aspx" />
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous" />

    <title>Email Signture!</title>
</head>
<body>
    <div style="max-width: 800px; margin: 0 auto; border: 1px solid black; padding: 20px">
        <form id="form1" runat="server">
            <div class="form-group">
                <label for="txtname">Name</label>
                <asp:TextBox ID="txtname" runat="server" CssClass="form-control"  ClientIDMode="static"  TextMode="SingleLine"  required ></asp:TextBox>

            </div>
                <div class="form-group">
                <label for="txtPos">Job Position</label>
                <asp:TextBox ID="txtPos" runat="server" CssClass="form-control"  ClientIDMode="static"  TextMode="SingleLine"  required ></asp:TextBox>


            </div>
                <div class="form-group">
                <label for="txtemail">Email</label>
                <asp:TextBox ID="txtemail" runat="server" CssClass="form-control"  ClientIDMode="static"  TextMode="SingleLine" required ></asp:TextBox>

            </div>
                <div class="form-group">
                <label for="txtMobile">Mobile</label>
                <asp:TextBox ID="txtMobile" runat="server" CssClass="form-control"  ClientIDMode="static"  TextMode="SingleLine" required ></asp:TextBox>

            </div>
                <div class="form-group">
                <label for="drpAdress">Company</label>
    
                    <asp:DropDownList ID="drpAdress" runat="server"  CssClass="form-control" >
                        <asp:ListItem Value="1" Selected="True">تقدم</asp:ListItem>
                        <asp:ListItem Value="2">الخليج</asp:ListItem>
                        <asp:ListItem Value="3">الصناعية</asp:ListItem>

                    </asp:DropDownList>

            </div>
  
               <div class="form-group">
                   <input type="button" onclick="dod()" value="Submit - ارسال" class="btn btn-primary my-1" />

                   </div>

            


        </form>
        <a id="ddd" href="images/1.png" download>
        <img id="dd" src="images/1.png" style="max-width:100%"/>
            </a>

        <%--<img src="" />--%>
    </div>


    <asp:Panel ID="plBarCode" runat="server"></asp:Panel>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>
    <script>


        function dod() {
            var s = "ramadanProcess.aspx?1";
            s += "&name=" + document.getElementById("txtname").value;
            s += "&cmp=1";
      



            document.getElementById("dd").src = s;
            document.getElementById("ddd").href = s;


        }
    </script>
</body>
</html>
