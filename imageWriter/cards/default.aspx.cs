using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace imageWriter.cards
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable t = DB.ReadTable("Select * from list order by en_name");

            string s = "<table border='1'>";

            foreach (DataRow r in t.Rows)

            {
                string posEn = r["card_Business"].ToString();
                string posAr = r["card_Business"].ToString();

                s += "<tr><td>" + r["num"].ToString() + "</td><td>" + r["en_name"].ToString() + "</td>" +
                    "<td><span onclick='makeit(\"" + r["en_name"] + "\",\"" + r["en_name"] + "\",\"" + posEn + "\",\"" + posAr + "\",\"" + r["email"] + "\",\"0" + r["mobile"] + "\",\"24.690417152479007%2c+46.68214167314472\",\"11\",)'>AC</a></td>" +
                    "<td><span onclick='makeit(\"" + r["en_name"] + "\",\"" + r["en_name"] + "\",\"" + posEn + "\",\"" + posAr + "\",\"" + r["email"] + "\",\"0" + r["mobile"] + "\",\"24.690417152479007%2c+46.68214167314472\",\"21\",)'>ZK</a></td>" +
                //    "<td><span onclick='makeit(\"" + r["en_name"] + "\",\"" + posEn + "\",\"" + r["email"] + "\",\"0" + r["mobile"] + "\",\"24.690417152479007%2c+46.68214167314472\",\"21\",)'>ZK</a></td>" +
                 //  "<td><span onclick='makeit(\"" + r["en_name"] + "\",\"" + pos + "\",\"" + r["email"] + "\",\"0" + r["mobile"] + "\",\"24.690417152479007%2c+46.68214167314472\",\"12\",)'>AC Jeddeh</a></td>" +
                 //"<td><span onclick='makeit(\"" + r["en_name"] + "\",\"" + pos + "\",\"" + r["email"] + "\",\"0" + r["mobile"] + "\",\"24.690417152479007%2c+46.68214167314472\",\"22\",)'>ZK Jeddeh</a></td>" +
                 //   "<td><span onclick='makeit(\"" + r["en_name"] + "\",\"" + pos + "\",\"" + r["email"] + "\",\"0" + r["mobile"] + "\",\"24.690417152479007%2c+46.68214167314472\",\"13\",)'>AC Khobar</a></td>" +
                 //   "<td><span onclick='makeit(\"" + r["en_name"] + "\",\"" + pos + "\",\"" + r["email"] + "\",\"0" + r["mobile"] + "\",\"24.690417152479007%2c+46.68214167314472\",\"23\",)'>ZK Khobar</a></td>" +
                    "</tr>";





            }
            s += "</table>";
            Panel1.Controls.Clear();
            Panel1.Controls.Add(new LiteralControl(s));

        }
    }
}