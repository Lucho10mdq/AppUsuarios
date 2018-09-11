using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
using Controller;

namespace AppUsuarios
{
    public partial class Login : System.Web.UI.Page
    {
        UserController UserList;
        protected void Page_Load(object sender, EventArgs e)
        {
          UserList = (UserController)Session["userList"];
            Session.Abandon();
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Value;
            string password = txtPass.Value;
          
            User oUser = null;

            oUser = UserList.GetUserByEmail(email, password);
            if (oUser != null)
                Response.Redirect("Welcome.aspx");
            else
                Response.Write("El Usuario no Existe");
        }
    }
}