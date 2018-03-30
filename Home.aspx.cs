using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace StudentPatrolTest
{
    public partial class Home1 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Request.QueryString["email"];
            //http://localhost:64272/Home.aspx?email=anjali.com
            if (email=="anjali.com")
            {
                Session["UserSession"] = email.ToString();
                //Response.Redirect("~/Dashboard.aspx");
                Response.Redirect("~/AddIn.html?email");
            }

            

        }

        
    }
}