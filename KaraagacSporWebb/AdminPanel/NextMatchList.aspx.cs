using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KaraagacSporWebb.AdminPanel
{
    public partial class NextMatchList : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_NextMatch.DataSource = dm.NextMatchList();
            lv_NextMatch.DataBind();
        }

        protected void lv_NextMatch_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "dlt")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                dm.NextMatchDlt(id);
            }
            lv_NextMatch.DataSource = dm.NextMatchList();
            lv_NextMatch.DataBind(); ;
        }
    }
}