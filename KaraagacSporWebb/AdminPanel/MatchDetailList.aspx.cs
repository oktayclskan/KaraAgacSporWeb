using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KaraagacSporWebb.AdminPanel
{
    public partial class MatchDetailList : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_MatchDetail.DataSource = dm.MatchDetailsList();
            lv_MatchDetail.DataBind();
        }

        protected void lv_MatchDetail_ItemCommand(object sender, ListViewCommandEventArgs e)
        {

        }
    }
}