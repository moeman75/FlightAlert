﻿namespace FlightAlert
{
    partial class PlanesForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.datetimelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.destarrivelabel = new System.Windows.Forms.Label();
            this.Timelebel = new System.Windows.Forms.Label();
            this.warninglabel1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.warninglabel2 = new System.Windows.Forms.Label();
            this.warninglabel3 = new System.Windows.Forms.Label();
            this.warninglabel4 = new System.Windows.Forms.Label();
            this.warninglabel5 = new System.Windows.Forms.Label();
            this.warninglabelmaster = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.myAirportDataSet = new FlightAlert.MyAirportDataSet();
            this.incomingPlanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomingPlanesTableAdapter = new FlightAlert.MyAirportDataSetTableAdapters.IncomingPlanesTableAdapter();
            this.planeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfArrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivingFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outgoingPlanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outgoingPlanesTableAdapter = new FlightAlert.MyAirportDataSetTableAdapters.OutgoingPlanesTableAdapter();
            this.planeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfDepartureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAirportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingPlanesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outgoingPlanesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planeIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.delayedDataGridViewTextBoxColumn,
            this.dateOfArrivalDataGridViewTextBoxColumn,
            this.arrivingFromDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.incomingPlanesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(393, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(569, 190);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plane Name";
            // 
            // datetimelabel
            // 
            this.datetimelabel.AutoSize = true;
            this.datetimelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimelabel.Location = new System.Drawing.Point(12, 154);
            this.datetimelabel.Name = "datetimelabel";
            this.datetimelabel.Size = new System.Drawing.Size(153, 25);
            this.datetimelabel.TabIndex = 2;
            this.datetimelabel.Text = "datetimelabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arrival or Departure?";
            // 
            // destarrivelabel
            // 
            this.destarrivelabel.AutoSize = true;
            this.destarrivelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destarrivelabel.Location = new System.Drawing.Point(12, 234);
            this.destarrivelabel.Name = "destarrivelabel";
            this.destarrivelabel.Size = new System.Drawing.Size(131, 25);
            this.destarrivelabel.TabIndex = 4;
            this.destarrivelabel.Text = "Destination";
            // 
            // Timelebel
            // 
            this.Timelebel.AutoSize = true;
            this.Timelebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelebel.Location = new System.Drawing.Point(12, 319);
            this.Timelebel.Name = "Timelebel";
            this.Timelebel.Size = new System.Drawing.Size(201, 25);
            this.Timelebel.TabIndex = 5;
            this.Timelebel.Text = "Estimated Time of";
            // 
            // warninglabel1
            // 
            this.warninglabel1.AutoSize = true;
            this.warninglabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warninglabel1.ForeColor = System.Drawing.Color.Red;
            this.warninglabel1.Location = new System.Drawing.Point(157, 41);
            this.warninglabel1.Name = "warninglabel1";
            this.warninglabel1.Size = new System.Drawing.Size(73, 16);
            this.warninglabel1.TabIndex = 6;
            this.warninglabel1.Text = "Warning1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Arrival",
            "Departure"});
            this.comboBox1.Location = new System.Drawing.Point(17, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 182);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "12:00AM",
            "12:30AM",
            "1:00AM",
            "1:30AM",
            "2:00AM",
            "2:30AM",
            "3:00AM",
            "3:30AM",
            "4:00AM",
            "4:30AM",
            "5:00AM",
            "5:30AM",
            "6:00AM",
            "6:30AM",
            "7:00AM",
            "7:30AM",
            "8:00AM",
            "8:30AM",
            "9:00AM",
            "9:30AM",
            "10:00AM",
            "10:30AM",
            "11:00AM",
            "11:30AM",
            "12:00PM",
            "12:30PM",
            "1:00PM",
            "1:30PM",
            "2:00PM",
            "2:30PM",
            "3:00PM",
            "3:30PM",
            "4:00PM",
            "4:30PM",
            "5:00PM",
            "5:30PM",
            "6:00PM",
            "6:30PM",
            "7:00PM",
            "7:30PM",
            "8:00PM",
            "8:30PM",
            "9:00PM",
            "9:30PM",
            "10:00PM",
            "10:30PM",
            "11:00PM",
            "11:30PM"});
            this.comboBox3.Location = new System.Drawing.Point(21, 356);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(130, 21);
            this.comboBox3.TabIndex = 11;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1046, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add Plane Record";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // warninglabel2
            // 
            this.warninglabel2.AutoSize = true;
            this.warninglabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warninglabel2.ForeColor = System.Drawing.Color.Red;
            this.warninglabel2.Location = new System.Drawing.Point(157, 115);
            this.warninglabel2.Name = "warninglabel2";
            this.warninglabel2.Size = new System.Drawing.Size(73, 16);
            this.warninglabel2.TabIndex = 14;
            this.warninglabel2.Text = "Warning2";
            // 
            // warninglabel3
            // 
            this.warninglabel3.AutoSize = true;
            this.warninglabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warninglabel3.ForeColor = System.Drawing.Color.Red;
            this.warninglabel3.Location = new System.Drawing.Point(18, 205);
            this.warninglabel3.Name = "warninglabel3";
            this.warninglabel3.Size = new System.Drawing.Size(73, 16);
            this.warninglabel3.TabIndex = 15;
            this.warninglabel3.Text = "Warning3";
            // 
            // warninglabel4
            // 
            this.warninglabel4.AutoSize = true;
            this.warninglabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warninglabel4.ForeColor = System.Drawing.Color.Red;
            this.warninglabel4.Location = new System.Drawing.Point(157, 266);
            this.warninglabel4.Name = "warninglabel4";
            this.warninglabel4.Size = new System.Drawing.Size(73, 16);
            this.warninglabel4.TabIndex = 16;
            this.warninglabel4.Text = "Warning4";
            // 
            // warninglabel5
            // 
            this.warninglabel5.AutoSize = true;
            this.warninglabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warninglabel5.ForeColor = System.Drawing.Color.Red;
            this.warninglabel5.Location = new System.Drawing.Point(157, 357);
            this.warninglabel5.Name = "warninglabel5";
            this.warninglabel5.Size = new System.Drawing.Size(73, 16);
            this.warninglabel5.TabIndex = 17;
            this.warninglabel5.Text = "Warning5";
            // 
            // warninglabelmaster
            // 
            this.warninglabelmaster.AutoSize = true;
            this.warninglabelmaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warninglabelmaster.ForeColor = System.Drawing.Color.Red;
            this.warninglabelmaster.Location = new System.Drawing.Point(132, 470);
            this.warninglabelmaster.Name = "warninglabelmaster";
            this.warninglabelmaster.Size = new System.Drawing.Size(65, 16);
            this.warninglabelmaster.TabIndex = 18;
            this.warninglabelmaster.Text = "Warning";
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "Airport ID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(17, 266);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.ValueMember = "Airport ID";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planeIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.delayedDataGridViewTextBoxColumn1,
            this.dateOfDepartureDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.outgoingPlanesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(393, 266);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(569, 204);
            this.dataGridView2.TabIndex = 20;
            // 
            // myAirportDataSet
            // 
            this.myAirportDataSet.DataSetName = "MyAirportDataSet";
            this.myAirportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incomingPlanesBindingSource
            // 
            this.incomingPlanesBindingSource.DataMember = "IncomingPlanes";
            this.incomingPlanesBindingSource.DataSource = this.myAirportDataSet;
            // 
            // incomingPlanesTableAdapter
            // 
            this.incomingPlanesTableAdapter.ClearBeforeFill = true;
            // 
            // planeIDDataGridViewTextBoxColumn
            // 
            this.planeIDDataGridViewTextBoxColumn.DataPropertyName = "Plane ID";
            this.planeIDDataGridViewTextBoxColumn.HeaderText = "Plane ID";
            this.planeIDDataGridViewTextBoxColumn.Name = "planeIDDataGridViewTextBoxColumn";
            this.planeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delayedDataGridViewTextBoxColumn
            // 
            this.delayedDataGridViewTextBoxColumn.DataPropertyName = "Delayed";
            this.delayedDataGridViewTextBoxColumn.HeaderText = "Delayed";
            this.delayedDataGridViewTextBoxColumn.Name = "delayedDataGridViewTextBoxColumn";
            this.delayedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfArrivalDataGridViewTextBoxColumn
            // 
            this.dateOfArrivalDataGridViewTextBoxColumn.DataPropertyName = "Date of Arrival";
            this.dateOfArrivalDataGridViewTextBoxColumn.HeaderText = "Date of Arrival";
            this.dateOfArrivalDataGridViewTextBoxColumn.Name = "dateOfArrivalDataGridViewTextBoxColumn";
            this.dateOfArrivalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arrivingFromDataGridViewTextBoxColumn
            // 
            this.arrivingFromDataGridViewTextBoxColumn.DataPropertyName = "Arriving from";
            this.arrivingFromDataGridViewTextBoxColumn.HeaderText = "Arriving from";
            this.arrivingFromDataGridViewTextBoxColumn.Name = "arrivingFromDataGridViewTextBoxColumn";
            this.arrivingFromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // outgoingPlanesBindingSource
            // 
            this.outgoingPlanesBindingSource.DataMember = "OutgoingPlanes";
            this.outgoingPlanesBindingSource.DataSource = this.myAirportDataSet;
            // 
            // outgoingPlanesTableAdapter
            // 
            this.outgoingPlanesTableAdapter.ClearBeforeFill = true;
            // 
            // planeIDDataGridViewTextBoxColumn1
            // 
            this.planeIDDataGridViewTextBoxColumn1.DataPropertyName = "Plane ID";
            this.planeIDDataGridViewTextBoxColumn1.HeaderText = "Plane ID";
            this.planeIDDataGridViewTextBoxColumn1.Name = "planeIDDataGridViewTextBoxColumn1";
            this.planeIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // delayedDataGridViewTextBoxColumn1
            // 
            this.delayedDataGridViewTextBoxColumn1.DataPropertyName = "Delayed";
            this.delayedDataGridViewTextBoxColumn1.HeaderText = "Delayed";
            this.delayedDataGridViewTextBoxColumn1.Name = "delayedDataGridViewTextBoxColumn1";
            this.delayedDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateOfDepartureDataGridViewTextBoxColumn
            // 
            this.dateOfDepartureDataGridViewTextBoxColumn.DataPropertyName = "Date of Departure";
            this.dateOfDepartureDataGridViewTextBoxColumn.HeaderText = "Date of Departure";
            this.dateOfDepartureDataGridViewTextBoxColumn.Name = "dateOfDepartureDataGridViewTextBoxColumn";
            this.dateOfDepartureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PlanesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 508);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.warninglabelmaster);
            this.Controls.Add(this.warninglabel5);
            this.Controls.Add(this.warninglabel4);
            this.Controls.Add(this.warninglabel3);
            this.Controls.Add(this.warninglabel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.warninglabel1);
            this.Controls.Add(this.Timelebel);
            this.Controls.Add(this.destarrivelabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datetimelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PlanesForm";
            this.Text = "PlanesForm";
            this.Load += new System.EventHandler(this.PlanesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAirportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomingPlanesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outgoingPlanesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datetimelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label destarrivelabel;
        private System.Windows.Forms.Label Timelebel;
        private System.Windows.Forms.Label warninglabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label warninglabel2;
        private System.Windows.Forms.Label warninglabel3;
        private System.Windows.Forms.Label warninglabel4;
        private System.Windows.Forms.Label warninglabel5;
        private System.Windows.Forms.Label warninglabelmaster;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MyAirportDataSet myAirportDataSet;
        private System.Windows.Forms.BindingSource incomingPlanesBindingSource;
        private MyAirportDataSetTableAdapters.IncomingPlanesTableAdapter incomingPlanesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfArrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivingFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource outgoingPlanesBindingSource;
        private MyAirportDataSetTableAdapters.OutgoingPlanesTableAdapter outgoingPlanesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfDepartureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
    }
}