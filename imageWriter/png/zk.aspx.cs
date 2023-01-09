using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace imageWriter.png
{
    public partial class zk : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Drawing.Image bitmap = (System.Drawing.Image)Bitmap.FromFile(Server.MapPath("/png/zk.png")); // set image 



            string ee = "Not Found";
            if (!IsPostBack)
            {
                if (Request.QueryString["e"] != null)
                {
                    ee = Request.QueryString["e"].ToString();
                }





                    }


            Graphics graphicsImage = Graphics.FromImage(bitmap);

            int xdgjfrt = DB.Execute("  insert into email_viewes (email) values('"+ ee +"')");


            Response.ContentType = "image/png";
            bitmap.Save(Response.OutputStream, ImageFormat.Png);
        }
    }
}