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
    public partial class NewsUpdate : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count != 0)
            {
                if (!IsPostBack)
                {
                    int id = Convert.ToInt32(Request.QueryString["neid"]);
                    News n = dm.NewsGet(id);
                    tb_title.Text = n.NewsTitle;
                    tb_description.Text = n.NewsDescription;
                    tb_content.Text = n.NewsContent;
                    asp_cardImg.ImageUrl= "Assets/Img/" + n.NewsCardImg;
                    asp_contentImg.ImageUrl= "Assets/Img/" + n.NewsContentImg;
                }
            }
            else
            {
                Response.Redirect("NewsList.aspx");
            }
        }

        protected void btn_newsUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["neid"]);
            News n = dm.NewsGet(id);
            n.NewsTitle = tb_title.Text;
            n.NewsDescription = tb_description.Text;
            n.NewsContent = tb_content.Text;
            if (fu_cardImg.HasFile)
            {
                FileInfo cardİmg = new FileInfo(fu_cardImg.FileName);
                string connect = cardİmg.Extension;
                string name = Guid.NewGuid().ToString();
                n.NewsCardImg = name + connect;
                fu_cardImg.SaveAs(Server.MapPath("Assets/Img/" + name + connect));
                if (fu_ContentImg.HasFile)
                {
                    FileInfo contentImg = new FileInfo(fu_ContentImg.FileName);
                    string img2connect = contentImg.Extension;
                    string img2name = Guid.NewGuid().ToString();
                    n.NewsContentImg = img2name + img2connect;
                    if (dm.NewsUpdate(n))
                    {
                        pnl_succes.Visible = true;
                        pnl_error.Visible = false;
                    }
                    else
                    {
                        pnl_error.Visible = true;
                        lbl_eror.Text = "Güncellenirken bir hata oluştu";
                    }
                }
                else
                {
                    n.NewsContentImg = n.NewsContentImg;
                    if (dm.NewsUpdate(n))
                    {
                        pnl_succes.Visible = true;
                    }
                }
            }
            else
            {
                n.NewsCardImg = n.NewsCardImg;
                if (dm.NewsUpdate(n))
                {
                    pnl_succes.Visible = true;
                }
            }
        }
    }
}