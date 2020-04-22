namespace TravelAgencyRivkyandRivki
{
    partial class DisplayScheduledFlight
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
            this.label2 = new System.Windows.Forms.Label();
            this.flightIdtextBox1 = new System.Windows.Forms.TextBox();
            this.deptdatedateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.displayschedflightbutton1 = new System.Windows.Forms.Button();
            this.displayflightlistBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departure Date:";
            // 
            // flightIdtextBox1
            // 
            this.flightIdtextBox1.Location = new System.Drawing.Point(221, 60);
            this.flightIdtextBox1.Name = "flightIdtextBox1";
            this.flightIdtextBox1.Size = new System.Drawing.Size(200, 22);
            this.flightIdtextBox1.TabIndex = 2;
            // 
            // deptdatedateTimePicker1
            // 
            this.deptdatedateTimePicker1.Location = new System.Drawing.Point(221, 104);
            this.deptdatedateTimePicker1.Name = "deptdatedateTimePicker1";
            this.deptdatedateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.deptdatedateTimePicker1.TabIndex = 3;
            // 
            // displayschedflightbutton1
            // 
            this.displayschedflightbutton1.Location = new System.Drawing.Point(151, 174);
            this.displayschedflightbutton1.Name = "displayschedflightbutton1";
            this.displayschedflightbutton1.Size = new System.Drawing.Size(154, 45);
            this.displayschedflightbutton1.TabIndex = 4;
            this.displayschedflightbutton1.Text = "Display Flight";
            this.displayschedflightbutton1.UseVisualStyleBackColor = true;
            this.displayschedflightbutton1.Click += new System.EventHandler(this.Displayschedflightbutton1_Click);
            // 
            // displayflightlistBox1
            // 
            this.displayflightlistBox1.FormattingEnabled = true;
            this.displayflightlistBox1.ItemHeight = 16;
            this.displayflightlistBox1.Location = new System.Drawing.Point(77, 248);
            this.displayflightlistBox1.Name = "displayflightlistBox1";
            this.displayflightlistBox1.Size = new System.Drawing.Size(344, 164);
            this.displayflightlistBox1.TabIndex = 5;
            // 
            // DisplayScheduledFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.displayflightlistBox1);
            this.Controls.Add(this.displayschedflightbutton1);
            this.Controls.Add(this.deptdatedateTimePicker1);
            this.Controls.Add(this.flightIdtextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DisplayScheduledFlight";
            this.Text = "DisplayScheduledFlight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox flightIdtextBox1;
        private System.Windows.Forms.DateTimePicker deptdatedateTimePicker1;
        private System.Windows.Forms.Button displayschedflightbutton1;
        private System.Windows.Forms.ListBox displayflightlistBox1;
    }
}