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
            if (Request.QueryString.Count !=0)
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

            }
        }
    }
}