<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="imageWriter.Email.list" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="display: inline-block; width: 40%; height: 800px; overflow-y: scroll;">
            <asp:Panel ID="Panel1" runat="server"></asp:Panel>
        </div>
        <div style="display: inline-block; width: 50%;">
            <div style="padding: 30px;">
                <table width='100%'>
                    <tbody>
                        <tr>
                            <td rowspan="5" width="312">
                                <img id="img" src="http://cards.aictec.com/png/zk.png" alt="ZKTeco Saudi Arabia" />
                            </td>
                            <td colspan="2" width="312">
                                <p><strong id="name">Akram Alhabshi</strong></p>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" width="312">
                               <p id="pos">Marketing Manager</p>
                            </td>
                        </tr>
                        <tr>
                            <td width="174">
                              <p> <img src="http://cards.aictec.com/png/m.png"  /> <a id="mobile" href="tel:094440444">094440444</a></p>
                            </td>
                            <td width="138">
                             <p>  <img src="http://cards.aictec.com/png/t.png" />  <strong >920021721</strong></p>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" width="312">
                              <p>  <img src="http://cards.aictec.com/png/@.png" />   <a id="email" href="mailto:akram@aictec.com">akram@aictec.com</a></p>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" width="312">
                                <p><img src="http://cards.aictec.com/png/pin.png" />   Riyadh, King Fahad Road , in Front of Al Faisaliah</p>
                            </td>
                        </tr>
                        <tr>
                            <td width="312">
                                <p><a href=""><img src="http://cards.aictec.com/png/f.png" alt="Facebook" /></a>
                                    <a href=""><img src="http://cards.aictec.com/png/t.png" alt="Twitter"  /></a>
                                    <a href=""><img src="http://cards.aictec.com/png/i.png" alt="Instagram" /></a>
                                    <a href=""><img src="http://cards.aictec.com/png/l.png" alt="Linked-in"  /></a>
                                    <a href=""><img src="http://cards.aictec.com/png/y.png" alt="YouTube"  /></a>
                     
                                    </p>
                            </td>
                            <td colspan="2" width="312">
                                <p><a href="http://www.aictec.com"><img src="http://cards.aictec.com/png/s.png" /> <strong>www.aictec.com</strong></a></p>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" width="100%">
                                <p><img src="http://cards.aictec.com/png/ac.png" /> </p>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" width="100%">
                                <p>The content of this email is confidential and intended for the recipient specified in message only. It is strictly forbidden to share any part of this message with any third party, without a written consent of the sender. If you received this message by mistake, please reply to this message and follow with its deletion, so that we can ensure such a mistake does not occur in the future.</p>
                            </td>
                        </tr>
                    </tbody>
                </table>




            </div>
            <a id="ddd" href="images/1.png" download>
                <img id="dd" src="images/1.png" style="max-width: 100%" />
            </a>
        </div>
    </form>
    <script>


        function makeit(name, pos, email, mobile, addrss, cmp) {
            var s = "EmailProcess.aspx?1";
            s += "&name=" + name;
            s += "&pos=" + pos;
            s += "&email=" + email;
            s += "&mobile=" + mobile;
            s += "&address=" + addrss;
            s += "&cmp=" + cmp;




            document.getElementById("dd").src = s;
            document.getElementById("ddd").href = s;

            document.getElementById("email").href = "mailto:" + email;
            document.getElementById("email").innerText = email;
            document.getElementById("mobile").href = "tel:" + mobile;
            document.getElementById("mobile").innerText =  mobile;
            document.getElementById("name").innerText = name;
            document.getElementById("pos").innerText = pos;
            document.getElementById("img").src = "http://cards.aictec.com/png/zk.aspx?e=" + email;
        }
    </script>
    <style>
        td span:hover {
            cursor: pointer;
            color: red;
        }
    </style>
</body>
</html>
