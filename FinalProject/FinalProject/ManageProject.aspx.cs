using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class ManageProject : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6CV5ARA\SQLEXPRESS;Initial Catalog=FinalProject;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            display();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into proTable values ('" + txtProjectTitle.Text + "','" + txtProjectID.Text + "','" + txtProjectType.Text + "','" + txtProjectDescription.Text + "','" + txtProjectApplication.Text + "')";
            cmd.ExecuteNonQuery();
            txtProjectID.Text = "";
            txtProjectTitle.Text = "";
            txtProjectType.Text = "";
            txtProjectDescription.Text = "";
            txtProjectApplication.Text = "";
            display();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  proTable SET ProjectTitle = '" + txtProjectTitle.Text + "',ProjectType = '" + txtProjectType.Text + "',ProjectDescription='" + txtProjectDescription.Text + "',ProjectApplication='" + txtProjectApplication.Text + "' where  ProjectID= '" + txtProjectID.Text + "'";
            cmd.ExecuteNonQuery();
            txtProjectID.Text = "";
            txtProjectTitle.Text = "";
            txtProjectType.Text = "";
            txtProjectDescription.Text = "";
            txtProjectApplication.Text = "";
            display();
        }
        void display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from proTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from proTable where ProjectID = '" + txtProjectID.Text + "'";
            cmd.ExecuteNonQuery();
            txtProjectID.Text = "";
            txtProjectTitle.Text = "";
            txtProjectType.Text = "";
            txtProjectDescription.Text = "";
            txtProjectApplication.Text = "";
            display();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtProjectID.Text = "";
            txtProjectTitle.Text = "";
            txtProjectType.Text = "";
            txtProjectDescription.Text = "";
            txtProjectApplication.Text = "";
            display();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ManageAdvisor.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FormationOfStudentGroup.aspx");
        }
    }
}