using System.Collections.Generic;
using System.Windows.Forms;

namespace Oefening3 {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e) {
            formMatrix MDIChild = new formMatrix();

            MDIChild.MdiParent = this;
            
            MDIChild.Show();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e) {
           // MDIChild.Close();
        }
    }
}