using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica092021
{
    class Student
    {
        public int idStudent { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public int age { get; set; }

        public string nationality { get; set; }


        //Metodo de coleccion de datos 
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
        {
            new Student{ idStudent= 1001 , firstName= "Jose", lastName= "Rosales", age=25, nationality="El Salvador"},
            new Student{ idStudent= 1002, firstName= "Ana", lastName= "Lopez", age=20, nationality="Mexico"},
            new Student{ idStudent= 1003 , firstName= "Rafael", lastName= "Gonzales", age=21, nationality="Japon"},
            new Student{ idStudent= 1004, firstName= "Alfredo", lastName= "Valladares", age=23, nationality="España"},
            new Student{ idStudent= 1005 , firstName= "Amanda", lastName= "Flores", age=22, nationality="Estados Unidos"},
        };
            return students; //Retornamos la coleccion(Lista)
        }
    }
}
