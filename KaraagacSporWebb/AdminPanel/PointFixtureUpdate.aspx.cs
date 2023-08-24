using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KaraagacSporWebb.AdminPanel
{
    public partial class PointFixtureUpdate : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count != 0)
            {
                if (!IsPostBack)
                {
                    int id = Convert.ToInt32(Request.QueryString["pfid"]);
                    dll_opposingTeam.DataTextField = "Name";
                    dll_opposingTeam.DataValueField = "ID";
                    dll_opposingTeam.DataSource = dm.OpposingTeamList();
                    dll_opposingTeam.DataBind();
                    PointFixture pt = dm.FixtureGet(id);
                    dll_opposingTeam.SelectedValue = pt.OpposingTeamID.ToString();
                    tb_win.Text = Convert.ToString(pt.Win);
                    tb_Draw.Text = Convert.ToString(pt.Draw);
                    tb_lose.Text = Convert.ToString(pt.Lose);
                    tb_point.Text= Convert.ToString(pt.Point);
                }
            }
            else
            {
                Response.Redirect("AboutUsList.aspx");
            }
        }

        protected void btn_pointFixtureUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["pfid"]);
            PointFixture pt = dm.FixtureGet(id);
            pt.OpposingTeamID = Convert.ToInt32(dll_opposingTeam.SelectedItem.Value);
            pt.Win = Convert.ToInt32(tb_win.Text);
            pt.Draw = Convert.ToInt32(tb_Draw.Text);
            pt.Lose = Convert.ToInt32(tb_lose.Text);
            pt.Point= Convert.ToInt32(tb_point.Text);
            if (dm.FixtureUpdate(pt))
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
    }
}