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

        public formMatrix() {
            InitializeComponent();
        }

        public void ColorDialog_Load(object sender, EventArgs e) {
            n1.Value = Form1.list1[Form1.index];
            Form1.list1[Form1.index] = (int)n1.Value;
        }

        private void n1_ValueChanged(object sender, EventArgs e) {
            
        }
        private void n2_ValueChanged(object sender, EventArgs e)  {
        }

        private void n3_ValueChanged(object sender, EventArgs e) {
        }


    }
}
