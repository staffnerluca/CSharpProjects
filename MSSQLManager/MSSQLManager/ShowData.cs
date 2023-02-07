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
    public partial class ShowData : Form
    {
        static public DataTable dt = new DataTable();
        SQLCom sql = Variables.sql;
        public ShowData()
        {
            InitializeComponent();
        }

        private void ShowData_Load(object sender, EventArgs e)
        {
            List<String> addToCombo = sql.ShowTables();
            foreach (String s in addToCombo)
            {
                cmbTables.Items.Add(s);
            }
        }

        private void showTable_Click(object sender, EventArgs e)
        {
            dt = sql.GetTableData(cmbTables.Text);
            dgvTable.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!txtNewName.Text.Equals(string.Empty))
            {
                sql.ChangeTableName(cmbTables.Text, txtNewName.Text);
                cmbTables.Text = txtNewName.Text;
                txtNewName.Text = "";
            }
            sql.UpdateDatabaseFromDataGridview(dt, cmbTables.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
