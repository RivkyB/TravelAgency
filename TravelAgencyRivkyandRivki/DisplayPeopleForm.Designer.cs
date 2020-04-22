namespace TravelAgencyRivkyandRivki
{
    partial class DisplayPeopleForm
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.EnterIDNumberTextBox = new System.Windows.Forms.TextBox();
            this.EnterIDNumberLabel = new System.Windows.Forms.Label();
            this.PassengerListBox = new System.Windows.Forms.ListBox();
            this.Displayallbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(157, 68);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 28);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EnterIDNumberTextBox
            // 
            this.EnterIDNumberTextBox.Location = new System.Drawing.Point(227, 36);
            this.EnterIDNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnterIDNumberTextBox.Name = "EnterIDNumberTextBox";
            this.EnterIDNumberTextBox.Size = new System.Drawing.Size(132, 22);
            this.EnterIDNumberTextBox.TabIndex = 7;
            // 
            // EnterIDNumberLabel
            // 
            this.EnterIDNumberLabel.AutoSize = true;
            this.EnterIDNumberLabel.Location = new System.Drawing.Point(56, 39);
            this.EnterIDNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnterIDNumberLabel.Name = "EnterIDNumberLabel";
            this.EnterIDNumberLabel.Size = new System.Drawing.Size(137, 17);
            this.EnterIDNumberLabel.TabIndex = 6;
            this.EnterIDNumberLabel.Text = "Enter an ID Number:";
            // 
            // PassengerListBox
            // 
            this.PassengerListBox.FormattingEnabled = true;
            this.PassengerListBox.ItemHeight = 16;
            this.PassengerListBox.Location = new System.Drawing.Point(37, 103);
            this.PassengerListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PassengerListBox.MultiColumn = true;
            this.PassengerListBox.Name = "PassengerListBox";
            this.PassengerListBox.ScrollAlwaysVisible = true;
            this.PassengerListBox.Size = new System.Drawing.Size(695, 116);
            this.PassengerListBox.TabIndex = 5;
            // 
            // Displayallbutton1
            // 
            this.Displayallbutton1.Location = new System.Drawing.Point(407, 42);
            this.Displayallbutton1.Name = "Displayallbutton1";
            this.Displayallbutton1.Size = new System.Drawing.Size(198, 36);
            this.Displayallbutton1.TabIndex = 9;
            this.Displayallbutton1.Text = "Display all Passengers";
            this.Displayallbutton1.UseVisualStyleBackColor = true;
            this.Displayallbutton1.Click += new System.EventHandler(this.Displayallbutton1_Click);
            // 
            // DisplayPeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 386);
            this.Controls.Add(this.Displayallbutton1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.EnterIDNumberTextBox);
            this.Controls.Add(this.EnterIDNumberLabel);
            this.Controls.Add(this.PassengerListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DisplayPeopleForm";
            this.Text = "DisplayPeopleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox PassengerListBox;
        public System.Windows.Forms.Button SearchButton;
        public System.Windows.Forms.TextBox EnterIDNumberTextBox;
        public System.Windows.Forms.Label EnterIDNumberLabel;
        public System.Windows.Forms.Button Displayallbutton1;
    }
}