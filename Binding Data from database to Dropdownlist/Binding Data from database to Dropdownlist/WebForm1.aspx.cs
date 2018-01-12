using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;


namespace Binding_Data_from_database_to_Dropdownlist
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!IsPostBack)
            {
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("Select CityId, CityName, Country from tblCity", con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    ddlCity.DataTextField = "CityName";
                    ddlCity.DataValueField = "CityId";
                    ddlCity.DataSource = rdr;
                    ddlCity.DataBind();
                }
            }
        }
    }
}