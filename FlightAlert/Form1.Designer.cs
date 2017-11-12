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
            this.SuspendLayout();
            // 
            // flightsOK
            // 
            this.flightsOK.Location = new System.Drawing.Point(133, 60);
            this.flightsOK.Name = "flightsOK";
            this.flightsOK.Size = new System.Drawing.Size(282, 212);
            this.flightsOK.TabIndex = 0;
            this.flightsOK.UseCompatibleStateImageBehavior = false;
            // 
            // weatherCheckButton
            // 
            this.weatherCheckButton.Location = new System.Drawing.Point(400, 278);
            this.weatherCheckButton.Name = "weatherCheckButton";
            this.weatherCheckButton.Size = new System.Drawing.Size(139, 52);
            this.weatherCheckButton.TabIndex = 1;
            this.weatherCheckButton.Text = "check weather";
            this.weatherCheckButton.UseVisualStyleBackColor = true;
            this.weatherCheckButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // flightWarnings
            // 
            this.flightWarnings.Location = new System.Drawing.Point(524, 60);
            this.flightWarnings.Name = "flightWarnings";
            this.flightWarnings.Size = new System.Drawing.Size(282, 212);
            this.flightWarnings.TabIndex = 2;
            this.flightWarnings.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 410);
            this.Controls.Add(this.flightWarnings);
            this.Controls.Add(this.weatherCheckButton);
            this.Controls.Add(this.flightsOK);
            this.Name = "Form1";
            this.Text = "FlightAlert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView flightsOK;
        private System.Windows.Forms.Button weatherCheckButton;
        private System.Windows.Forms.ListView flightWarnings;
    }
}

