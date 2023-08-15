using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccesLayer;

namespace KaraagacSporWebb.AdminPanel
{
    public partial class PlayerList : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_Players.DataSource = dm.PlayerList();
            lv_Players.DataBind();
        }

        protected void lv_Players_ItemCommand(object sender, ListViewCommandEventArgs e)
        {

        }
    }
}