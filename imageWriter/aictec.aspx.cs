using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

using System.Drawing.Imaging;
using System.Drawing.Text;

namespace imageWriter
{
    public partial class process : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PrivateFontCollection collection = new PrivateFontCollection();
            // Add the custom font families. 
            // (Alternatively use AddMemoryFont if you have the font in memory, retrieved from a database).
            collection.AddFontFile(Server.MapPath("images//Almarai.ttf"));

            Font fontAlamri = new Font(collection.Families.First(), 48);


            string Str_TextOnImage = "Happy";//Your Text On Image
            string Str_TextOnImage2 = "Onam";//Your Text On Image.
            Point p = new Point(2174, 1226);
            Color StringColor = System.Drawing.ColorTranslator.FromHtml("#933eea");//direct color adding

            string font = "Almarai";
            float fontsize = 110;

            Color StringColor2 = System.Drawing.ColorTranslator.FromHtml("#e80c88");//customise color adding
            System.Drawing.Image bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("images//1.png")); // set image 
            if (!IsPostBack)
            {
                if (Request.QueryString["name"] != null)
                {
                    Str_TextOnImage = Request.QueryString["name"];

                    Str_TextOnImage2 = Request.QueryString["name"];
                }
                if (Request.QueryString["font"] != null)
                {
                    font = Request.QueryString["font"];

                    font = Request.QueryString["font"];
                }

         

                if (Request.QueryString["cmp"] != null)
                {
                    switch (Convert.ToInt32(Request.QueryString["cmp"]))
                    {
                        case 1:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("images//1.png"));
                            StringColor2 = System.Drawing.ColorTranslator.FromHtml("#ffffff");//customise color adding
                            p = new Point(2600,2200);
                             fontAlamri = new Font(collection.Families.First(), 45);
                            
                            break;
                        case 2:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("images//2.png"));
                            p = new Point(1490, 1400);
                            //
                            StringColor2 = System.Drawing.ColorTranslator.FromHtml("#16826a");//customise color adding
                             fontAlamri = new Font(collection.Families.First(), 48);
                 
                            break;
                        case 3:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("images//3.png"));
                            p = new Point(610, 600);
                            fontAlamri = new Font(collection.Families.First(), 52);
                            StringColor2 = System.Drawing.ColorTranslator.FromHtml("#0064af");//customise color adding
                            break;


                    }


                }
                if (Request.QueryString["color"] != null)

                {

                    if (Request.QueryString["color"].Trim().Equals(""))
                    {

                       

                        StringColor2 = System.Drawing.ColorTranslator.FromHtml("#ffffff");//customise color adding
                    }
                    else
                    {
                        string s = "#" + Request.QueryString["color"].ToString();

                       

                        StringColor2 = System.Drawing.ColorTranslator.FromHtml("#" + Request.QueryString["color"]);//customise color adding
                    }
                }

            }
            //creating a image object


            Graphics graphicsImage = Graphics.FromImage(bitmap);
            StringFormat stringformat = new StringFormat();
            stringformat.Alignment = StringAlignment.Center;
            stringformat.LineAlignment = StringAlignment.Center;
            StringFormat stringformat2 = new StringFormat();
            stringformat2.Alignment = StringAlignment.Center;
            stringformat2.LineAlignment = StringAlignment.Center;
            //Set the font color/format/size etc..  
      
       
            //graphicsImage.DrawString(Str_TextOnImage, new Font("arial", 40, FontStyle.Regular), new SolidBrush(StringColor), new Point(268, 245), stringformat);
        
            graphicsImage.DrawString(Str_TextOnImage2, fontAlamri, 
                new SolidBrush(StringColor2), 
                p, stringformat2); 

            Response.ContentType = "image/png";
            bitmap.Save(Response.OutputStream, ImageFormat.Jpeg);
        }
    }
}