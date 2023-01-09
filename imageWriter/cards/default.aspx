<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="imageWriter.cards._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="display:inline-block;width:40%;    height: 800px;
    overflow-y: scroll;">
            <asp:Panel ID="Panel1" runat="server"></asp:Panel>
        </div>
        <div  style="display:inline-block;width:50%;">
                 <a id="ddd" href="#" download>
        <img id="dd" src="images/card-zk.png" style="max-width:100%"/>
            </a>
        </div>
    </form>
        <script>


            function makeit(nameEN,nameAR, posEN, posAR,email,mobile,addrss,cmp) {
            var s = "card.aspx?1";
            s += "&nameen=" + nameEN;
            s += "&namear=" + nameEN;
            s += "&posen=" + posEN;
            s += "&posar=" + posAR;
            s += "&email=" + email;
            s += "&mobile=" + mobile;
            s += "&address=" + addrss;
            s += "&cmp=" + cmp;
      



            document.getElementById("dd").src = s;
            document.getElementById("ddd").href = s;


        }
        </script>
    <style>
        td span:hover {
        cursor:pointer;
        color:red;
        
        }
    </style>
</body>
</html>
