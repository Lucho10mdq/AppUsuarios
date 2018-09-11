using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Modelo
{
        public class StudentRepository:Singleton<StudentRepository>
        {
            private List<Student> StudentList = new List<Student>();
            static StudentRepository instance = null;
            SqlConnection conexion = new SqlConnection(@"Server=LAPTOP-4RC7FOER;Database=Alumnos;Trusted_Connection=True;");

        public int StudentAdd(Student oAlumno)
          {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Add_Student";
            c.Parameters.AddWithValue("name", oAlumno.Nombre);
            c.Parameters.AddWithValue("surname", oAlumno.Apellido);
            c.Parameters.AddWithValue("dni", oAlumno.Dni);
            c.Parameters.AddWithValue("email", oAlumno.Email);
            c.Parameters.AddWithValue("domicilio", oAlumno.Domicilio);
            int affectedRows = c.ExecuteNonQuery();
            conexion.Close();
            return affectedRows;

          }
           
            public List<Student> StudentAll()
            {
                 conexion.Open();
                 SqlCommand c = conexion.CreateCommand();
                 c.CommandType = CommandType.StoredProcedure;
                 c.CommandText = "All_Student";
                 SqlDataReader dn = c.ExecuteReader();
                 c.Prepare();
                    while (dn.Read())
                    {
                        string name = dn.GetString(1);
                        string surname = dn.GetString(2);
                        string dni = dn.GetString(3);
                        string email = dn.GetString(4);
                        string domicilio = dn.GetString(5);
                        Student oStudent = new Student(name, surname, dni, email, domicilio);
                        oStudent.Id = dn.GetInt32(0);
                        StudentList.Add(oStudent);
                    }
                dn.Close();
                conexion.Close();
                return StudentList;

            }
            public Student GetStudentByDni(string dni)
            {
                Student oStudent = null;
                conexion.Open();
                SqlCommand c = conexion.CreateCommand();
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "Get_StudentByDni";

                SqlParameter DniParameter = c.CreateParameter();
                DniParameter.ParameterName = "@dni";
                DniParameter.SqlDbType = SqlDbType.VarChar;
                DniParameter.Value = dni;
                c.Parameters.Add(DniParameter);

                
                SqlDataReader dn = c.ExecuteReader();

                    while (dn.Read())
                    {
                        string name = dn.GetString(1);
                        string surname = dn.GetString(2);
                        string Dni = dn.GetString(3);
                        string email = dn.GetString(4);
                        string domicilio = dn.GetString(5);
                         oStudent = new Student(name, surname, dni, email, domicilio);
                        oStudent.Id = dn.GetInt32(0);
                 }
                    dn.Close();
                    conexion.Close();
                    return oStudent;
            }
    }
}

