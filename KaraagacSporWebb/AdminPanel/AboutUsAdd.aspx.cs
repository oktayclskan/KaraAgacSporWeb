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
    public partial class AboutUsAdd : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_aboutUsAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_title.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(tb_content.Text.Trim()))
                {
                    About a = new About();
                    a.Title = tb_title.Text;
                    a.Content = tb_content.Text;

                    if (dm.AboutUsAdd(a))
                    {
                        tb_title.Text = " ";
                        tb_content.Text = " ";
                        pnl_succes.Visible = true;
                        pnl_error.Visible = false;
                    }
                    else
                    {
                        pnl_error.Visible = true;
                        lbl_eror.Text = "Eklenirken Bir Hata Oluştu";
                    }

                }
                else
                {
                    pnl_error.Visible = true;
                    lbl_eror.Text = "Lütfen İçerik ekleyiniz";
                }
            }
            else
            {
                pnl_error.Visible = true;
                lbl_eror.Text = "Lütfen Başlık ekleyiniz";
            }

        }
    }
}