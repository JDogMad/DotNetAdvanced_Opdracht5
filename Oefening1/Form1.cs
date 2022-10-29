using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Oefening1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // Het hoofdmenu heeft ook een Exit-commando dat de form sluit (this.Close())
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        // Bij het veranderen van de kleuren gebruik ik een RichTextBox 
        // Zodat je de geslecteerde tekst kan veranderen (tekst highlighten en dan rechtermuis klik)
        private void redToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(txtText.SelectedText)) {
                txtText.SelectionColor = Color.Red;
            }
        }
        private void greenToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(txtText.SelectedText)) {
                txtText.SelectionColor = Color.Green;
            }
        }
        private void blueToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(txtText.SelectedText)) {
                txtText.SelectionColor = Color.Blue;
            }
        }

        // Het veranderen van de achtergrondkleur van de form 
        private void redToolStripMenuItem1_Click(object sender, EventArgs e) {
            txtText.BackColor = Color.Red;
        }
        private void greenToolStripMenuItem1_Click(object sender, EventArgs e) {
            txtText.BackColor = Color.Green;
        }
        private void blueToolStripMenuItem1_Click(object sender, EventArgs e) {
            txtText.BackColor = Color.Blue;
        }

        // Het veranderen van de fontsize
        private void smallToolStripMenuItem_Click(object sender, EventArgs e){
            txtText.SelectionFont = new Font(txtText.SelectionFont.FontFamily, 7.0F);
        }
        private void normalToolStripMenuItem_Click(object sender, EventArgs e) {
            txtText.SelectionFont = new Font(txtText.SelectionFont.FontFamily, 14.0F);
        }
        private void largeToolStripMenuItem_Click(object sender, EventArgs e){
            txtText.SelectionFont = new Font(txtText.SelectionFont.FontFamily, 24.0F);
        }
    }
}