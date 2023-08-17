using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccesLayer;

namespace KaraagacSporWebb.AdminPanel
{
    public partial class KaraagacSporAdmin : System.Web.UI.MasterPage
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["Admin"] !=null)
            //{
            //    Admin a = (Admin)Session["Admin"];
            //    lb_loginName.Text= $"{a.Name} {a.Surname}";
            //}
            //else
            //{
            //    Response.Redirect("AdminLogin.aspx");    
            //}
        }
    }
}