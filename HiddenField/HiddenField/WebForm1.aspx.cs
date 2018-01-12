using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace HiddenField
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadEmployee();
            }
           
        }

        private void LoadEmployee()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                string SqlQuery = "select ID, Name,Gender,Department from tblEmployees where ID=2";
                SqlCommand cmd = new SqlCommand(SqlQuery, con);
                con.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        txtName.Text = dr["Name"].ToString();
                        txtGender.Text = dr["Gender"].ToString();
                        txtDepartment.Text = dr["Department"].ToString();
                        HiddenField1.Value = dr["ID"].ToString();

                    }
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                string SqlQuery = "Update tblEmployees set Name=@Name,Gender=@Gender,Department=@Department where ID=@ID";
                using (SqlCommand cmd = new SqlCommand(SqlQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                    cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                    cmd.Parameters.AddWithValue("@ID", HiddenField1.Value);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    txtName.Text = "";
                    txtGender.Text = "";
                    txtDepartment.Text = "";
                }

            }
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            LoadEmployee();
        }
    }
}