using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Reflection;

namespace WebApplication2
{
    public partial class DisplayRecords_Gridview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            String mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "select * from [dbo].[SHG_Master] inner Join[dbo].[SHG_Master_log] on[dbo].[SHG_Master].Shg_ID =[dbo].[SHG_Master_log].Shg_ID where Shg_ID like '%'+Shg_ID+'%'";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            sqlcomm.Parameters.AddWithValue("Shg_ID",Textsearch.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            dt = Con.query;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}