﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccesLayer;

namespace KaraagacSporWebb
{

    public partial class matches : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            rp_matches.DataSource = dm.MatchesList();
            rp_matches.DataBind();
        }
    }
}