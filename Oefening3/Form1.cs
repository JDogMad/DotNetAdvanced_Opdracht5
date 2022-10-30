using System.Collections.Generic;
using System.Windows.Forms;

namespace Oefening3 {
    public partial class Form1 : Form {
        public static List<int> list1 = new List<int>();
        public static int index;

        int width;
        int height;

        // width 1386 height 788 
        int maxWidth = 1386;
        int maxHeight = 788;

        public Form1() {
            InitializeComponent();

            width = this.Width;
            height = this.Height;
        }

        private void btnToevoegen_Click(object sender, EventArgs e) {

            formMatrix MDIChild = new formMatrix {
                MdiParent = this
            };

           

            MDIChild.Show();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e) {
           this.Close();
        }
    }
}