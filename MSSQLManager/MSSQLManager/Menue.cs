using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSQLManager
{
    public partial class Menue : Form
    {
        public Menue()
        {
            InitializeComponent();
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            ShowData showData = new ShowData();
            showData.Show();
        }

        private void btnNewTable_Click(object sender, EventArgs e)
        {
            createTable create = new createTable();
            create.Show();
        }
    }
}
