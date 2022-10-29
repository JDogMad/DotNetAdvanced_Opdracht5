namespace Oefening2
{
    partial class GemiddeldeMDI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gemiddeldeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gemiddeldeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gemiddeldeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1358, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gemiddeldeToolStripMenuItem
            // 
            this.gemiddeldeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gemiddeldeToolStripMenuItem1});
            this.gemiddeldeToolStripMenuItem.Name = "gemiddeldeToolStripMenuItem";
            this.gemiddeldeToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.gemiddeldeToolStripMenuItem.Text = "File";
            // 
            // gemiddeldeToolStripMenuItem1
            // 
            this.gemiddeldeToolStripMenuItem1.Name = "gemiddeldeToolStripMenuItem1";
            this.gemiddeldeToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.gemiddeldeToolStripMenuItem1.Text = "Gemiddelde";
            this.gemiddeldeToolStripMenuItem1.Click += new System.EventHandler(this.gemiddeldeToolStripMenuItem1_Click);
            // 
            // GemiddeldeMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 708);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GemiddeldeMDI";
            this.Text = "GemiddeldeMDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gemiddeldeToolStripMenuItem;
        private ToolStripMenuItem gemiddeldeToolStripMenuItem1;
    }
}