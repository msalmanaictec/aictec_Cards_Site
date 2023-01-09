using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

using System.Drawing.Imaging;
using System.Drawing.Text;

namespace imageWriter.Email
{
    public partial class EmailProcess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PrivateFontCollection collection = new PrivateFontCollection();

            collection.AddFontFile(Server.MapPath("/images//Almarai.ttf"));
            collection.AddFontFile(Server.MapPath("/images//Almarai-Bold.ttf"));




            string strName = "Dalya Almutlaq";//Your Text On Image
            string strPosition = "Graphic Designer";//Your Text On Image.
            string strEmail = "Dalya@zkteco-sa.com";//Your Text On Image.
            string strMobile = "+96655012859";//Your Text On Image.

            string strAddress = "24.690417152479007%2c+46.68214167314472";
            string strCompany = "AICTec (ZKTeco SA)";

            Point pName = new Point(1400, 320);
            Point pPosition = new Point(1400, 450);
            //Point pPosition = new Point(1660, 500);

            Point pEmail = new Point(1800, 725);
            Point pMobile = new Point(1800, 850);


            Color colorName = System.Drawing.ColorTranslator.FromHtml("#2fa03b");//direct color adding
            Color colorBase = System.Drawing.ColorTranslator.FromHtml("#ffffff");//direct color adding



            float fontsize = 20;
            Font fontAlamri = new Font(collection.Families.First(), fontsize);
            Font fontAlamriBold = new Font(collection.Families[1], fontsize);



            float fontsizeSmall = 17;
            Font fontAlamriSmall = new Font(collection.Families.First(), fontsizeSmall);
            Font fontAlamriBoldSmall = new Font(collection.Families[1], fontsizeSmall);

            Color StringColor2 = System.Drawing.ColorTranslator.FromHtml("#ffffff");//customise color adding
            System.Drawing.Image bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//images//email.png")); // set image 


  

            if (!IsPostBack)
            {
                if (Request.QueryString["name"] != null)
                {
                    strName = Request.QueryString["name"];


                }

                if (Request.QueryString["pos"] != null)
                {
                    strPosition = Request.QueryString["pos"];


                }

                if (Request.QueryString["email"] != null)
                {
                    strEmail = Request.QueryString["email"];


                }

                if (Request.QueryString["mobile"] != null)
                {
                    strMobile = Request.QueryString["mobile"];


                }

                if (Request.QueryString["address"] != null)
                {
                    strAddress = Request.QueryString["address"];


                }

              


                if (Request.QueryString["cmp"] != null)
                {
                    int cmp = Convert.ToInt32(Request.QueryString["cmp"]);
                    switch (cmp)
                    {
                        case 11:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//images//emails//aictec-riyadh.png"));
                            strCompany = "AICTec (ZKTeco SA)";
                            StringColor2 = System.Drawing.ColorTranslator.FromHtml("#ffffff");//customise color adding

                            break;
                        case 12:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//images//emails//aictec-jeddeh.png"));
                            strCompany = "AICTec (ZKTeco SA)";
                            break;

                        case 13:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//images//emails//aictec-khobar.png"));
                            strCompany = "AICTec (ZKTeco SA)";
                            break;

                        case 21:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//images//emails//zkteco-riyadh.png"));
                            strCompany = "AICTec (ZKTeco SA)";
                            break;

                        case 22:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//images//emails//zkteco-jeddeh.png"));
                            strCompany = "AICTec (ZKTeco SA)";
                            break;
                        case 23:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//images//emails//zkteco-khobar.png"));
                            strCompany = "AICTec (ZKTeco SA)";
                            break;



                    }


                }


            }
            //creating a image object


            Graphics graphicsImage = Graphics.FromImage(bitmap);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Near;
            //Set the font color/format/size etc..  


            //graphicsImage.DrawString(Str_TextOnImage, new Font("arial", 40, FontStyle.Regular), new SolidBrush(StringColor), new Point(268, 245), stringformat);
            graphicsImage.DrawString(strName.Trim(), fontAlamriBold,
    new SolidBrush(colorName),
    pName, format);


            if(strPosition.Length<30)


            graphicsImage.DrawString(strPosition.Trim(), fontAlamri,
                new SolidBrush(StringColor2),
                pPosition, format);
            else
       graphicsImage.DrawString(strPosition.Trim(), fontAlamriSmall,
                new SolidBrush(StringColor2),
                pPosition, format);


            graphicsImage.DrawString(strEmail.Trim(), fontAlamri,
                new SolidBrush(colorName),
                pEmail, format);




            graphicsImage.DrawString(strMobile.Trim(), fontAlamri,
                new SolidBrush(colorName),
                pMobile, format);


            


            string barcodedata = "https://qrcode.tec-it.com/API/QRCode?" +
                "data=BEGIN%3aVCARD%0d%0aVERSION%3a2.1%0d%0aN%3a" +
                strName +
                "%0d%0aTEL%3bHOME%3b" +
                "VOICE%3a" +
                strMobile +
                "%0d%0a" +
                "TEL%3bWORK%3b" +
                "VOICE%3a" +
                    "+966920021721" +
                "%0d%0a" +
                "EMAIL%3a" +
                strEmail +
                "%0d%0a" +
                "ORG%3a" +
              strCompany +
                "%0d%0a" +
                "TITLE%3a" +
                strPosition +
                "%0d%0a" +
                "ADR%3a" +
        strAddress+
                "%0d%0a" +
                "URL%3ahttps%3a%2f%2f" +
                "www.aictec.com" +
                "%0d%0aEND%3aVCARD" +
                "&backcolor=%233a3a3a" +
                "&color=%23ffffff";

            try
            {
                System.Net.WebRequest request = System.Net.WebRequest.Create(barcodedata);
                System.Net.WebResponse response = request.GetResponse();
                System.IO.Stream responseStream = response.GetResponseStream();
                Bitmap bitmapQR = new Bitmap(responseStream);



                graphicsImage.DrawImage(bitmapQR, 4000, 300, 600, 600);
            }
            catch (Exception)
            {

            
            }

           




            Response.ContentType = "image/png";
            bitmap.Save(Response.OutputStream, ImageFormat.Jpeg);
        }
    }
}