using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EbayFactory;

namespace EbayServiceHost
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
      
            
            Response.Redirect("~/EbayService.svc");
        }
    }
}
