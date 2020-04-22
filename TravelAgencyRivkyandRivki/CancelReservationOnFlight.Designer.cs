namespace TravelAgencyRivkyandRivki
{
    partial class CancelReservationOnFlight
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flightNumbertextBox1 = new System.Windows.Forms.TextBox();
            this.PasengerIDtextBox1 = new System.Windows.Forms.TextBox();
            this.SeatNumbertextBox1 = new System.Windows.Forms.TextBox();
            this.depDatedateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CancelRservationbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departure Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passenger ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seat Number:";
            // 
            // flightNumbertextBox1
            // 
            this.flightNumbertextBox1.Location = new System.Drawing.Point(170, 57);
            this.flightNumbertextBox1.Name = "flightNumbertextBox1";
            this.flightNumbertextBox1.Size = new System.Drawing.Size(200, 22);
            this.flightNumbertextBox1.TabIndex = 4;
            // 
            // PasengerIDtextBox1
            // 
            this.PasengerIDtextBox1.Location = new System.Drawing.Point(170, 154);
            this.PasengerIDtextBox1.Name = "PasengerIDtextBox1";
            this.PasengerIDtextBox1.Size = new System.Drawing.Size(200, 22);
            this.PasengerIDtextBox1.TabIndex = 5;
            // 
            // SeatNumbertextBox1
            // 
            this.SeatNumbertextBox1.Location = new System.Drawing.Point(170, 193);
            this.SeatNumbertextBox1.Name = "SeatNumbertextBox1";
            this.SeatNumbertextBox1.Size = new System.Drawing.Size(200, 22);
            this.SeatNumbertextBox1.TabIndex = 6;
            // 
            // depDatedateTimePicker1
            // 
            this.depDatedateTimePicker1.Location = new System.Drawing.Point(170, 109);
            this.depDatedateTimePicker1.Name = "depDatedateTimePicker1";
            this.depDatedateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.depDatedateTimePicker1.TabIndex = 7;
            // 
            // CancelRservationbutton1
            // 
            this.CancelRservationbutton1.Location = new System.Drawing.Point(170, 287);
            this.CancelRservationbutton1.Name = "CancelRservationbutton1";
            this.CancelRservationbutton1.Size = new System.Drawing.Size(130, 51);
            this.CancelRservationbutton1.TabIndex = 8;
            this.CancelRservationbutton1.Text = "Cancel Reservation";
            this.CancelRservationbutton1.UseVisualStyleBackColor = true;
            this.CancelRservationbutton1.Click += new System.EventHandler(this.CancelRservationbutton1_Click);
            // 
            // CancelReservationOnFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 393);
            this.Controls.Add(this.CancelRservationbutton1);
            this.Controls.Add(this.depDatedateTimePicker1);
            this.Controls.Add(this.SeatNumbertextBox1);
            this.Controls.Add(this.PasengerIDtextBox1);
            this.Controls.Add(this.flightNumbertextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CancelReservationOnFlight";
            this.Text = "CancelReservationOnFlight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox flightNumbertextBox1;
        private System.Windows.Forms.TextBox PasengerIDtextBox1;
        private System.Windows.Forms.TextBox SeatNumbertextBox1;
        private System.Windows.Forms.DateTimePicker depDatedateTimePicker1;
        private System.Windows.Forms.Button CancelRservationbutton1;
    }
}