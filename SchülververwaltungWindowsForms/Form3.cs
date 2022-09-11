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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string age = txtAge.Text;
            string town = txtTown.Text;
            string salary = txtSalary.Text;
            string subject1 = txtSubjekt1.Text;
            string subject2 = txtSubjekt2.Text;
            try
            {
                Teacher s = new Teacher(name, surname, Convert.ToInt32(age), town, Convert.ToInt32(salary), subject1, subject2);
                //personList.Add(s);
                StreamWriter w = new StreamWriter(@"D:\APR\MitarbeitsprojektFormsStaffnerL");
                w.WriteLine("Teacher");
                w.WriteLine(name);
                w.WriteLine(surname);
                w.WriteLine(age);
                w.WriteLine(town);
                w.WriteLine(salary);
                w.WriteLine(subject1);
                w.WriteLine(subject2);
            }
            catch (Exception ex)
            {
                if (ex is ageException)
                {
                    MessageBox.Show("Das Alter ist falsch, deswegen war das erstellen nicht Erfolgreich.");
                }
                else if (ex is SalaryException)
                    MessageBox.Show("Das Gehalt ist falsch, deswegen war das Erstellen nicht erfolgreich");
                else
                {
                    MessageBox.Show("Es ist ein unbekannter Fehler aufgetreten, weshalb das erstellen nicht erfolgreich war.");
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
