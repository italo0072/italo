using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasePractica092021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGetName_Click(object sender, EventArgs e)
        {
            selectName();
        }
        //metodo para obtener los nombres de la coleccion
        private void selectName()
        {
            //consulta
            List<string> query = (
                from student in Student.GetStudents()
                select student.firstName
                ).ToList();
            //recorrer lista y llenar lstNames
            foreach (var name in query)
            {
                //llenar lstNames
                lstName.Items.Add(name);
            }
        }

        private void btGetData_Click(object sender, EventArgs e)
        {
            //agregar columnas al datagriview
            dgData.Columns.Add("idStudent", "CODIGO");
            dgData.Columns.Add("firstName", "NOMBRE");
            dgData.Columns.Add("lastName", "APELLIDO");
            dgData.Columns.Add("age", "EDAD");
            dgData.Columns.Add("nationality", "NACIONALIDAD");
            foreach (var student in selectAllData())
            {
                dgData.Rows.Add(student.idStudent, student.firstName, student.lastName, student.age, student.nationality);
            }
        }
            //metodo para consultar todos los datos de la coleccion
            private List<Student> selectAllData()
            {
                List<Student> query = (
                    from student in Student.GetStudents()
                    select new Student()
                    {
                        idStudent = student.idStudent,
                        firstName = student.firstName,
                        lastName = student.lastName,
                        age = student.age,
                        nationality = student.nationality
                    }
                    ).ToList();
                return query;
            }
        }
    }

