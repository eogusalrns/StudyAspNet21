﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnClick_Click(object sender, EventArgs e)
        {
            LblResult.Text = $"안녕하세요, {TxtDisplay.Text}!";
            Response.Write("반갑습니당.<br/>");
        }
    }
}