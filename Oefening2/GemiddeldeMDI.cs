using System.Windows.Forms;

namespace Oefening2 {
    public partial class GemiddeldeMDI : Form {
        public GemiddeldeMDI() {
            InitializeComponent();
        }

        // Ik heb een menustrip gebruikt en als je op file klikt en dan naar gemiddelde 
        // kom je uit op de gemiddelde form
        private void gemiddeldeToolStripMenuItem1_Click(object sender, EventArgs e){
            Gemiddelde MDIChild = new Gemiddelde();
            MDIChild.MdiParent = this;
            MDIChild.Show();
        }
    }
}