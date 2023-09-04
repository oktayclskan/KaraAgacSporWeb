using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KaraagacSporWebb.AdminPanel
{
    public partial class StadiumList : System.Web.UI.Page
    {
       DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_stadiumList.DataSource = dm.StadiumList();
            lv_stadiumList.DataBind();
        }

        protected void lv_stadiumList_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "dlt")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                dm.StadyumSoftDlt(id);
            }
           
            lv_stadiumList.DataSource = dm.StadiumList();
            lv_stadiumList.DataBind();
        }
    }
}