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
    public partial class OpposingTeamAdd : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_opposingTeamAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_name.Text.Trim()))
            {
                OpposingTeam ot = new OpposingTeam();
                ot.Name = tb_name.Text;
                if (fu_opposingImg.HasFile)
                {
                    FileInfo img1 = new FileInfo(fu_opposingImg.FileName);
                    string connect = img1.Extension;
                    string name = Guid.NewGuid().ToString();
                    ot.logo = name + connect;
                    fu_opposingImg.SaveAs(Server.MapPath("Assets/Img/" + name + connect));
                    if (dm.OpposingTeamAdd(ot))
                    {
                        tb_name.Text = " ";
                        pnl_succes.Visible = true;
                        pnl_error.Visible = false;
                    }
                    else
                    {
                        pnl_error.Visible = true;
                        lbl_eror.Text = "Eklenirken Bir Hata Oluştu";
                    }
                }
            }
            else
            {
                pnl_error.Visible = true;
                lbl_eror.Text = "Lütfen İsim Ekleyiniz Oluştu";
            }
        }
    }
}