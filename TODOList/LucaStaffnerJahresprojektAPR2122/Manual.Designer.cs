
namespace LucaStaffnerJahresprojektAPR2122
{
    partial class Manual
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
            this.lblManual = new System.Windows.Forms.Label();
            this.btnShortcuts = new System.Windows.Forms.Button();
            this.btnFolderM = new System.Windows.Forms.Button();
            this.btnImportData = new System.Windows.Forms.Button();
            this.btnSettingsM = new System.Windows.Forms.Button();
            this.btnArrayFolderM = new System.Windows.Forms.Button();
            this.btnTasksM = new System.Windows.Forms.Button();
            this.rtfManual = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblManual
            // 
            this.lblManual.AutoSize = true;
            this.lblManual.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManual.ForeColor = System.Drawing.SystemColors.Control;
            this.lblManual.Location = new System.Drawing.Point(226, 9);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(303, 73);
            this.lblManual.TabIndex = 0;
            this.lblManual.Text = "Anleitung";
            // 
            // btnShortcuts
            // 
            this.btnShortcuts.Location = new System.Drawing.Point(108, 96);
            this.btnShortcuts.Name = "btnShortcuts";
            this.btnShortcuts.Size = new System.Drawing.Size(75, 39);
            this.btnShortcuts.TabIndex = 1;
            this.btnShortcuts.Text = "Shortcuts anzeigen (1)";
            this.btnShortcuts.UseVisualStyleBackColor = true;
            this.btnShortcuts.Click += new System.EventHandler(this.btnShortcuts_Click);
            // 
            // btnFolderM
            // 
            this.btnFolderM.Location = new System.Drawing.Point(189, 96);
            this.btnFolderM.Name = "btnFolderM";
            this.btnFolderM.Size = new System.Drawing.Size(75, 39);
            this.btnFolderM.TabIndex = 3;
            this.btnFolderM.Text = "Ordner (2)";
            this.btnFolderM.UseVisualStyleBackColor = true;
            this.btnFolderM.Click += new System.EventHandler(this.btnFolderM_Click);
            // 
            // btnImportData
            // 
            this.btnImportData.Location = new System.Drawing.Point(532, 96);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(75, 39);
            this.btnImportData.TabIndex = 5;
            this.btnImportData.Text = "Console (6)";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // btnSettingsM
            // 
            this.btnSettingsM.Location = new System.Drawing.Point(432, 96);
            this.btnSettingsM.Name = "btnSettingsM";
            this.btnSettingsM.Size = new System.Drawing.Size(94, 39);
            this.btnSettingsM.TabIndex = 6;
            this.btnSettingsM.Text = "weitere Einstellungen (5)";
            this.btnSettingsM.UseVisualStyleBackColor = true;
            this.btnSettingsM.Click += new System.EventHandler(this.btnSettingsM_Click);
            // 
            // btnArrayFolderM
            // 
            this.btnArrayFolderM.Location = new System.Drawing.Point(351, 96);
            this.btnArrayFolderM.Name = "btnArrayFolderM";
            this.btnArrayFolderM.Size = new System.Drawing.Size(75, 39);
            this.btnArrayFolderM.TabIndex = 7;
            this.btnArrayFolderM.Text = "Aufgaben ordnen (4)";
            this.btnArrayFolderM.UseVisualStyleBackColor = true;
            this.btnArrayFolderM.Click += new System.EventHandler(this.btnArrayFolderM_Click);
            // 
            // btnTasksM
            // 
            this.btnTasksM.Location = new System.Drawing.Point(270, 96);
            this.btnTasksM.Name = "btnTasksM";
            this.btnTasksM.Size = new System.Drawing.Size(75, 39);
            this.btnTasksM.TabIndex = 8;
            this.btnTasksM.Text = "Aufgaben erstellen (3)";
            this.btnTasksM.UseVisualStyleBackColor = true;
            this.btnTasksM.Click += new System.EventHandler(this.btnTasksM_Click);
            // 
            // rtfManual
            // 
            this.rtfManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfManual.Location = new System.Drawing.Point(30, 152);
            this.rtfManual.Name = "rtfManual";
            this.rtfManual.Size = new System.Drawing.Size(652, 267);
            this.rtfManual.TabIndex = 9;
            this.rtfManual.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(619, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit (Esc)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rtfManual);
            this.Controls.Add(this.btnTasksM);
            this.Controls.Add(this.btnArrayFolderM);
            this.Controls.Add(this.btnSettingsM);
            this.Controls.Add(this.btnImportData);
            this.Controls.Add(this.btnFolderM);
            this.Controls.Add(this.btnShortcuts);
            this.Controls.Add(this.lblManual);
            this.Name = "Manual";
            this.Text = "Manual";
            this.Load += new System.EventHandler(this.Manual_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Manual_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManual;
        private System.Windows.Forms.Button btnShortcuts;
        private System.Windows.Forms.Button btnFolderM;
        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.Button btnSettingsM;
        private System.Windows.Forms.Button btnArrayFolderM;
        private System.Windows.Forms.Button btnTasksM;
        private System.Windows.Forms.RichTextBox rtfManual;
        private System.Windows.Forms.Button btnExit;
    }
}