using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MitarbeitsprojektForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createStudent_Click(object sender, EventArgs e)
        {
            CreatePerson f = new CreatePerson();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                DataP.path = ofd.FileName;
                LoadPersons();
            }
            catch(Exception ex)
            {

            }
            this.Show();
        }
        static void LoadPersons()
        {
            try
            {
                StreamReader r = new StreamReader(DataP.path);
                while (r.Peek() > -1)
                {
                    string TeacherOrStudent = r.ReadLine();
                    string firstname = r.ReadLine();
                    string secondName = r.ReadLine();
                    int age = Convert.ToInt32(r.ReadLine());
                    string town = r.ReadLine();
                    if (TeacherOrStudent.Equals("Teacher"))
                    {
                        int salary = Convert.ToInt32(r.ReadLine());
                        string subject1 = r.ReadLine();
                        string subject2 = r.ReadLine();
                        Teacher t = new Teacher(firstname, secondName, age, town, salary, subject1, subject2);
                        DataP.personList.Add(t);
                    }
                    else if (TeacherOrStudent.Equals("Student"))
                    {
                        string schoolclass = r.ReadLine();
                        Student s = new Student(firstname, secondName, age, schoolclass, town);
                        DataP.personList.Add(s);
                    }
                }
                r.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }        }
        private void ShowAStudents_Click(object sender, EventArgs e)
        {
            rtfMain.Text = "Alle Schüler\n \n";
            foreach (Person p in DataP.personList)
            {
                if (p is Student)
                {
                    Student s = p as Student;
                    rtfMain.AppendText(s.WriteData());
                }
            }
        }

        private void ShowAllTeachers_Click(object sender, EventArgs e)
        {
            rtfMain.Text = "Alle Lehrer \n \n";
            foreach (Person p in DataP.personList)
            {
                if (p is Teacher)
                {
                    Teacher s = p as Teacher;
                    rtfMain.AppendText(s.WriteData());
                }
            }
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            rtfMain.Text = "Alle \n \n";
            foreach (Person p in DataP.personList)
            {
                rtfMain.AppendText(p.WriteData());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            editStudent_Click(sender, e);
        }

        private void editStudent_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            this.Hide();
            edit.ShowDialog();
            this.Show();
        }
    }
}
