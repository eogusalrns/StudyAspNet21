﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmResponseWrite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("안녕하세요.<br />");
        }

        protected void BtnMsg_Click(object sender, EventArgs e)
        {
            Response.Write("<p style='color:blue;'>반갑습니다.</p>");
        }

        protected void BtnJs_Click(object sender, EventArgs e)
        {
            string strScript = @"<script language='javascript'>
                                  window.alert('안녕하세요!');
                                 </script>";
            Response.Write(strScript);
        }

        protected void BtnLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.naver.com");
        }

        protected void BtnLink_Click1(object sender, EventArgs e)
        {

        }
    }
}