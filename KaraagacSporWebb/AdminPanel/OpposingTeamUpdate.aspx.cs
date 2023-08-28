using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KaraagacSporWebb.AdminPanel
{
    public partial class OpposingTeamUpdate : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count != 0)
            {
                if (!IsPostBack)
                {
                    int id = Convert.ToInt32(Request.QueryString["otid"]);
                    OpposingTeam ot = dm.OpposingTeamGet(id);
                    tb_name.Text = ot.Name;
                    asp_img.ImageUrl = "Assets/Img/" + ot.logo;
                }
            }
            else
            {
                Response.Redirect("OpposingTeamList.aspx");
            }
        }

        protected void btn_opposingTeamUpdt_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["otid"]);
            OpposingTeam ot = dm.OpposingTeamGet(id);
            ot.Name = tb_name.Text;
            if (fu_img1.HasFile)
            {
                FileInfo img1 = new FileInfo(fu_img1.FileName);
                string connect = img1.Extension;
                string name = Guid.NewGuid().ToString();
                ot.logo = name + connect;
                fu_img1.SaveAs(Server.MapPath("Assets/Img/" + name + connect));
                if (dm.OpposingTeamUpdate(ot))
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
                ot.logo = ot.logo;
                if (dm.OpposingTeamUpdate(ot))
                {
                    pnl_succes.Visible = true;
                }
            }

        }
    }
}