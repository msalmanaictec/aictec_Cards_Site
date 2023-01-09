<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="imageWriter.ramadan2022._default" %>

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

    <style>
        @import url('https://fonts.googleapis.com/css2?family=Cairo:wght@200;400;700&family=Roboto+Mono:ital,wght@0,600;0,700;1,600&display=swap');
        body {
        font-family: 'Cairo', sans-serif;

        
        
        }
        select, input {
    text-align: center;
    /* color: blue !important; */
}
        #dd {

  border:2px solid #fff;
  background: url(img/tiger.png) no-repeat;
  -moz-box-shadow: 10px 10px 5px #ccc;
  -webkit-box-shadow: 10px 10px 5px #ccc;
  box-shadow: 10px 10px 5px #ccc;
  -moz-border-radius:25px;
  -webkit-border-radius:25px;
  border-radius:25px;
  margin:0 0 20px 0;
}
    </style>

<div style="max-width: 800px; margin: 0 auto; border: 1px solid black; padding: 20px; text-align:center">
        <form id="form1" runat="server">
            <div>
            <div class="form-group">
                <label for="txtname">Name- الاسم</label>
                <asp:TextBox ID="txtname" runat="server" CssClass="form-control"  ClientIDMode="static"  TextMode="SingleLine"  required  MaxLength="30"></asp:TextBox>

            </div>
      
                <div class="form-group">
                <label for="drpAdress">Company - الشركة</label>
    
                    <asp:DropDownList ID="drpAdress" runat="server"  CssClass="form-control" >
                        <asp:ListItem Value="1">تقدم - Aictec</asp:ListItem>
                        <asp:ListItem Value="2">لين الخير - Leen Alkhair</asp:ListItem>
                        <asp:ListItem Value="3">بيري - Berry</asp:ListItem>
                        <asp:ListItem Value="4">مساهم -  Musahm</asp:ListItem>
                        <asp:ListItem Value="5">المنصة - AgriUninos</asp:ListItem>
                        <asp:ListItem Value="6">بصمة السلطان - Basmat alsultan</asp:ListItem>
                        <asp:ListItem Value="7">شركة الغذاء المميز - Al Mumayez Food Co. </asp:ListItem>

                    </asp:DropDownList>

            </div>
  
               <div class="form-group">
                   <input type="button" onclick="dod()" value="تصميم" class="btn btn-primary my-1" />

                   </div>
                 <div class="form-group">
                     يمكنك الضغط على الصورة لتحميلها
                     <br />
                     click on the image to download
                 </div>
            </div>


        </form>
        <a id="ddd" href="/images/dot.png" download>
        <img id="dd" src="/images/dot.png" style="max-width:100%"/>
            </a>

        <%--<img src="" />--%>

    <div class="card" style="
    text-align: center;
">
  <h5 class="card-header">كل عام وانتم بخير !</h5>
  <div class="card-body">
    <h5 class="card-title">رمضان مبارك</h5>
    <p class="card-text">تم تصميم الموقع بالتعاون بين قسم تقنية المعلومات و قسم التسويق</p>

  </div>
</div>
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
