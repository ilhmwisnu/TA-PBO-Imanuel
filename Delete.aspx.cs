using PBO_Imanuel.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PBO_Imanuel
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            var res = MobilDB.deleteMobil(id);
            result.Text = res;
            Response.Redirect("~/");

        }
    }
}