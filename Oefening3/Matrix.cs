using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Oefening3 {
    public partial class formMatrix : Form {
        private System.Windows.Forms.ColorDialog colorDialog1;  


        public formMatrix() {
            InitializeComponent();
        }

        private void Matrix_Load(object sender, EventArgs e)  {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();

            ColorDialog colorDlg = new ColorDialog();
            colorDlg.ShowDialog();
        }
    }
}
