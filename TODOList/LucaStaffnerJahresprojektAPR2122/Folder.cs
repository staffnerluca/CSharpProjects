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
    public partial class Folder : Form1
    {
        bool doIt;
        public Folder()
        {
            InitializeComponent();
        }
        public Folder(string folderName)
        {
            InitializeComponent();
            label1.Text=folderName;
        }

        private void Folder_Load(object sender, EventArgs e)
        {
            LoadTasksToFolder(doIt);
        }
        private void LoadTasksToFolder(bool doIt)
        {
            if (doIt)
            {
                if (label1.Text.Equals("A") || label1.Text.Equals("B") || label1.Text.Equals("C") || label1.Text.Equals("D"))
                {
                    //Loads All task in the proper folder
                    foreach (Task t in DataP.tasklist)
                    {
                        if (t.folder.Equals(label1.Text))
                        {
                            newTextBox(t.task+";"+t.folder);
                        }
                    }
                }
            }
        }
        private void Folder_KeyDown(object sender, KeyEventArgs e)
        {
            //Load all tasks after the first enter, because it didn't work that well with Folder.Load
            if(e.KeyCode == Keys.Enter)
            {
                LoadTasksToFolder(doIt);
                doIt= false;
            }
        }
    }
}
