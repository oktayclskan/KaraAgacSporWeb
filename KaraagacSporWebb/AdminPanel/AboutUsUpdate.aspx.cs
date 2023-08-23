using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccesLayer;
using System.IO;

namespace KaraagacSporWebb.AdminPanel
{
    public partial class AboutUsUpdate : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count != 0)
            {
                if (!IsPostBack)
                {
                    int id = Convert.ToInt32(Request.QueryString["aid"]);
                    About a = dm.AboutUsGet(id);
                    tb_title.Text = a.Title;
                    tb_content.Text = a.Content;

                }
            }
            else
            {
                Response.Redirect("AboutUsList.aspx");
            }
        }
        protected void btn_aboutUsUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["aid"]);
            About a = dm.AboutUsGet(id);
            a.Title = tb_title.Text;
            a.Content = tb_content.Text;
            if (dm.AbousUsUpdate(a))
            {
                pnl_succes.Visible = true;
                pnl_error.Visible = false;
            }
            else
            {
                pnl_error.Visible = false;
                lbl_eror.Text = "Güncelenirken hata oluştu";
            }
        }
    }
}