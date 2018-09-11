using System;
using Controller;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace AppUsuarios
{
    public partial class Registrarse : System.Web.UI.Page
    {
        UserController UserList = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {
            UserList = (UserController)Session["userList"];
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            // User oUser = null;
            var result = false;
            string nombre = txtNombre.Value;
            string email = txtEmail.Value;
            string pass = txtPassword.Value;
            //oUser = UserList.GetUserByEmail(email, pass);
            
               // User user = new User(nombre, email, pass);
               result= UserList.UserAdd(nombre, email, pass);
            if (result==false)
                Response.Write("Ya existe el usuario");
            else
                Response.Redirect("Login.aspx");
            
        }
    }
}