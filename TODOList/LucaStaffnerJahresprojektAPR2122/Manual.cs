using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaStaffnerJahresprojektAPR2122
{
    public partial class Manual : Form
    {
        public Manual()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Manual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnExit.PerformClick();
            else if (e.KeyCode == Keys.D1)
                btnShortcuts.PerformClick();
            else if (e.KeyCode == Keys.D2)
                btnFolderM.PerformClick();
            else if (e.KeyCode == Keys.D3)
                btnTasksM.PerformClick();
            else if (e.KeyCode == Keys.D4)
                btnArrayFolderM.PerformClick();
            else if (e.KeyCode == Keys.D5)
                btnSettingsM.PerformClick();
            else if (e.KeyCode == Keys.D6)
                btnImportData.PerformClick();
        }

        private void btnShortcuts_Click(object sender, EventArgs e)
        {
            rtfManual.Text = "";
        }

        private void btnFolderM_Click(object sender, EventArgs e)
        {
            rtfManual.Text = "Strg+B -> neuer Ordner \r \n Strg+Zahl x -> um den x. Ordner zu öffnen \r \n Strg -> um durch die Oderne zu navigieren (K nach unten und J nach oben)";
        }

        private void btnTasksM_Click(object sender, EventArgs e)
        {
            rtfManual.Text = "Enter in einer Aufgabe -> erstellt eine neue Aufgabe \r \n ";
        }

        private void btnArrayFolderM_Click(object sender, EventArgs e)
        {
            rtfManual.Text = "Button neuer Ordner drücken -> erstellt einen neuen Ordner, es öffnet sich ein Fenster in das dann der Name des Ordners eingegeben werden muss.";
        }

        private void btnSettingsM_Click(object sender, EventArgs e)
        {
            rtfManual.Text = "Klicken Sie auf den Buton Einstellungen um in die Einstellungen zu kommen, dort können Sie zum Beispiel das Erscheinungsbild von weiß auf schwarz ändern.";
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            rtfManual.Text = ": -> um in die Console zu wechseln \r \n :w -> um den aktuellen Stand zu speichern \r \n :qu -> um das Programm zu schließen \r \n :x -> um das Programm zu schließen" +
                "und den Fortschritt zu speichern";
        }

        private void btnAutocomM_Click(object sender, EventArgs e)
        {
            rtfManual.Text = "Alt + + oder Button Wort zur Autovervollständigung hinzuüfgen drücken -> Es öffnet sich ein Fenster, geben Sie in die Eingabzeile ein neues Wort ein, wenn sie die" +
                "ersten Buchstaben von diesem Wort (es sind auch Wortgruppen möglich) in eine Aufgaben Textbox eingeben erscheint ein Vorschlag, welches Ihrer zuvor eingespeicherten Wörter Sie" +
                "gemeint haben könnten, wenn Sie auf Tab drücken wird das Wort (bzw. die Wortgruppe) ausgeschrieben";
        }

        private void Manual_Load(object sender, EventArgs e)
        {

        }
    }
}
