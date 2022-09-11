
namespace LucaStaffnerJahresprojektAPR2122
{
    partial class ParentForm
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
            this.btnManual = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnDFol = new System.Windows.Forms.Button();
            this.btnCFol = new System.Windows.Forms.Button();
            this.btnBFol = new System.Windows.Forms.Button();
            this.btnAFol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(12, 12);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(75, 40);
            this.btnManual.TabIndex = 0;
            this.btnManual.Text = "Anleitung (Esc)";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(260, 488);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(442, 20);
            this.txtCommand.TabIndex = 3;
            this.txtCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnDFol
            // 
            this.btnDFol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDFol.Location = new System.Drawing.Point(12, 244);
            this.btnDFol.Name = "btnDFol";
            this.btnDFol.Size = new System.Drawing.Size(75, 50);
            this.btnDFol.TabIndex = 6;
            this.btnDFol.Text = "D";
            this.btnDFol.UseVisualStyleBackColor = true;
            this.btnDFol.Click += new System.EventHandler(this.btnDFol_Click);
            // 
            // btnCFol
            // 
            this.btnCFol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCFol.Location = new System.Drawing.Point(12, 188);
            this.btnCFol.Name = "btnCFol";
            this.btnCFol.Size = new System.Drawing.Size(75, 50);
            this.btnCFol.TabIndex = 7;
            this.btnCFol.Text = "C";
            this.btnCFol.UseVisualStyleBackColor = true;
            this.btnCFol.Click += new System.EventHandler(this.btnCFol_Click);
            // 
            // btnBFol
            // 
            this.btnBFol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBFol.Location = new System.Drawing.Point(12, 132);
            this.btnBFol.Name = "btnBFol";
            this.btnBFol.Size = new System.Drawing.Size(75, 50);
            this.btnBFol.TabIndex = 8;
            this.btnBFol.Text = "B";
            this.btnBFol.UseVisualStyleBackColor = true;
            this.btnBFol.Click += new System.EventHandler(this.btnBFol_Click);
            // 
            // btnAFol
            // 
            this.btnAFol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAFol.Location = new System.Drawing.Point(12, 76);
            this.btnAFol.Name = "btnAFol";
            this.btnAFol.Size = new System.Drawing.Size(75, 50);
            this.btnAFol.TabIndex = 9;
            this.btnAFol.Text = "A";
            this.btnAFol.UseVisualStyleBackColor = true;
            this.btnAFol.Click += new System.EventHandler(this.btnAFol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(129, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Task;Folder";
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAFol);
            this.Controls.Add(this.btnBFol);
            this.Controls.Add(this.btnCFol);
            this.Controls.Add(this.btnDFol);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.btnManual);
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.Load += new System.EventHandler(this.ParentForm_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnDFol;
        private System.Windows.Forms.Button btnCFol;
        private System.Windows.Forms.Button btnBFol;
        private System.Windows.Forms.Button btnAFol;
        private System.Windows.Forms.Label label1;
    }
}

