﻿using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KaraagacSporWebb.AdminPanel
{
    public partial class OpposingTeamList : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_OpposingTeam.DataSource = dm.OpposingTeamList();
            lv_OpposingTeam.DataBind();
        }

        protected void lv_OpposingTeam_ItemCommand(object sender, ListViewCommandEventArgs e)
        {

        }
    }
}