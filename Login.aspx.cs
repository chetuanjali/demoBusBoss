using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Geotab.Checkmate.ObjectModel;
using Geotab.Checkmate;
using System.Net.Http;

namespace StudentPatrolTest
{
    public partial class Home : System.Web.UI.Page
    {
        public HtmlControl iframe
        {
            get
            {
                return this.myIframe;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Request.QueryString["email"];
            // use this url to send this page from mygeotab with id and password
            //http://localhost:64272/Home.aspx?email=anjali.com
            if (email == "anjali.com")
            {
                Session["UserSession"] = email.ToString();
                //Response.Redirect("~/Dashboard.aspx");
                //Response.Redirect("~/AddIn.html?email");
                //this.iframe.Attributes.Add("src", "Home.aspx");
            }
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://my384.geotab.com/anjali/#addin-testing_orbit_software_addin-Testing-BusBoss");
                //HTTP GET
                var responseTask = client.GetAsync("");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    //var readTask = result.Content.ReadAsAsync<StudentModelView[]>();
                    //readTask.Wait();

                    //var students = readTask.Result;
                    //return View(students);
                }
            }


            this.iframe.Attributes.Add("src", "Home.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name=txtUser.Text;
            string password = txtPass.Text;
            if (name == "anjali.com")
            {
                if (password=="123")
                {
                    Session["UserSession"] = name.ToString();
                    Response.Redirect("~/Dashboard.aspx");
                }
                
            }
           
        }
    }
}