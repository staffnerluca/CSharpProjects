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
namespace LucaStaffnerJahresprojektAPR2122
{
    public partial class ParentForm : Form
    {
        string folderName = "";
        int xCoordinate=200;
        int yCoodinate=20;
        public ParentForm()
        {
            InitializeComponent();
            this.Show();
            this.KeyPreview = true;
            this.Controls.Add(newTextBox(""));
        }
        public TextBox newTextBox(string text)
        {
            //creats the Texboxes for every Form
            TextBox newTxB = new TextBox();
            newTxB.Size = new Size(200, 20);
            newTxB.Focus();
            if (yCoodinate >= 450)
            {
                xCoordinate += 250;
                yCoodinate = 50;
            }
            else
            {
                yCoodinate += 30;

            }
            newTxB.Top = yCoodinate;
            newTxB.Left = xCoordinate;
            newTxB.Text = text;
            newTxB.Tag = "Task";
            return newTxB;
            //this.Controls.Add(newTxB);
            //newTxB.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1)
                btnManual.PerformClick();
            else if (e.KeyCode == Keys.Alt)
            {
                txtCommand.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (txtCommand.Text.Equals(":w"))
                {
                    SaveAllTasks();
                    txtCommand.Text = "";
                }
                else if (txtCommand.Text.Equals(":x"))
                {
                    SaveAllTasks();
                    System.Windows.Forms.Application.ExitThread();
                }
                else if (txtCommand.Text.Equals(":qu!"))
                {
                    System.Windows.Forms.Application.ExitThread();
                }
                else if (txtCommand.Text.Equals(""))
                {
                    this.Controls.Add(newTextBox(""));
                    foreach(Control cont in this.Controls)
                    {
                       if(cont.Tag!=null)
                        {
                            createTask(cont.Text);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("In der Commandline ist ein ungültiger Ausdruck");
                }
            }   
        }
        private void btnNewFolder_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Size = new Size(75, 23);
            this.Controls.Add(b);

        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            Manual m = new Manual();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }
        private void createTask(string txtText)
        {
            if(!txtText.Equals(""))
            {
                //splits the text and crats an instance of task and adds this to the tasklist
                int x = 0;
                List<string> list = new List<string>() { "Hallo", "Welt" };
                foreach (string a in txtText.Split(';'))
                {
                    list[x] = a;
                    x++;
                }
                Task t = new Task(list[0], list[1]);
                DataP.tasklist.Add(t);
            }
        }
        #region open Folder
        private void btnAFol_Click(object sender, EventArgs e)
        {
            folderName = "A";
            openNewFolder();
        }

        private void btnBFol_Click(object sender, EventArgs e)
        {
            folderName = "B";
            openNewFolder();
        }

        private void btnCFol_Click(object sender, EventArgs e)
        {
            folderName= "C";
            openNewFolder();
        }

        private void btnDFol_Click(object sender, EventArgs e)
        {
            folderName = "D";
            openNewFolder();
        }
        #endregion
        private void openNewFolder()
        {
            Folder f=new Folder(folderName);
            this.Hide();
            f.Show();
            this.Show();
        }
        private void SaveAllTasks()
        {
            if (DataP.path.Equals(""))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                DataP.path = sfd.FileName;
            }
            try
            {
                //deletes everything in the file, otherwise the text would be doubled
                StreamWriter w = new StreamWriter(DataP.path);
                w.Write("");
                w.Flush();
                w.Close();
                foreach (Task t in DataP.tasklist)
                {
                    t.SaveTask(true);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Das Speichern war nicht erfolgreich.");
            }
        }
        private void ParentForm_Load_1(object sender, EventArgs e)
        {
            if (DataP.path.Equals(""))
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                DataP.path = ofd.FileName;
            }
            LoadTasks();
        }

        private void LoadTasks()
        {
            try
            {
                StreamReader r = new StreamReader(DataP.path);
                while (r.Peek() != -1)
                {
                    string task = r.ReadLine();
                    string folder = r.ReadLine();
                    Task t = new Task(task, folder);
                    DataP.tasklist.Add(t);
                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Es wurden keine Tasks geladen");
            }
        }
    }
}
