using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

using System.Drawing.Imaging;
using System.Drawing.Text;

namespace imageWriter.ramadan2022
{
    public partial class ramadanProcess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PrivateFontCollection collection = new PrivateFontCollection();

            collection.AddFontFile(Server.MapPath("/fonts/Cairo-Bold.ttf"));





            string strName = "Dalya Almutlaq";//Your Text On Image

            Point pName = new Point(621, 1677);


            //محمد عبدالستار سل
            Color colorName = System.Drawing.ColorTranslator.FromHtml("#ffffff");//direct color adding
            Color colorBase = System.Drawing.ColorTranslator.FromHtml("#ffffff");//direct color adding



            float fontsize = 45;



            Color stringColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");//customise color adding
            System.Drawing.Image bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//ramadan2021//aictec-ramadan2021.png")); // set image 




            if (!IsPostBack)
            {
                if (Request.QueryString["name"] != null)
                {
                    strName = Request.QueryString["name"];
                    int x = strName.Length;

                }
                else
                {
                    Response.Redirect("~/ramadan2022/default.aspx");

                }






                if (Request.QueryString["cmp"] != null)
                {
                    int cmp = Convert.ToInt32(Request.QueryString["cmp"]);
                    switch (cmp)
                    {



                        case 1:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//ramadan2022//aictec.png"));

                            stringColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");//customise color adding
                            fontsize = 50;
                            break;
                        case 2:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//ramadan2022//leen.png"));
                            stringColor = System.Drawing.ColorTranslator.FromHtml("#00816f");//customise color adding
                            pName = new Point(621, 1700);
                            break;
                        case 3:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//ramadan2022//berry.png"));
                            stringColor = System.Drawing.ColorTranslator.FromHtml("#273262");//customise color adding
                            fontsize = 55;
                            break;
                        case 4:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//ramadan2022//musahm.png"));
                            fontsize = 20;
                            break;
                        case 5:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//ramadan2022//minasa.png"));
                            stringColor = System.Drawing.ColorTranslator.FromHtml("#015d9b");//customise color adding
                            pName = new Point(621, 1550);
                            fontsize = 55;
                            break;
                        case 6:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//ramadan2022//sultan.png"));
                            stringColor = System.Drawing.ColorTranslator.FromHtml("#fd6c35");//customise color adding
                            pName = new Point(621, 1500);
                            fontsize = 55;
                            break;
                        case 7:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("//ramadan2022//fmc.png"));
                            fontsize = 55;
                            stringColor = System.Drawing.ColorTranslator.FromHtml("#61696b");//customise color adding        break;
                            break;

                    }


                }


            }
            //creating a image object
            Font fontCairoBold = new Font(collection.Families.First(), fontsize);

            Graphics graphicsImage = Graphics.FromImage(bitmap);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            //Set the font color/format/size etc..  


            //graphicsImage.DrawString(Str_TextOnImage, new Font("arial", 40, FontStyle.Regular), new SolidBrush(StringColor), new Point(268, 245), stringformat);
            graphicsImage.DrawString(strName.Trim(), fontCairoBold,
    new SolidBrush(stringColor),
    pName, format);














            Response.ContentType = "image/png";
            bitmap.Save(Response.OutputStream, ImageFormat.Jpeg);
        }
    }
}