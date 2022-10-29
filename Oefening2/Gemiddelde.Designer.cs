namespace Oefening2
{
    partial class Gemiddelde
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
            this.lbList = new System.Windows.Forms.ListBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtGemiddelde = new System.Windows.Forms.TextBox();
            this.lbGemiddelde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 20;
            this.lbList.Location = new System.Drawing.Point(12, 88);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(1318, 544);
            this.lbList.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(1198, 43);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(122, 29);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Nieuwe getal";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtGemiddelde
            // 
            this.txtGemiddelde.Location = new System.Drawing.Point(12, 45);
            this.txtGemiddelde.Name = "txtGemiddelde";
            this.txtGemiddelde.Size = new System.Drawing.Size(1161, 27);
            this.txtGemiddelde.TabIndex = 2;
            // 
            // lbGemiddelde
            // 
            this.lbGemiddelde.AutoSize = true;
            this.lbGemiddelde.Location = new System.Drawing.Point(15, 12);
            this.lbGemiddelde.Name = "lbGemiddelde";
            this.lbGemiddelde.Size = new System.Drawing.Size(91, 20);
            this.lbGemiddelde.TabIndex = 3;
            this.lbGemiddelde.Text = "Gemiddelde";
            // 
            // Gemiddelde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 685);
            this.Controls.Add(this.lbGemiddelde);
            this.Controls.Add(this.txtGemiddelde);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lbList);
            this.Name = "Gemiddelde";
            this.Text = "Gemiddelde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbList;
        private Button btnNew;
        private TextBox txtGemiddelde;
        private Label lbGemiddelde;
    }
}