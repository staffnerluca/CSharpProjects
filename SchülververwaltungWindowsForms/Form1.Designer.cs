
namespace MitarbeitsprojektForms
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.createStudent = new System.Windows.Forms.Button();
            this.editStudent = new System.Windows.Forms.Button();
            this.ShowAllTeachers = new System.Windows.Forms.Button();
            this.ShowAStudents = new System.Windows.Forms.Button();
            this.ShowAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtfMain = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createStudent
            // 
            this.createStudent.Location = new System.Drawing.Point(218, 152);
            this.createStudent.Name = "createStudent";
            this.createStudent.Size = new System.Drawing.Size(93, 23);
            this.createStudent.TabIndex = 0;
            this.createStudent.Text = "erstellen";
            this.createStudent.UseVisualStyleBackColor = true;
            this.createStudent.Click += new System.EventHandler(this.createStudent_Click);
            // 
            // editStudent
            // 
            this.editStudent.Location = new System.Drawing.Point(327, 152);
            this.editStudent.Name = "editStudent";
            this.editStudent.Size = new System.Drawing.Size(108, 23);
            this.editStudent.TabIndex = 2;
            this.editStudent.Text = "bearbeiten";
            this.editStudent.UseVisualStyleBackColor = true;
            this.editStudent.Click += new System.EventHandler(this.editStudent_Click);
            // 
            // ShowAllTeachers
            // 
            this.ShowAllTeachers.Location = new System.Drawing.Point(317, 181);
            this.ShowAllTeachers.Name = "ShowAllTeachers";
            this.ShowAllTeachers.Size = new System.Drawing.Size(129, 23);
            this.ShowAllTeachers.TabIndex = 6;
            this.ShowAllTeachers.Text = "alle Lehrer anzeigen";
            this.ShowAllTeachers.UseVisualStyleBackColor = true;
            this.ShowAllTeachers.Click += new System.EventHandler(this.ShowAllTeachers_Click);
            // 
            // ShowAStudents
            // 
            this.ShowAStudents.Location = new System.Drawing.Point(186, 181);
            this.ShowAStudents.Name = "ShowAStudents";
            this.ShowAStudents.Size = new System.Drawing.Size(125, 23);
            this.ShowAStudents.TabIndex = 7;
            this.ShowAStudents.Text = "alle Schüler anzeigen";
            this.ShowAStudents.UseVisualStyleBackColor = true;
            this.ShowAStudents.Click += new System.EventHandler(this.ShowAStudents_Click);
            // 
            // ShowAll
            // 
            this.ShowAll.Location = new System.Drawing.Point(452, 181);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(91, 23);
            this.ShowAll.TabIndex = 8;
            this.ShowAll.Text = "alle anzeigen";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Schulverwaltung 2000";
            // 
            // rtfMain
            // 
            this.rtfMain.Location = new System.Drawing.Point(25, 223);
            this.rtfMain.Name = "rtfMain";
            this.rtfMain.Size = new System.Drawing.Size(743, 215);
            this.rtfMain.TabIndex = 10;
            this.rtfMain.Text = "";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(441, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.rtfMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.ShowAStudents);
            this.Controls.Add(this.ShowAllTeachers);
            this.Controls.Add(this.editStudent);
            this.Controls.Add(this.createStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button createStudent;
        private System.Windows.Forms.Button editStudent;
        private System.Windows.Forms.Button ShowAllTeachers;
        private System.Windows.Forms.Button ShowAStudents;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtfMain;
        private System.Windows.Forms.Button btnDelete;
    }
}

