using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace KaraagacSporWebb.AdminPanel
{
    public partial class MatchAdd : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dll_Stadium.DataTextField = "StadiumName";
                dll_Stadium.DataValueField = "ID";
                dll_Stadium.DataSource = dm.StadiumList();
                dll_Stadium.DataBind();
                dll_opposingTeam.DataTextField = "Name";
                dll_opposingTeam.DataValueField = "ID";
                dll_opposingTeam.DataSource = dm.OpposingTeamList();
                dll_opposingTeam.DataBind();
            }
        }

        protected void btn_matchAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dll_Stadium.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(tb_MatchDateTime.Text.Trim()))
                {
                    Matches m = new Matches();
                    m.StadiumID = Convert.ToInt32(dll_Stadium.SelectedItem.Value);
                    m.OpposingTeamID = Convert.ToInt32(dll_opposingTeam.SelectedItem.Value);
                    m.StadiumOwner = cb_StadiumOwner.Checked;
                    m.MatchDateTime = Convert.ToDateTime(tb_MatchDateTime.Text);
                    if (dm.MatchAdd(m))
                    {
                        tb_MatchDateTime.Text = " ";
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
                    lbl_eror.Text = "Lütfen Maç Tarihi ekleyiniz";
                }
            }
        }
    }
}
