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
                    asp_img.ImageUrl = "Assets/Img/" + a.Img;
                    asp_img2.ImageUrl = "Assets/Img/" + a.Img2;
                    asp_img3.ImageUrl = "Assets/Img/" + a.Img3;
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
            if (fu_img1.HasFile)
            {
                FileInfo img1 = new FileInfo(fu_img1.FileName);
                string connect = img1.Extension;
                string name = Guid.NewGuid().ToString();
                a.Img = name + connect;
                fu_img1.SaveAs(Server.MapPath("Assets/Img/" + name + connect));
            }
            else
            {
                a.Img = a.Img;
                if (dm.AbousUsUpdate(a))
                {
                    pnl_succes.Visible = true;
                }
            }
            if (fu_img2.HasFile)
            {
                FileInfo img2 = new FileInfo(fu_img2.FileName);
                string img2connect = img2.Extension;
                string img2name = Guid.NewGuid().ToString();
                a.Img2 = img2name + img2connect;
                fu_img2.SaveAs(Server.MapPath("Assets/Img/" + img2name + img2connect));
            }
            else
            {
                a.Img2 = a.Img2;
                if (dm.AbousUsUpdate(a))
                {
                    pnl_succes.Visible = true;
                }
            }
            if (fu_img3.HasFile)
            {
                FileInfo img3 = new FileInfo(fu_img3.FileName);
                string img3connect = img3.Extension;
                string img3name = Guid.NewGuid().ToString();
                a.Img3 = img3name + img3connect;
                fu_img3.SaveAs(Server.MapPath("Assets/Img/" + img3name + img3connect));


                if (dm.AbousUsUpdate(a))
                {
                    pnl_succes.Visible = true;
                }
                else
                {
                    pnl_error.Visible = true;
                    lbl_eror.Text = "Güncellenirken bir hata oluştu";
                }
            }
            else
            {
                a.Img3 = a.Img3;
                if (dm.AbousUsUpdate(a))
                {
                    pnl_succes.Visible = true;
                }
            }
        }
    }
}