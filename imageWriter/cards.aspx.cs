using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace imageWriter
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s ="process.aspx?name="+txtname.Text.Trim();
          //  s +="&color="+ hfcolor.Value.Replace("#","");
            s += "&cmp=" + drpCompany.SelectedValue;
            Response.Redirect(s);
        }
    }
}