using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace imageWriter.logo
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Drawing.Image bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("/eid/logo.png")); // set image 



            int cmp = -1;

            //if (!IsPostBack)
            //{


            //    if (Request.QueryString["type"] != null)
            //    {
            //        cmp = Convert.ToInt32(Request.QueryString["type"]);
            //        switch (cmp)
            //        {
            //            case 1:
            //                bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("/eid/eid-zk.png")); // set image 

            //                break;
            //            case 2:
            //                bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("/eid/eid-leen.png")); // set image 

            //                stringColor = System.Drawing.ColorTranslator.FromHtml("#429382");//customise color adding
            //                fontsize = 80;
            //                pName = new Point(3777, 6900);
            //                break;

            //            case 3:
            //                bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("/eid/eid-zk.png")); // set image 

            //                //   strCompany = "AICTec (ZKTeco SA)";
            //                break;



            //        }


            //    }


            //}

            Graphics graphicsImage = Graphics.FromImage(bitmap);

            int xdgjfrt = DB.Execute("Declare @cnt int;  Set @cnt =( Select isnull( cnt,0) from cnt where num=1);  update cnt set cnt=@cnt+1 where num=1;");


            Response.ContentType = "image/png";
            bitmap.Save(Response.OutputStream, ImageFormat.Jpeg);
        }
    }
}