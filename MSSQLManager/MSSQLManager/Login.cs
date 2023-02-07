namespace MSSQLManager
{
    public partial class Login : Form
    {
        SQLCom sql = Variables.sql;
        public Login()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (chbIntegSec.Checked)
                sql.integratedSecurity = true;
            else
                sql.integratedSecurity = false;
            sql.server = txtIP.Text;
            sql.username = txtUsername.Text;
            sql.password = txtPassword.Text;
            SelectDatabase selectDatabase = new SelectDatabase();
            this.Hide();
            sql.ConnectToServer();
            selectDatabase.ShowDialog();
            this.Close();
        }
            

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chbIntegSec_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIntegSec.Checked)
            {
                txtUsername.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                txtUsername.ReadOnly = false;
                txtPassword.ReadOnly = false;
            }
        }
    }
}