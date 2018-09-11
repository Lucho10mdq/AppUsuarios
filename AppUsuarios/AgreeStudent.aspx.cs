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
    public partial class AgreeStudent : System.Web.UI.Page
    {
        StudentController StudentList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] == null)
                Response.Redirect("Login.aspx");
            StudentList = (StudentController)Session["studenList"];
        }

        protected void btnGuardarAlu_Click(object sender, EventArgs e)
        {
            var result = false;
            string nombre = txtNombre.Value;
            string apellido = txtApellido.Value;
            string dni = txtDni.Value;
            string email = txtEmails.Value;
            string domicilio = txtDomicilio.Value;

            result = StudentList.StudentAdd(nombre, apellido, dni, email, domicilio);
            if (result == false)
                lblMensaje.Text="Ya existe el Alumno";
            else
                lblMensaje.Text="El alumno fue Agreado con exito";
           
        }
    }
}