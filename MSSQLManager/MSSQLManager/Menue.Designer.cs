namespace MSSQLManager
{
    partial class Menue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnNewTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(28, 12);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(128, 66);
            this.btnShowData.TabIndex = 0;
            this.btnShowData.Text = "Show or edit data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // btnNewTable
            // 
            this.btnNewTable.Location = new System.Drawing.Point(188, 12);
            this.btnNewTable.Name = "btnNewTable";
            this.btnNewTable.Size = new System.Drawing.Size(145, 66);
            this.btnNewTable.TabIndex = 2;
            this.btnNewTable.Text = "create new table";
            this.btnNewTable.UseVisualStyleBackColor = true;
            this.btnNewTable.Click += new System.EventHandler(this.btnNewTable_Click);
            // 
            // Menue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 86);
            this.Controls.Add(this.btnNewTable);
            this.Controls.Add(this.btnShowData);
            this.Name = "Menue";
            this.Text = "Menue";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnShowData;
        private Button btnNewTable;
    }
}