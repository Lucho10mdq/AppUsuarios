using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controller
{
    public  class StudentController
    {
        private StudentRepository StudentList = StudentRepository.GetInstance();

        public bool StudentAdd(string name,string surname,string dni,string email,string addres)
        {
            var result = false;
            Student oStudent = new Student(name, surname, dni, email, addres);
            if (StudentList.GetStudentByDni(dni) == null)
            {
                StudentList.StudentAdd(oStudent);
                result = true;
            }
            return result;
        }
        public List<Student> StudentAll()
        {
            return StudentList.StudentAll();
        }

        public Student GetStudentByDni(string dni)
        {
            return StudentList.GetStudentByDni(dni);
        }
    }
}
