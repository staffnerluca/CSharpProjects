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
    public partial class CreatePerson : Form
    {
        SaveFileDialog sfd = new SaveFileDialog();
        public CreatePerson()
        {
            InitializeComponent();
        }

        private void btnCreatStudent_Click(object sender, EventArgs e)
        {
            if (DataP.path.Equals(""))
            {
                sfd.ShowDialog();
                DataP.path = sfd.FileName;
            }
            string name=txtName.Text;
            txtName.Text = "";
            string surname = txtSurname.Text;
            txtSurname.Text = "";
            string age = txtAge.Text;
            txtAge.Text = "";
            string town = txtTown.Text;
            txtTown.Text = "";
            string sClass = txtClass.Text;
            txtClass.Text = "";
            try
            {
                Student s = new Student(name, surname, Convert.ToInt32(age), sClass, town);
                DataP.personList.Add(s);
                s.WriteToTxt(DataP.path);
            }
            catch(Exception ex)
            {
                if(ex is ageException)
                {
                    MessageBox.Show("Das Alter ist falsch, deswegen war das erstellen nicht erfolgreich.");
                }
                else
                {
                    MessageBox.Show("Es ist ein unbekannter Fehler aufgetreten, weshalb das erstellen nicht erfolgreich war.");
                }
            }
        }

        private void btnCreateTeacher_Click(object sender, EventArgs e)
        {
            if (DataP.path.Equals(""))
            {
                sfd.ShowDialog();
                DataP.path = sfd.FileName;
            }
            string firstname = txtTfirstName.Text;
            txtTfirstName.Text = "";
            string secondname = txtTsecondName.Text;
            txtTsecondName.Text = "";
            string age = txtTage.Text;
            txtTage.Text = "";
            string town = txtTtown.Text;
            txtTtown.Text = "";
            string salary = txtTsalary.Text;
            txtTsalary.Text = "";
            string subject1=txtTsubjekt1.Text;
            txtTsubjekt1.Text = "";
            string subject2 = txtTsubjekt2.Text;
            txtTsubjekt2.Text = "";
            try
            {
                Teacher t = new Teacher(firstname, secondname, Convert.ToInt32(age), town, Convert.ToInt32(salary), subject1, subject2);
                DataP.personList.Add(t);
                t.WriteToTxt(DataP.path);
            }
            catch (Exception ex)
            {
                if (ex is ageException)
                {
                    MessageBox.Show("Das Alter ist falsch, deswegen war das erstellen nicht erfolgreich.");
                }
                else if(ex is SalaryException)
                {
                    MessageBox.Show("Das Gehalt ist icht zulässig.");
                }
                else
                {
                    MessageBox.Show("Es ist ein unbekannter Fehler aufgetreten, weshalb das erstellen nicht erfolgreich war.");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
