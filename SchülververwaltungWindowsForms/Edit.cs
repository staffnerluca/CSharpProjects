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
    public partial class Edit : Form
    {
        int index = 0;
        int editIndex;
        public Edit()
        {
            InitializeComponent();
        }
        private void lstbPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string personData = lstbPersons.SelectedItem.ToString();
                string[] editList = new string[50];
                editList = personData.Split(' ');
                if (editList[0].Equals("Schüler:"))
                {
                    txtName.Text = editList[1];
                    txtSurname.Text = editList[2];
                    txtClass.Text = editList[3];
                    txtAge.Text = editList[4];
                    txtTown.Text = editList[5];
                    editIndex = Convert.ToInt32(editList[6]);
                }
                else if (editList[0].Equals("Lehrer:"))
                {
                    txtTfirstName.Text = editList[1];
                    txtTsecondName.Text = editList[2];
                    txtTsubjekt1.Text = editList[3];
                    txtTsubjekt2.Text = editList[4];
                    txtTage.Text = editList[5];
                    txtTtown.Text = editList[6];
                    txtTsalary.Text = editList[7];
                    editIndex = Convert.ToInt32(editList[8]);
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            foreach (Person p in DataP.personList)
            {
                if (p is Student)
                {
                    Student a = p as Student;
                    lstbPersons.Items.Add("Schüler: " + a.firstname + " " + a.secondName + " " + a.schoolclass + " " + a.age + " " + a.town+" "+Convert.ToString(index));
                }
                else
                {
                    Teacher t = p as Teacher;
                    lstbPersons.Items.Add("Lehrer: " + t.firstname + " " + t.secondName + " " + t.subject1 + " " + t.subject2 + " " + t.age + " " + t.town+" "+t.salary+" "+Convert.ToString(index));
                }
                index++;
            }
        }

        private void btnCreatStudent_Click(object sender, EventArgs e)
        {
            if(DataP.personList[editIndex] is Student)
            {
                Student s=DataP.personList[editIndex] as Student;
                s.firstname = txtName.Text;
                s.secondName = txtSurname.Text;
                s.age = Convert.ToInt32(txtAge.Text);
                s.schoolclass = txtClass.Text;
                s.town = txtTown.Text;
            }
            else if(DataP.personList[editIndex] is Teacher)
            {
                Teacher t=DataP.personList[editIndex] as Teacher;
                t.firstname = txtTfirstName.Text;
                t.secondName = txtTsecondName.Text;
                t.age = Convert.ToInt32(txtTage.Text);
                t.salary = Convert.ToInt32(txtTsalary.Text);
                t.town = txtTtown.Text;
                t.subject1 = txtTsubjekt1.Text;
                t.subject2 = txtTsubjekt2.Text;
            }
            StreamWriter w = new StreamWriter(DataP.path);
            w.Write("");
            w.Flush();
            w.Close();
            foreach (Person p in DataP.personList)
            {
                p.WriteToTxt(DataP.path);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataP.personList[editIndex] = null;
            foreach (Person p in DataP.personList)
            {
                if (p != null)
                {
                    p.WriteToTxt(DataP.path);
                }
            }
        }
    }
}
