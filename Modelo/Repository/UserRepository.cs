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
    public class UserRepository : Singleton<UserRepository>
    {
        private List<User> UserList = new List<User>();
        //private List<User> UserList = (List<User>) HttpContext.Current.Application["userList"];
        static UserRepository instance = null;

        SqlConnection conexion = new SqlConnection(@"Server=LAPTOP-4RC7FOER;Database=Alumnos;Trusted_Connection=True;");

        public int UserAdd(User oUser)
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Add_User";
            c.Parameters.AddWithValue("name", oUser.Name);
            c.Parameters.AddWithValue("email", oUser.Email);
            c.Parameters.AddWithValue("password", oUser.Password);
            int affectedRows = c.ExecuteNonQuery();
            conexion.Close();
            return affectedRows;
        }

        public List<User> UserAll()
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "All_User";
            SqlDataReader dn = c.ExecuteReader();
            c.Prepare();
            while (dn.Read())
            {
                string name = dn.GetString(1);
                string email = dn.GetString(2);
                string password = dn.GetString(3);
                User oUser = new User(name, email, password);
                oUser.IdUser = dn.GetInt32(0);
                UserList.Add(oUser);
            }
            dn.Close();
            conexion.Close();
            return UserList;
        }

        public User GetUserByEmail(string email, string password)
        {
            User oUser = null;
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Get_UserByEmail";

            SqlParameter EmailParameter = c.CreateParameter();
            EmailParameter.ParameterName = "@email";
            EmailParameter.SqlDbType = SqlDbType.VarChar;
            EmailParameter.Value = email;
            c.Parameters.Add(EmailParameter);

            SqlParameter PasswordParameter = c.CreateParameter();
            PasswordParameter.ParameterName = "@password";
            PasswordParameter.SqlDbType = SqlDbType.VarChar;
            PasswordParameter.Value = password;
            c.Parameters.Add(PasswordParameter);
            SqlDataReader dn = c.ExecuteReader();

            while (dn.Read())
            {
                string name = dn.GetString(1);
                string emails = dn.GetString(2);
                string pass = dn.GetString(3);
                oUser = new User(name, email, password);
                oUser.IdUser = dn.GetInt32(0);
            }
            dn.Close();
            conexion.Close();
            return oUser;
        }
    }
}
