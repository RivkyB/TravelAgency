﻿namespace TravelAgencyRivkyandRivki
{
    partial class DisplayAllPeopleAndFlights
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
            this.DisplayAlllistBox1 = new System.Windows.Forms.ListBox();
            this.DisplayAllbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayAlllistBox1
            // 
            this.DisplayAlllistBox1.FormattingEnabled = true;
            this.DisplayAlllistBox1.Location = new System.Drawing.Point(46, 84);
            this.DisplayAlllistBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DisplayAlllistBox1.Name = "DisplayAlllistBox1";
            this.DisplayAlllistBox1.Size = new System.Drawing.Size(498, 160);
            this.DisplayAlllistBox1.TabIndex = 7;
            // 
            // DisplayAllbutton1
            // 
            this.DisplayAllbutton1.Location = new System.Drawing.Point(159, 26);
            this.DisplayAllbutton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DisplayAllbutton1.Name = "DisplayAllbutton1";
            this.DisplayAllbutton1.Size = new System.Drawing.Size(212, 40);
            this.DisplayAllbutton1.TabIndex = 8;
            this.DisplayAllbutton1.Text = "Display all People and Flights";
            this.DisplayAllbutton1.UseVisualStyleBackColor = true;
            this.DisplayAllbutton1.Click += new System.EventHandler(this.DisplayAllbutton1_Click);
            // 
            // DisplayAllPeopleAndFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 303);
            this.Controls.Add(this.DisplayAllbutton1);
            this.Controls.Add(this.DisplayAlllistBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DisplayAllPeopleAndFlights";
            this.Text = "DisplayAllPeopleAndFlights";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DisplayAlllistBox1;
        private System.Windows.Forms.Button DisplayAllbutton1;
    }
}