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
    public partial class ModifyStudent : System.Web.UI.Page
    {
        StudentController StudentList;
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentList = (StudentController)Session["studenList"];
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Student oStudent = null;
            string dni = txtDni.Value;
            oStudent = StudentList.GetStudentByDni(dni);
            if(oStudent!=null)
            {
                txtName.Value = oStudent.Nombre;
            }
        }

        protected void btnBuscarDni_Click(object sender, EventArgs e)
        {
            Student oStudent = null;
            string dni = txtDni.Value;
            oStudent = StudentList.GetStudentByDni(dni);
            if (oStudent != null)
            {
                txtName.Value = oStudent.Nombre;
                txtSurname.Value = oStudent.Apellido;
                txtDom.Value = oStudent.Domicilio;
                txtEmails.Value = oStudent.Email;
            }
        }
    }
}