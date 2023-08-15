using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using DataAccesLayer;

namespace KaraagacSporWebb.AdminPanel
{
    public partial class PlayerUpdate : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count != 0)
            {
                if (!IsPostBack)
                {
                    int id = Convert.ToInt32(Request.QueryString["pid"]);
                    Players p = dm.PlayerGet(id);
                    tb_name.Text = p.Name;
                    tb_surname.Text = p.Surname;
                    tb_dateOfBirth.Text = p.DateOfBirth.ToShortDateString();
                    tb_uniformNumber.Text = p.UniformNumber;
                    tb_position.Text = p.Position;
                    tb_firtEleven.Checked = p.FirstEleven;
                    tb_status.Checked = p.StatusPlayer;
                    asp_img.ImageUrl = "Assets/Img/"+p.Img;
                }
            }
            else
            {
                Response.Redirect("PlayerList.aspx");
            }
        }

        protected void btn_aboutUsUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["pid"]);
            Players p = dm.PlayerGet(id);
            p.Name = tb_name.Text;
            p.Surname = tb_surname.Text;
            p.DateOfBirth = Convert.ToDateTime(tb_dateOfBirth.Text);
            p.UniformNumber = tb_uniformNumber.Text;
            p.Position = tb_position.Text;
            p.FirstEleven = tb_firtEleven.Checked;
            p.StatusPlayer = tb_status.Checked;
            if (fu_img1.HasFile)
            {
                FileInfo img1 = new FileInfo(fu_img1.FileName);
                string connect = img1.Extension;
                string name = Guid.NewGuid().ToString();
                p.Img = name + connect;
                fu_img1.SaveAs(Server.MapPath("Assets/Img/" + name + connect));
                if (dm.PlayerUpdate(p))
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
                p.Img = p.Img;
                if (dm.PlayerUpdate(p))
                {
                    pnl_succes.Visible = true;
                }
            }
        }
    }
}