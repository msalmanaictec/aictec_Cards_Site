using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

using System.Drawing.Imaging;
using System.Drawing.Text;

namespace imageWriter.cards
{
    public partial class card : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PrivateFontCollection collection = new PrivateFontCollection();

            collection.AddFontFile(Server.MapPath("/images//Almarai.ttf"));
            collection.AddFontFile(Server.MapPath("/images//Almarai-Bold.ttf"));




            string strNameEn = "Salman";//Your Text On Image
           string strNameAr = "";//Your Text On Image
            string strPositionEn = "IT Designer";//Your Text On Image.
            string strPositionAr = "IT Designer";//Your Text On Image.
            string strEmail = "IT>salman@zkteco-sa.com";//Your Text On Image.
            string strMobile = "+966555599";//Your Text On Image.

            string strAddress = "24.690417152479007%2c+46.68214167314472";
            string strCompany = "AICTec (ZKTeco SA)";

            string str9200 = "+966 9200 217 21";
            string strStreet1 = "Kingdom of Saudi Arabia";
                        string strStreet2= "Riyadh,King Fahad Road";


            Point pNameEn = new Point(85, 200);
            Point pNameAr = new Point(700, 200);
            Point pPositionEn = new Point(88, 250);
            Point pMobile = new Point(117, 327);
            Point pEmail = new Point(119, 418);
            Point pStreet1 = new Point(633, 370);
            Point pStreet2 = new Point(633, 418);
            Point p9200 = new Point(117, 370);
            

            Color colorName = System.Drawing.ColorTranslator.FromHtml("#3b3b3b");//direct color adding
            Color colorPos = System.Drawing.ColorTranslator.FromHtml("#2fa03b");//direct color adding



            float fontsize = 12;
            float fontsizePos = 8;
            float fontsizeInfo = 8;
            Font font = new Font(collection.Families[1], fontsize);
            Font fontPos = new Font(collection.Families.First(), fontsizePos);
            Font fontInfo = new Font(collection.Families.First(), fontsizeInfo);


            System.Drawing.Image bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//cards//images//card-ac.png")); // set image 




            if (!IsPostBack)
            {
                if (Request.QueryString["nameen"] != null)
                {
                    strNameEn = Request.QueryString["nameen"];


                }
                if (Request.QueryString["namear"] != null)
                {
                    strNameEn = Request.QueryString["namear"];


                }

                if (Request.QueryString["posen"] != null)
                {
                    strPositionEn = Request.QueryString["posen"];


                }
                if (Request.QueryString["posar"] != null)
                {
                    strPositionAr = Request.QueryString["posar"];


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

                    string cmps=Request.QueryString["cmp"];
                    int cmp = Convert.ToInt32(cmps);
                    switch (cmp)
                    {
                        case 11:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//cards//images//card-ac.png"));


                            break;
                        case 21:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//cards//images//card-zk.png"));

                            break;
                        case 12:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//images//emails//aictec-jeddeh.png"));

                            break;

                        case 13:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//images//emails//aictec-khobar.png"));

                            break;



                        case 22:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//images//emails//zkteco-jeddeh.png"));

                            break;
                        case 23:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//images//emails//zkteco-khobar.png"));

                            break;



                    }


                }


            }
            //creating a image object

            if (strMobile.StartsWith("05"))
                strMobile = "+966 5" + strMobile.Substring(2, strMobile.Length-3);

            Graphics graphicsImage = Graphics.FromImage(bitmap);


            StringFormat formatEn = new StringFormat();
            formatEn.Alignment = StringAlignment.Near;
            formatEn.LineAlignment = StringAlignment.Center;

            StringFormat formatAr = new StringFormat();
            formatAr.Alignment = StringAlignment.Far;
            formatAr.LineAlignment = StringAlignment.Center;

            //graphicsImage.DrawString(Str_TextOnImage, new Font("arial", 40, FontStyle.Regular), new SolidBrush(StringColor), new Point(268, 245), stringformat);
            graphicsImage.DrawString(Toolss.FirstCharToUpper( strNameEn.Trim().ToLower()), font, new SolidBrush(colorName), pNameEn, formatEn);
            graphicsImage.DrawString(strNameAr.Trim(), font, new SolidBrush(colorName), pNameAr, formatEn);

            graphicsImage.DrawString(strPositionEn.Trim(), fontPos, new SolidBrush(colorPos), pPositionEn, formatEn);
        //    graphicsImage.DrawString(strPositionAr.Trim(), fontAlamri, new SolidBrush(colorPos), pPositionEn, format);


            graphicsImage.DrawString(strEmail.ToLower().Trim(), fontInfo, new SolidBrush(colorName), pEmail, formatEn);




            graphicsImage.DrawString(strMobile.Trim(), fontInfo, new SolidBrush(colorName), pMobile, formatEn);
            graphicsImage.DrawString(str9200.Trim(), fontInfo, new SolidBrush(colorName), p9200, formatEn);
            graphicsImage.DrawString(strStreet1.Trim(), fontInfo, new SolidBrush(colorName), pStreet1, formatEn);
            graphicsImage.DrawString(strStreet2.Trim(), fontInfo, new SolidBrush(colorName), pStreet2, formatEn);
 



            string barcodedata = "https://qrcode.tec-it.com/API/QRCode?" +
                "data=BEGIN%3aVCARD%0d%0aVERSION%3a2.1%0d%0aN%3a" +
                strNameEn +
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
                strPositionEn +
                "%0d%0a" +
                "ADR%3a" +
        strAddress +
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