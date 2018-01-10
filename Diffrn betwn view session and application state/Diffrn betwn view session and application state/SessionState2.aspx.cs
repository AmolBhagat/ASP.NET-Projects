﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Diffrn_betwn_view_session_and_application_state
{
    public partial class SessionState2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Clicks"] == null)
                {
                    Session["Clicks"] = 0;
                }
                TextBox1.Text = Session["Clicks"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ClicksCount = (int)Session["Clicks"] + 1;
            TextBox1.Text = ClicksCount.ToString();
            Session["Clicks"] = ClicksCount;
        }
    }
}