using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccesLayer;

namespace KaraagacSporWebb.AdminPanel
{
    public partial class AboutUsList : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_AboutUs.DataSource = dm.AboutUsList();
            lv_AboutUs.DataBind();
        }

        protected void lv_AboutUs_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName=="dlt")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                dm.AboutUsDelete(id);
            }
            lv_AboutUs.DataSource = dm.AboutUsList();
            lv_AboutUs.DataBind();
        }
    }
}