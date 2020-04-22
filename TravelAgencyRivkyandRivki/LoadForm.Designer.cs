namespace TravelAgencyRivkyandRivki
{
    partial class LoadForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName2 = new System.Windows.Forms.TextBox();
            this.loadbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter File Name";
            // 
            // txtFileName2
            // 
            this.txtFileName2.Location = new System.Drawing.Point(240, 100);
            this.txtFileName2.Name = "txtFileName2";
            this.txtFileName2.Size = new System.Drawing.Size(162, 22);
            this.txtFileName2.TabIndex = 1;
            // 
            // loadbutton1
            // 
            this.loadbutton1.Location = new System.Drawing.Point(241, 189);
            this.loadbutton1.Name = "loadbutton1";
            this.loadbutton1.Size = new System.Drawing.Size(160, 48);
            this.loadbutton1.TabIndex = 2;
            this.loadbutton1.Text = "Load";
            this.loadbutton1.UseVisualStyleBackColor = true;
            this.loadbutton1.Click += new System.EventHandler(this.Loadbutton1_Click);
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadbutton1);
            this.Controls.Add(this.txtFileName2);
            this.Controls.Add(this.label1);
            this.Name = "LoadForm";
            this.Text = "LoadForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName2;
        private System.Windows.Forms.Button loadbutton1;
    }
}