using DbHandlingWebApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DbHandlingWebApp
{
    public partial class FrmMemoWrite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnWrite_Click(object sender, EventArgs e)
        {
            Memo Memos = new Memo();
            Memos.Name = TxtName.Text;
            Memos.Email = TxtEmail.Text;
            Memos.Title = TxtTitle.Text;
            Memos.PostDate = DateTime.Now;
            Memos.PostIP = Request.UserHostAddress;

            var connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

            using (var conn = new SqlConnection(connString))
            {
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("WriteMemo", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", Memos.Name);
                    cmd.Parameters.AddWithValue("@Email", Memos.Email);
                    cmd.Parameters.AddWithValue("@Title", Memos.Title);
                    cmd.Parameters.AddWithValue("@PostDate", Memos.PostDate);
                    cmd.Parameters.AddWithValue("@PostIP", Memos.PostIP);

                    cmd.ExecuteNonQuery();

                    LblDisplay.Text = "저장되었습니다.";
                }
                catch (Exception ex)
                {
                    LblDisplay.Text = $"예외발생 : {ex}";
                }
            }
        }

        protected void ButList_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMemoList.aspx");
        }
    }
}