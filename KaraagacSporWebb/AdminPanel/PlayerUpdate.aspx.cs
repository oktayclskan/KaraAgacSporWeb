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
                    tb_name.Text = p.PlayerName;
                    tb_surname.Text = p.PlayerSurname;
                    tb_dateOfBirth.Text = p.PlayerDateOfBirth.ToShortDateString();
                    tb_uniformNumber.Text = p.PlayerUniformNumber;
                    tb_position.Text = p.PlayerPosition;
                    tb_firtEleven.Checked = p.PlayerFirstEleven;
                    tb_status.Checked = p.PlayerStatusPlayer;
                    asp_img.ImageUrl = "Assets/Img/" + p.PlayerImg;
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
            p.PlayerName = tb_name.Text;
            p.PlayerSurname = tb_surname.Text;
            p.PlayerDateOfBirth = Convert.ToDateTime(tb_dateOfBirth.Text);
            p.PlayerUniformNumber = tb_uniformNumber.Text;
            p.PlayerPosition = tb_position.Text;
            p.PlayerFirstEleven = tb_firtEleven.Checked;
            p.PlayerStatusPlayer = tb_status.Checked;
            if (fu_img1.HasFile)
            {
                FileInfo img1 = new FileInfo(fu_img1.FileName);
                string connect = img1.Extension;
                string name = Guid.NewGuid().ToString();
                p.PlayerImg = name + connect;
                fu_img1.SaveAs(Server.MapPath("Assets/Img/" + name + connect));
                if (dm.PlayerUpdate(p))
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
                p.PlayerImg = p.PlayerImg;
                if (dm.PlayerUpdate(p))
                {
                    pnl_succes.Visible = true;
                }
            }
        }
    }
}