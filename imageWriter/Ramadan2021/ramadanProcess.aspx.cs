using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

using System.Drawing.Imaging;
using System.Drawing.Text;
namespace imageWriter.Ramadan2021
{
    public partial class ramadanProcess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PrivateFontCollection collection = new PrivateFontCollection();

            collection.AddFontFile(Server.MapPath("/fonts/Cairo-Bold.ttf"));





            string strName = "Dalya Almutlaq";//Your Text On Image

            Point pName = new Point(885, 715);


            //محمد عبدالستار سل
            Color colorName = System.Drawing.ColorTranslator.FromHtml("#ffffff");//direct color adding
            Color colorBase = System.Drawing.ColorTranslator.FromHtml("#ffffff");//direct color adding



            float fontsize = 60;
            Font fontCairoBold = new Font(collection.Families.First(), fontsize);
         

            Color stringColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");//customise color adding
            System.Drawing.Image bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//ramadan2022//aictec.png")); // set image 




            if (!IsPostBack)
            {
                if (Request.QueryString["name"] != null)
                {
                    strName = Request.QueryString["name"];
                    int x = strName.Length;

                }

              




                if (Request.QueryString["cmp"] != null)
                {
                    int cmp = Convert.ToInt32(Request.QueryString["cmp"]);
                    switch (cmp)
                    {


                        case 1:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//ramadan2021//aictec-ramadan2021.png"));
                            //  strCompany = "AICTec (ZKTeco SA)";
                            stringColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");//customise color adding
                            pName = new Point(885, 715);
                            break;
                        case 2:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//ramadan2021//leen-ramadan2021.png"));

                            pName = new Point(2443, 4217);
                            break;

                        case 3:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//images//emails//aictec-khobar.png"));
                            //   strCompany = "AICTec (ZKTeco SA)";
                            break;




                    }


                }


            }
            //creating a image object


            Graphics graphicsImage = Graphics.FromImage(bitmap);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            //Set the font color/format/size etc..  


            //graphicsImage.DrawString(Str_TextOnImage, new Font("arial", 40, FontStyle.Regular), new SolidBrush(StringColor), new Point(268, 245), stringformat);
            graphicsImage.DrawString(strName.Trim(), fontCairoBold,
    new SolidBrush(colorName),
    pName, format);


         




      






            Response.ContentType = "image/png";
            bitmap.Save(Response.OutputStream, ImageFormat.Jpeg);
        }
    }
}