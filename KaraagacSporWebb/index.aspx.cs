using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KaraagacSporWebb
{
    public partial class index : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            rp_matchDetail.DataSource = dm.MatchesList();
            rp_matchDetail.DataBind();
        }
    }
}