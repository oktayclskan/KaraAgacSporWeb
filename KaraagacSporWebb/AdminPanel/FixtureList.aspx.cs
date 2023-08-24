using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KaraagacSporWebb.AdminPanel
{
    
    public partial class FixtureList : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_pointFixture.DataSource = dm.PointFixtureList();
            lv_pointFixture.DataBind();
        }

        protected void lv_pointFixture_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "dlt")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                dm.FixtureDlt(id);
            }
            lv_pointFixture.DataSource = dm.PointFixtureList();
            lv_pointFixture.DataBind();
        }
    }
}