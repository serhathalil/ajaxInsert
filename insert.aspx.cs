using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class insert : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=SERHATHALİL;Initial Catalog=ajaxDeneme;Integrated Security=True");
    string name, city;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        name = Request.QueryString["nm"].ToString();
        city = Request.QueryString["ct"].ToString();

        con.Open();
        SqlCommand cmd = new SqlCommand("insert into Table_1 values('" + name.ToString() + "','" + city.ToString() + "')", con);
        //SqlCommand cmd = con.CreateCommand();
        //cmd.CommandType = CommandType.Text;
        //cmd.CommandText = "insert into Table_1 values('" + name.ToString() + "','" + city.ToString() + "')";
        cmd.ExecuteNonQuery();
        con.Close();
    }
}