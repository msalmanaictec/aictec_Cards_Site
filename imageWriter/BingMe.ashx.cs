using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Drawing;

using System.Drawing.Imaging;
using System.Drawing.Text;

namespace imageWriter
{
    /// <summary>
    /// Summary description for BingMe
    /// </summary>
    public class BingMe : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

            string json = (new WebClient()).DownloadString("http://www.bing.com/HPImageArchive.aspx?format=js&idx=0&n=1");

            BingJson x = JsonConvert.DeserializeObject<BingJson>(json);


            int ss = 1;

            Image img = x.images[0];
            string url = "http://www.bing.com" + img.url;

            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(url);
            MemoryStream ms = new MemoryStream(bytes);
            System.Drawing.Image bitmap = System.Drawing.Image.FromStream(ms);


            int fromtop = 5;
            int fromleft = 5;

            string cpy = img.copyright;
            try
            {
                cpy = "(©" + cpy.Split('©')[1];

            }
            catch (Exception)
            {

                throw;
            }


            Point pName = new Point(fromleft, fromtop);

            //       Color stringColor = System.Drawing.ColorTranslator.FromHtml("#00000096");
            Color color = Color.FromArgb(220, 0, 0, 0);
            //creating a image object
            Font font = new Font("Arial", 20, FontStyle.Italic, GraphicsUnit.Pixel);

            Graphics graphicsImage = Graphics.FromImage(bitmap);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Near;

            graphicsImage.DrawString(cpy,
                font,
                new SolidBrush(color),
                pName,
                format);


            context.Response.ContentType = "image/png";
            bitmap.Save(context.Response.OutputStream, ImageFormat.Jpeg);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}