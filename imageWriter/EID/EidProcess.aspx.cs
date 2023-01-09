using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;


namespace imageWriter.EID
{
    public partial class EidProcess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PrivateFontCollection collection = new PrivateFontCollection();

            collection.AddFontFile(Server.MapPath("/fonts/Cairo-Bold.ttf"));





            string strName = "Dalya Almutlaq";//Your Text On Image

            Point pName = new Point(2550, 4433);


            //محمد عبدالستار سل




            float fontsize = 60;
  


            Color stringColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");//customise color adding
            System.Drawing.Image bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("/eid/eid-zk.png")); // set image 



            int cmp = -1;

            if (!IsPostBack)
            {
                if (Request.QueryString["name"] != null)
                {
                    strName = Request.QueryString["name"];
                    int x = strName.Length;

                }



           
                if (Request.QueryString["cmp"] != null)
                {
      cmp=       Convert.ToInt32(Request.QueryString["cmp"]);
                    switch (cmp)
                    {
                        case 1:
                   bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("/eid/eid-zk.png")); // set image 
                            //  strCompany = "AICTec (ZKTeco SA)";
                            stringColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");//customise color adding
                            pName = new Point(2550, 4433);
                            break;
                        case 2:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("/eid/eid-leen.png")); // set image 

                            stringColor = System.Drawing.ColorTranslator.FromHtml("#429382");//customise color adding
                            fontsize = 80;
                            pName = new Point(3777, 6900);
                            break;

                        case 3:
                            bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("/eid/eid-zk.png")); // set image 

                            //   strCompany = "AICTec (ZKTeco SA)";
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
            graphicsImage.DrawString(strName.Trim(), fontCairoBold,    new SolidBrush(stringColor),    pName, format);
            //downloads
       int xdgjfrt=     DB.Execute("Insert into downloads   ([name] ,[dt] ,[type],[cmp]) VALUES ('" + strName + "', getdate(), 'eid-fitr-2021'," + cmp.ToString() + ")");
         











            Response.ContentType = "image/png";
            bitmap.Save(Response.OutputStream, ImageFormat.Jpeg);
        }
    }
}