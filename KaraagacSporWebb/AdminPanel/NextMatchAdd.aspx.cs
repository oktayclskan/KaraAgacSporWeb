using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KaraagacSporWebb.AdminPanel
{
    public partial class NextMatchAdd : System.Web.UI.Page
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

        protected void btn_NextMatchAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dll_opposingTeam.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(dll_Stadium.Text.Trim()))
                {
                    if (!string.IsNullOrEmpty(tb_date.Text.Trim()))
                    {
                        NextMatch nm = new NextMatch();
                        nm.StadiumID = Convert.ToInt32(dll_Stadium.SelectedItem.Value);
                        nm.OpposingTeamID = Convert.ToInt32(dll_opposingTeam.SelectedItem.Value);
                        nm.Date = Convert.ToDateTime(tb_date.Text);
                        if (dm.NextMatchAdd(nm))
                        {
                            pnl_succes.Visible = true;
                            pnl_error.Visible = false;
                        }
                        else
                        {
                            pnl_error.Visible = true;
                            lbl_eror.Text = "Eklenirken hata oluştu";
                        }
                    }
                    else
                    {
                        pnl_error.Visible = true;
                        lbl_eror.Text = "Lütfen tarih Ekleyiniz ";
                    }
                }
                else
                {
                    pnl_error.Visible = true;
                    lbl_eror.Text = "Lütfen Stadyum Ekleyiniz ";
                }
            }
            else
            {
                pnl_error.Visible = true;
                lbl_eror.Text = "Lütfen Karşı Takım Ekleyiniz ";
            }
        }
    }
}