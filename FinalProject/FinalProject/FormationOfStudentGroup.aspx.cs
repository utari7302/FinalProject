using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FinalProject
{
    public partial class GroupID : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6CV5ARA\SQLEXPRESS;Initial Catalog=FinalProject;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                studentList();
                advisorList();
                projectList();
                GridView1.AutoGenerateColumns = false;
            }
        }
        void studentList()
        {
            con.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adp = new SqlDataAdapter("select * from stdTable", con);

            adp.Fill(ds);

            CheckBoxList1.DataSource = ds;

            CheckBoxList1.DataTextField = "RegistrationNumber";

            CheckBoxList1.DataValueField = "Name";

            CheckBoxList1.DataBind();

            con.Close();
        }
        void advisorList()
        {
            con.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adp = new SqlDataAdapter("select * from advTable", con);

            adp.Fill(ds);

            CheckBoxList2.DataSource = ds;

            CheckBoxList2.DataTextField = "Name";

            CheckBoxList2.DataValueField = "CNIC";

            CheckBoxList2.DataBind();

            con.Close();
        }
        void projectList()
        {
            con.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adp = new SqlDataAdapter("select * from proTable", con);

            adp.Fill(ds);

            CheckBoxList3.DataSource = ds;

            CheckBoxList3.DataTextField = "ProjectTitle";

            CheckBoxList3.DataBind();

            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int c = GridView1.Rows.Count;
            DataTable dt = new DataTable();

            dt.Columns.Add("ProjectTitle", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            DataRow d = dt.NewRow();
            d = dt.NewRow();
  

            foreach (ListItem l in CheckBoxList1.Items)
            {
                if (l.Selected == true)
                {
                    DataRow dn = dt.NewRow();
                    dn = dt.NewRow();
                    dn["ProjectTitle"] = CheckBoxList3.Text;
                    dn["Name"] = l.Value;
                    dn["ID"] = l.Text;
                    dn["Category"] = "student";
                    dt.Rows.Add(dn);
                }

            }
            foreach (ListItem l in CheckBoxList2.Items)
            {
                if (l.Selected == true)
                {
                    DataRow dm = dt.NewRow();
                    dm["Name"] = l.Text;
                    dm["ID"] = l.Value;
                    dm["Category"] = "advisor";
                    dt.Rows.Add(dm);
                }
                
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into grpTable values ('" + CheckBoxList3.Text + "','" + CheckBoxList1.SelectedItem.Text + "','" + CheckBoxList2.SelectedItem.Text + "')";
            cmd.ExecuteNonQuery();

        }
    }
}