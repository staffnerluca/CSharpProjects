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
    public partial class createTable : Form
    {
        SQLCom sql = Variables.sql;
        //Variables for the method createField
        static int numberTxt = 0, numberCom = 0, yCoordinate = 100;
        static List<string> fieldNames = new List<string>();
        static List<string> dataTypes = new List<string>();
        static List<bool> primaryKeys = new List<bool>();
        static List<bool> notNull = new List<bool>();

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            createTxtName();
            createComDataType();
            createChPrim();
            createChNull();
            yCoordinate += 50;
        }

        public createTable()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            addValuesToLists();
            sql.CreateTableFromUser(fieldNames, dataTypes, primaryKeys, notNull);
            MessageBox.Show("Done");
        }

        private void addValuesToLists()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    if (!tb.Text.Equals(string.Empty))
                        fieldNames.Add(c.Text);
                }
                else if (c is ComboBox)
                {
                    ComboBox cb = c as ComboBox;
                    dataTypes.Add(cb.Text);
                }
                else if (c is CheckBox && c.Name.Equals("chbPrim"))
                {
                    CheckBox cb = c as CheckBox;
                    primaryKeys.Add(cb.Checked);
                }
                else if (c is CheckBox && c.Name.Equals("chbNull"))
                {
                    CheckBox cb = c as CheckBox;
                    notNull.Add(cb.Checked);
                }
            }
        }

        private void createTable_Load(object sender, EventArgs e)
        {
            createTxtName();
            createComDataType();
            createChPrim();
            createChNull();
            yCoordinate += 50;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Controls.Count > 9)
            {
                for(int i = 0; i < 3; i++)
                {
                    Controls[Controls.Count-i-1].Dispose();
                }
                yCoordinate -= 50;
            }
        }

        private void createTxtName()
        {
            TextBox txtfieldName = new TextBox();
            txtfieldName.Name = "fieldName" + numberTxt;
            txtfieldName.Location = new Point(27, yCoordinate);
            numberTxt += 1;
            Controls.Add(txtfieldName);
        }

        private void createComDataType()
        {
            ComboBox cbDataType = new ComboBox();
            cbDataType.Name = "comDatatype" + numberCom;
            cbDataType.Location = new Point(168, yCoordinate);
            #region Add Items to combo
            cbDataType.Items.Add("bigint");
            cbDataType.Items.Add("binary(50)");
            cbDataType.Items.Add("bit");
            cbDataType.Items.Add("char(10)");
            cbDataType.Items.Add("date");
            cbDataType.Items.Add("datetime");
            cbDataType.Items.Add("datetime2(7)");
            cbDataType.Items.Add("datetimeoffset(7)");
            cbDataType.Items.Add("decimal(18,0)");
            cbDataType.Items.Add("float");
            cbDataType.Items.Add("image");
            cbDataType.Items.Add("int");
            cbDataType.Items.Add("money");
            cbDataType.Items.Add("nchar(10)");
            cbDataType.Items.Add("ntext");
            cbDataType.Items.Add("numeric(18,0)");
            cbDataType.Items.Add("nvarchar(50)");
            cbDataType.Items.Add("nvarchar(MAX)");
            cbDataType.Items.Add("real");
            cbDataType.Items.Add("rowversion");
            cbDataType.Items.Add("smalldatetime");
            cbDataType.Items.Add("smallint");
            cbDataType.Items.Add("smallmoney");
            cbDataType.Items.Add("sql_variant");
            cbDataType.Items.Add("text");
            cbDataType.Items.Add("time(7)");
            cbDataType.Items.Add("tinyint");
            cbDataType.Items.Add("uniqueidentifier");
            cbDataType.Items.Add("varbinary(50)");
            cbDataType.Items.Add("varbinary(MAX)");
            cbDataType.Items.Add("varchar(50)");
            cbDataType.Items.Add("varchar(MAX)");
            #endregion
            Controls.Add(cbDataType);
        }

        private void createChPrim()
        {
            CheckBox chbPrim = new CheckBox();
            chbPrim.Name = "chbPrim";
            chbPrim.Location = new Point(320, yCoordinate);
            Controls.Add(chbPrim);
        }

        private void createChNull()
        {
            CheckBox chbNull = new CheckBox();
            chbNull.Name = "chbNull";
            chbNull.Location = new Point(456, yCoordinate);
            Controls.Add(chbNull);
        }
    } 
 }
