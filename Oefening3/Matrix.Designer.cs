namespace Oefening3
{
    partial class formMatrix
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
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // colorPicker
            // 
            this.colorPicker.AnyColor = true;
            this.colorPicker.FullOpen = true;
            // 
            // formMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.HelpButton = true;
            this.Name = "formMatrix";
            this.Text = "Matrix";
            this.Load += new System.EventHandler(this.Matrix_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ColorDialog colorPicker;
    }
}