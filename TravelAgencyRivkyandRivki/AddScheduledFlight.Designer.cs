namespace TravelAgencyRivkyandRivki
{
    partial class AddScheduledFlight
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
            this.FlightNumbertextBox1 = new System.Windows.Forms.TextBox();
            this.ScheduleFlightbutton = new System.Windows.Forms.Button();
            this.SchedFlightdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scheduled Flight";
            // 
            // FlightNumbertextBox1
            // 
            this.FlightNumbertextBox1.Location = new System.Drawing.Point(229, 68);
            this.FlightNumbertextBox1.Name = "FlightNumbertextBox1";
            this.FlightNumbertextBox1.Size = new System.Drawing.Size(149, 22);
            this.FlightNumbertextBox1.TabIndex = 2;
            // 
            // ScheduleFlightbutton
            // 
            this.ScheduleFlightbutton.Location = new System.Drawing.Point(148, 214);
            this.ScheduleFlightbutton.Name = "ScheduleFlightbutton";
            this.ScheduleFlightbutton.Size = new System.Drawing.Size(199, 53);
            this.ScheduleFlightbutton.TabIndex = 4;
            this.ScheduleFlightbutton.Text = "Schedule A Flight";
            this.ScheduleFlightbutton.UseVisualStyleBackColor = true;
            this.ScheduleFlightbutton.Click += new System.EventHandler(this.ScheduleFlightbutton_Click);
            // 
            // SchedFlightdateTimePicker1
            // 
            this.SchedFlightdateTimePicker1.Location = new System.Drawing.Point(229, 104);
            this.SchedFlightdateTimePicker1.Name = "SchedFlightdateTimePicker1";
            this.SchedFlightdateTimePicker1.Size = new System.Drawing.Size(145, 22);
            this.SchedFlightdateTimePicker1.TabIndex = 5;
            // 
            // AddScheduledFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SchedFlightdateTimePicker1);
            this.Controls.Add(this.ScheduleFlightbutton);
            this.Controls.Add(this.FlightNumbertextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddScheduledFlight";
            this.Text = "AddScheduledFlight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FlightNumbertextBox1;
        private System.Windows.Forms.Button ScheduleFlightbutton;
        private System.Windows.Forms.DateTimePicker SchedFlightdateTimePicker1;
    }
}