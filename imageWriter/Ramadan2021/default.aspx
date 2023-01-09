<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="imageWriter.Ramadan2021._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta property="og:title" content="شركة تقدم العالمية - معايدة رمضان  " />
<meta property="og:description" content="معايدة رمضان" />
<meta property="og:image" content="http://cards.aictec.com/ramadan2021/t.png" />
<meta property="og:url" content="http://cards.aictec.com/ramadan2021/default.aspx" />
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous" />

    <title>Ramadan !</title>
</head>
<body>
   <div style="max-width: 800px; margin: 0 auto; border: 1px solid black; padding: 20px">
        <form id="form1" runat="server">
            <div>
            <div class="form-group">
                <label for="txtname">Name- الاسم</label>
                <asp:TextBox ID="txtname" runat="server" CssClass="form-control"  ClientIDMode="static"  TextMode="SingleLine"  required  MaxLength="18"></asp:TextBox>

            </div>
      
                <div class="form-group">
                <label for="drpAdress">Company - الشركة</label>
    
                    <asp:DropDownList ID="drpAdress" runat="server"  CssClass="form-control" >
                        <asp:ListItem Value="1">تقدم</asp:ListItem>
                        <asp:ListItem Value="2">لين الخير</asp:ListItem>
                        <asp:ListItem Value="3">المنصة</asp:ListItem>

                    </asp:DropDownList>

            </div>
  
               <div class="form-group">
                   <input type="button" onclick="dod()" value="Submit - ارسال" class="btn btn-primary my-1" />

                   </div>
                 <div class="form-group">
                     يمكنك الضغط على الصورة لتحميلها
                 </div>
            </div>


        </form>
        <a id="ddd" href="ln.png" download>
        <img id="dd" src="ln.png" style="max-width:100%"/>
            </a>

        <%--<img src="" />--%>
    </div>


    <asp:Panel ID="plBarCode" runat="server"></asp:Panel>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>
    <script>


        function dod() {

            var e = document.getElementById("drpAdress");
            var ss = e.value;
            var s = "ramadanProcess.aspx?1";
            s += "&name=" + document.getElementById("txtname").value;
            s += "&cmp="+ss;
      



            document.getElementById("dd").src = s;
            document.getElementById("ddd").href = s;


        }
    </script>
</body>
</html>
