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
    public partial class SelectDatabase : Form
    {
        SQLCom sql = Variables.sql;

        public SelectDatabase()
        {
            InitializeComponent();
        }

        private void addDBsToCmb()
        {
            List<String> addToCombo = sql.ShowDatabases();
            for (int i = 0; i < addToCombo.Count; i++)
            {
                cmbDatabases.Items.Add(addToCombo[i]);
            }
        }
        private void SelectDatabase_Load(object sender, EventArgs e)
        {
            List<String> addToCombo = sql.ShowDatabases();
            for (int i = 0; i < addToCombo.Count; i++)
            {
                cmbDatabases.Items.Add(addToCombo[i]);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            List<String> databases = sql.ShowDatabases();
            bool exists = false;
            foreach (String database in databases)
            {
                if (cmbDatabases.Text == database)
                    exists = true;
            }
            if (txtRename.Text.Equals(string.Empty))
            {
                if (!exists)
                {
                    sql.database = cmbDatabases.Text;
                    sql.CreateDatabase();
                    sql.ConnectToServer();
                }
            }
            else
            {
                sql.ChangeDatabaseName(cmbDatabases.Text, txtRename.Text);
            }

            Menue menue = new Menue();
            menue.ShowDialog();
            this.Close();
        }

        private void cmbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql.DeleteDatabase(cmbDatabases.Text);
            cmbDatabases.Items.Clear();
            addDBsToCmb();
        }
    }
}
