using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace AppUsuarios
{
    public partial class ListStudent : System.Web.UI.Page
    {
        StudentController StudentList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserLogin"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                StudentList = (StudentController)Session["studenList"];
                gridAlumnos.DataSource = StudentList.StudentAll();
                gridAlumnos.DataBind();
            }
            
        }
    }
}