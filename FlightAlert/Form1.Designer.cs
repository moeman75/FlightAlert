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
            this.weatherCheckButton = new System.Windows.Forms.Button();
            this.PlaneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weatherCheckButton
            // 
            this.weatherCheckButton.Location = new System.Drawing.Point(407, 122);
            this.weatherCheckButton.Margin = new System.Windows.Forms.Padding(2);
            this.weatherCheckButton.Name = "weatherCheckButton";
            this.weatherCheckButton.Size = new System.Drawing.Size(104, 42);
            this.weatherCheckButton.TabIndex = 1;
            this.weatherCheckButton.Text = "check weather";
            this.weatherCheckButton.UseVisualStyleBackColor = true;
            this.weatherCheckButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlaneButton
            // 
            this.PlaneButton.Location = new System.Drawing.Point(181, 122);
            this.PlaneButton.Name = "PlaneButton";
            this.PlaneButton.Size = new System.Drawing.Size(103, 42);
            this.PlaneButton.TabIndex = 2;
            this.PlaneButton.Text = "Add a Plane";
            this.PlaneButton.UseVisualStyleBackColor = true;
            this.PlaneButton.Click += new System.EventHandler(this.PlaneButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 285);
            this.Controls.Add(this.PlaneButton);
            this.Controls.Add(this.weatherCheckButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "FlightAlert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button weatherCheckButton;
        private System.Windows.Forms.Button PlaneButton;
    }
}

