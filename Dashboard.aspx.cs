using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentPatrolTest
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserSession"] !=null)
            {
                if (Session["UserSession"].ToString() !="")
                {
                    lblemail.InnerText = Session["UserSession"].ToString();
                }
            }
        }
    }
}