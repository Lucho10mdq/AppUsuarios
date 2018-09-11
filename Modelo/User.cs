using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
        public class User
        {
            int idUser = 0;
            string name, email, password;

            public User(string name, string email, string password)
            {

                this.name = name;
                this.email = email;
                this.password = password;
            }

            public string Email
            {
                get
                {
                    return email;
                }

                set
                {
                    email = value;
                }
            }

            public int IdUser
            {
                get
                {
                    return idUser;
                }

                set
                {
                    idUser = value;
                }
            }

            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }

            public string Password
            {
                get
                {
                    return password;
                }

                set
                {
                    password = value;
                }
            }
        }
   }
