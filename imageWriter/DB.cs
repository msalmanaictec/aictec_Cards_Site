using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace imageWriter
{
    public class DB
    {
     public static string ConnectionString = "Server=.\\sqlexpress;Database=cards;User Id=sa;Password=Advance@ZKTeco1;";
  //public static string ConnectionString = "Server=.;Database=cards;User Id=sa;Password=Usr123456;";

        public static DataTable ReadTable(string Table, String Extra)
        {
            try
            {
                DataTable datatbl = new DataTable();
                SqlDataAdapter adb = new SqlDataAdapter("select * from " + Table + " " + Extra, ConnectionString);
                adb.Fill(datatbl);
                return datatbl;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static DataTable ReadTable(string Query)
        {
            try
            {
                DataTable datatbl = new DataTable();
                SqlDataAdapter adb = new SqlDataAdapter(Query, ConnectionString);
                adb.Fill(datatbl);
                return datatbl;
            }
            catch (Exception ex)
            {

                return null;
            }


        }
        public static bool Delete(string Table, int id)
        {
            SqlConnection sqlcon = new SqlConnection(ConnectionString);

            SqlCommand sqlcmd = new SqlCommand("delete from  " + Table + " where id=" + id.ToString(), sqlcon);
            int cnt = -1;
            try
            {
                sqlcon.Open();
                cnt = sqlcmd.ExecuteNonQuery();
                sqlcon.Close();


            }
            catch (Exception ex)
            {
                cnt = 0;

            }

            if (cnt > 0)
                return true;
            else
                return false;

        }

        public static int Execute(string Qurey)
        {
            SqlConnection sqlcon = new SqlConnection(ConnectionString);

            SqlCommand sqlcmd = new SqlCommand(Qurey, sqlcon);
            int cnt = -1;
            try
            {
                sqlcon.Open();
                cnt = sqlcmd.ExecuteNonQuery();
                sqlcon.Close();


            }
            catch (Exception ex)
            {
                cnt = 0;

            }

            return cnt;

        }
        public static int Login(string usertype, string username, string password)
        {
            try
            {
                DataTable datatbl = new DataTable();
                SqlDataAdapter adb = new SqlDataAdapter("select id,name from " + usertype + " where (username='" + username + "' and password='" + password + "' ) Or (Email='" + username + "' and password='" + password + "' )", ConnectionString);

                adb.Fill(datatbl);
                if (datatbl != null)
                    return Convert.ToInt16(datatbl.Rows[0][0]);

                else
                    return -1;
            }
            catch (Exception ex)
            {

                return -1;
            }

        }



        //Ready Code from Stack Over Flow
        public static bool InsertRow(string Table, int ID, string[] Cols, object[] Vals, string errMessage = "")
        {
            try
            {
                if (Vals == null | Cols == null)
                    return false;
                if (Vals.Length != Cols.Length)
                    return false;

                SqlConnection cn = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("", cn);

                string colStr = "ID";
                string valStr = "@id";
                cmd.Parameters.AddWithValue("@id", ID);

                for (int oCounter = 0; oCounter <= Vals.Length - 1; oCounter++)
                {
                    colStr += ",";
                    valStr += ",";

                    colStr += Cols[oCounter];
                    valStr += "@param" + (oCounter + 1).ToString();

                    cmd.Parameters.AddWithValue("@param" + (oCounter + 1).ToString(), Vals[oCounter]);
                }

                string qStr = "INSERT INTO " + Table + " (" + colStr + ") VALUES (" + valStr + ")";
                cmd.CommandText = qStr;

                cn.Open();
                int cnt = cmd.ExecuteNonQuery();
                cn.Close();

                if (cnt > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                errMessage = ex.Message;
                return false;
            }
        }

        //Ready Code from Stack Over Flow


        public static bool InsertRow(string Table, string[] Cols, object[] Vals, string errMessage = "")
        {
            try
            {
                if (Vals == null | Cols == null)
                    return false;
                if (Vals.Length != Cols.Length)
                    return false;

                SqlConnection cn = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("", cn);

                string colStr = " ";
                string valStr = " ";

                for (int oCounter = 0; oCounter <= Vals.Length - 1; oCounter++)
                {


                    colStr += Cols[oCounter];
                    valStr += "@param" + (oCounter + 1).ToString();

                    colStr += ",";
                    valStr += ",";

                    cmd.Parameters.AddWithValue("@param" + (oCounter + 1).ToString(), Vals[oCounter]);
                }

                colStr = colStr.TrimEnd(',');
                valStr = valStr.TrimEnd(',');

                string qStr = "INSERT INTO " + Table + " (" + colStr + ") VALUES (" + valStr + ")";
                cmd.CommandText = qStr;

                cn.Open();
                int cnt = cmd.ExecuteNonQuery();
                cn.Close();


                if (cnt > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                errMessage = ex.Message;
                return false;
            }
        }


        public static object InsertRowGetID(string Table, string[] Cols, object[] Vals, string errMessage = "")
        {
            try
            {
                if (Vals == null | Cols == null)
                    return false;
                if (Vals.Length != Cols.Length)
                    return false;

                SqlConnection cn = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("", cn);

                string colStr = " ";
                string valStr = " ";

                for (int oCounter = 0; oCounter <= Vals.Length - 1; oCounter++)
                {


                    colStr += Cols[oCounter];
                    valStr += "@param" + (oCounter + 1).ToString();

                    colStr += ",";
                    valStr += ",";

                    cmd.Parameters.AddWithValue("@param" + (oCounter + 1).ToString(), Vals[oCounter]);
                }

                colStr = colStr.TrimEnd(',');
                valStr = valStr.TrimEnd(',');

                string qStr = "INSERT INTO " + Table + " (" + colStr + ") OUTPUT Inserted.ID VALUES (" + valStr + ")";
                cmd.CommandText = qStr;

                cn.Open();
                object cnt = cmd.ExecuteScalar();
                cn.Close();

                return cnt;
            }
            catch (Exception ex)
            {
                errMessage = ex.Message;
                return DBNull.Value;
            }
        }


        //Ready Code from Stack Over Flow
        public static bool UpdateRow(string Table, int ID, string[] Cols, object[] Vals, string errMessage = "")
        {
            try
            {
                if (Vals == null | Cols == null)
                    return false;
                if (Vals.Length != Cols.Length)
                    return false;

                SqlConnection cn = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("", cn);

                string colStr = "";
                for (int oCounter = 0; oCounter <= Vals.Length - 1; oCounter++)
                {
                    colStr += Cols[oCounter] + "=" + "@param" + (oCounter + 1).ToString();

                    cmd.Parameters.AddWithValue("@param" + (oCounter + 1).ToString(), Vals[oCounter]);

                    if (oCounter < Vals.Length - 1)
                        colStr += ",";
                }

                string qStr = "UPDATE " + Table + " SET " + colStr + " WHERE ID=@id";
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.CommandText = qStr;

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                return true;
            }
            catch (Exception ex)
            {
                errMessage = ex.Message;
                return false;
            }
        }



    }
}