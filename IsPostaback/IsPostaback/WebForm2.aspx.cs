using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IsPostaback
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCityDropDownList();
            }
        }

        public void LoadCityDropDownList()
        {
            ListItem List1 = new ListItem("London");
            ddlCity.Items.Add(List1);

            ListItem List2 = new ListItem("Sydney");
            ddlCity.Items.Add(List2);

            ListItem List3 = new ListItem("Mumbai");
            ddlCity.Items.Add(List3);

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
          
        }
    }
}