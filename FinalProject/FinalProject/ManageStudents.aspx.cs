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
    public partial class Personal_Info : System.Web.UI.Page
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
            cmd.CommandText = "insert into stdTable values ('" + txtName.Text + "','" + txtRegistrationNumber.Text + "','" + txtDegreeProgram.Text + "','" + txtContactNumber.Text + "','" + txtDescription.Text + "','" + txtEmail.Text + "')";
            cmd.ExecuteNonQuery();
            txtName.Text = "";
            txtRegistrationNumber.Text = "";
            txtDegreeProgram.Text = "";
            txtContactNumber.Text = "";
            txtDescription.Text = "";
            txtEmail.Text = "";
            display();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  stdTable SET Name = '" + txtName.Text + "',DegreeProgram = '" + txtDegreeProgram.Text + "',ContactNumber='" + txtContactNumber.Text + "',Description='" + txtDescription.Text + "',Email='" + txtEmail.Text + "' where  RegistrationNumber= '" + txtRegistrationNumber.Text + "'";
            cmd.ExecuteNonQuery();
            txtName.Text = "";
            txtRegistrationNumber.Text = "";
            txtDegreeProgram.Text = "";
            txtContactNumber.Text = "";
            txtDescription.Text = "";
            txtEmail.Text = "";
            display();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from stdTable where RegistrationNumber = '" + txtRegistrationNumber.Text + "'";
            cmd.ExecuteNonQuery();
            txtName.Text = "";
            txtRegistrationNumber.Text = "";
            txtDegreeProgram.Text = "";
            txtContactNumber.Text = "";
            txtDescription.Text = "";
            txtEmail.Text = "";
            display();
        }
        void display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from stdTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtRegistrationNumber.Text = "";
            txtDegreeProgram.Text = "";
            txtContactNumber.Text = "";
            txtDescription.Text = "";
            txtEmail.Text = "";
            display();
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home.aspx");
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ManageAdvisor.aspx");
        }
    }
}