namespace FlightAlert
{
    partial class weather
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
            this.backButton = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextField = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(86, 296);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(131, 52);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(299, 296);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(163, 52);
            this.Continue.TabIndex = 2;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(176, 80);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 22);
            this.cityTextBox.TabIndex = 5;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(176, 119);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(200, 22);
            this.countryTextBox.TabIndex = 6;
            // 
            // ResultTextField
            // 
            this.ResultTextField.AutoSize = true;
            this.ResultTextField.Location = new System.Drawing.Point(176, 159);
            this.ResultTextField.Name = "ResultTextField";
            this.ResultTextField.Size = new System.Drawing.Size(0, 17);
            this.ResultTextField.TabIndex = 8;
            // 
            // weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 453);
            this.Controls.Add(this.ResultTextField);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.backButton);
            this.Name = "weather";
            this.Text = "weather";
            this.Load += new System.EventHandler(this.weather_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label ResultTextField;
    }
}