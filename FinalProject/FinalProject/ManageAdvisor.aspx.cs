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
    public partial class ManageAdvisor : System.Web.UI.Page
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
            cmd.CommandText = "insert into advTable values ('" + txtName.Text + "','" + txtEmail.Text + "','" + txtRank.Text + "','" + txtContactNumber.Text + "','" + txtCNIC.Text + "')";
            cmd.ExecuteNonQuery();
            txtName.Text = "";
            txtRank.Text = "";
            txtContactNumber.Text = "";
            txtCNIC.Text = "";
            txtEmail.Text = "";
            display();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  advTable SET Name = '" + txtName.Text + "',Rank = '" + txtRank.Text + "',ContactNumber='" + txtContactNumber.Text + "',Email='" + txtEmail.Text + "' where  CNIC= '" + txtCNIC.Text + "'";
            cmd.ExecuteNonQuery();
            txtName.Text = "";
            txtRank.Text = "";
            txtContactNumber.Text = "";
            txtCNIC.Text = "";
            txtEmail.Text = "";
            display();
        }
        void display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from advTable";
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
            cmd.CommandText = "delete from advTable where CNIC = '" + txtCNIC.Text + "'";
            cmd.ExecuteNonQuery();
            txtName.Text = "";
            txtContactNumber.Text = "";
            txtCNIC.Text = "";
            txtEmail.Text = "";
            display();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtRank.Text = "";
            txtContactNumber.Text = "";
            txtCNIC.Text = "";
            txtEmail.Text = "";
            display();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Personal_Info.aspx");
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ManageProject.aspx");
        }
    }
}