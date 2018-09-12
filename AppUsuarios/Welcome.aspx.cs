using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;


namespace AppUsuarios
{
    public partial class Welcome : System.Web.UI.Page
    {
        UserController UserList = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserLogin"] == null){
                Response.Redirect("Login.aspx");
            }
        }
    }
}