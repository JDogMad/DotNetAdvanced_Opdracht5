using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Oefening2 {
    public partial class Gemiddelde : Form  {
        public Gemiddelde() {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e){
            Form dialog = new Form();
            dialog.Width = 500;
            dialog.Height = 250;
            dialog.Text = "Gemiddelde";

            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Waarde: " };
            NumericUpDown inputBox = new NumericUpDown() { Left = 50, Top = 50, Width = 200 };
            inputBox.Maximum = 99999999999;
            Button confirmation = new Button() { Text = "Toevoegen", Left = 350, Width = 120, Top = 150 };
            confirmation.Click += (sender, e) => { dialog.Close(); };
            dialog.Controls.Add(confirmation);
            dialog.Controls.Add(textLabel);
            dialog.Controls.Add(inputBox);
            dialog.ShowDialog();

            if (confirmation.Text == "Toevoegen") {
                double gem = 0;
                double som = 0;
                lbList.Items.Add(inputBox.Value.ToString());

                int items = lbList.Items.Count; 
                for (int i = 0; i < items; i++) {
                    som += Convert.ToDouble(lbList.Items[i]);
                }
                gem = som / items;
                txtGemiddelde.Text = gem.ToString();
            }
        }
    
    }
}
