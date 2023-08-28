using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KaraagacSporWebb.AdminPanel
{
    public partial class PointFixtureAdd : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dll_opposingTeam.DataTextField = "Name";
                dll_opposingTeam.DataValueField = "ID";
                dll_opposingTeam.DataSource = dm.OpposingTeamList();
                dll_opposingTeam.DataBind();
            }
        }

        protected void btn_PointFixtureAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dll_opposingTeam.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(tb_win.Text.Trim()))
                {
                    if (!string.IsNullOrEmpty(tb_Draw.Text.Trim()))
                    {
                        if (!string.IsNullOrEmpty(tb_Lose.Text.Trim()))
                        {
                            if (!string.IsNullOrEmpty(tb_Poing.Text.Trim()))
                            {
                                PointFixture pt = new PointFixture();
                                pt.OpposingTeamID = Convert.ToInt32(dll_opposingTeam.SelectedItem.Value);
                                pt.Win = Convert.ToInt32(tb_win.Text);
                                pt.Draw = Convert.ToInt32(tb_Draw.Text);
                                pt.Lose = Convert.ToInt32(tb_Lose.Text);
                                pt.Point = Convert.ToInt32(tb_Poing.Text);
                                if (dm.FixtureAdd(pt))
                                {
                                    tb_win.Text = " ";
                                    tb_Draw.Text = " ";
                                    tb_Lose.Text = " ";
                                    tb_Poing.Text = " ";
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
                                lbl_eror.Text = "Lütfen Puan ekleyiniz";
                            }
                        }
                        else
                        {
                            pnl_error.Visible = true;
                            lbl_eror.Text = "Lütfen Mağlubiyet ekleyiniz";
                        }
                    }
                    else
                    {
                        pnl_error.Visible = true;
                        lbl_eror.Text = "Lütfen Beraberlik ekleyiniz";
                    }
                }
                else
                {
                    pnl_error.Visible = true;
                    lbl_eror.Text = "Lütfen Galibiyet ekleyiniz";
                }
            }
            else
            {
                pnl_error.Visible = true;
                lbl_eror.Text = "Lütfen Takım Seçiniz ekleyiniz";
            }
        }
    }
}