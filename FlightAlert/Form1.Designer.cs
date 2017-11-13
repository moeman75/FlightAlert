namespace FlightAlert
{
    partial class Form1
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
            this.flightsOK = new System.Windows.Forms.ListView();
            this.weatherCheckButton = new System.Windows.Forms.Button();
            this.flightWarnings = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flightsOK
            // 
            this.flightsOK.Location = new System.Drawing.Point(58, 50);
            this.flightsOK.Name = "flightsOK";
            this.flightsOK.Size = new System.Drawing.Size(282, 212);
            this.flightsOK.TabIndex = 0;
            this.flightsOK.UseCompatibleStateImageBehavior = false;
            // 
            // weatherCheckButton
            // 
            this.weatherCheckButton.Location = new System.Drawing.Point(327, 268);
            this.weatherCheckButton.Name = "weatherCheckButton";
            this.weatherCheckButton.Size = new System.Drawing.Size(139, 52);
            this.weatherCheckButton.TabIndex = 1;
            this.weatherCheckButton.Text = "check weather";
            this.weatherCheckButton.UseVisualStyleBackColor = true;
            this.weatherCheckButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // flightWarnings
            // 
            this.flightWarnings.Location = new System.Drawing.Point(449, 50);
            this.flightWarnings.Name = "flightWarnings";
            this.flightWarnings.Size = new System.Drawing.Size(282, 212);
            this.flightWarnings.TabIndex = 2;
            this.flightWarnings.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Flight Warnings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Flights";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 365);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flightWarnings);
            this.Controls.Add(this.weatherCheckButton);
            this.Controls.Add(this.flightsOK);
            this.Name = "Form1";
            this.Text = "FlightAlert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView flightsOK;
        private System.Windows.Forms.Button weatherCheckButton;
        private System.Windows.Forms.ListView flightWarnings;

        //flight warnings & flight labels
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

