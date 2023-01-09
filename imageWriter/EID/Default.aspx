<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="imageWriter.EID.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta property="og:title"   content="عيد فطر سعيد"/>
<meta property="og:description" content="شركة تقدم العالمية - عيد فطر سعيد  " />
<meta property="og:image" content="http://cards.aictec.com/logo/" />
<meta property="og:url" content="http://cards.aictec.com/eid/default.aspx" />
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous" />

    <title>عيد فطر سعيد</title>
</head>
<body>
    <style>

         @font-face { font-family: Delicious; src: url('/Fonts/Cairo-Bold.ttf'); }

        div {
        
         font-family: Delicious, sans-serif;
        }
    </style>
    <div style="    text-align: center;">
            <img id="Imagelogo" src="\images\header.png" style="max-width: 100%;    -webkit-filter: drop-shadow(5px 5px 5px #222);    filter: drop-shadow(5px 5px 5px #222);">

    </div>
   <div style="max-width: 800px; margin: 0 auto; border: 1px solid black; padding: 20px;    text-align: center;">
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
        <a id="ddd" href="images/1.png" download>
        <img id="dd" src="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAAJCAIAAAB8JNGzAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAAQSURBVBhXY/j//z9+/P8/AORNGuagwuiNAAAAAElFTkSuQmCC" style="max-width:100%"/>
            </a>

        <%--<img src="" />--%>
    </div>


    <asp:Panel ID="plBarCode" runat="server"></asp:Panel>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>
    <script>


        function dod() {

            var e = document.getElementById("drpAdress");
            var ss = e.value;
            var s = "eidProcess.aspx?1";
            s += "&name=" + document.getElementById("txtname").value;
            s += "&cmp="+ss;
      



            document.getElementById("dd").src = s;
            document.getElementById("ddd").href = s;


        }
    </script>

    <div class="card" style="
    text-align: center;
    margin: 10px;
">
  <div class="card-body">
 هذه الخدمة مقدمة من قبل قسم تقنية المعلومات بالتعاون مع قسم التسويق 
<br />
      كل عام وانتم بخير
  </div>
</div>
</body>
</html>
