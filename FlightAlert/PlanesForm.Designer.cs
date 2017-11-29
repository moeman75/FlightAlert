namespace FlightAlert
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
            this.airportDataSet = new FlightAlert.AirportDataSet();
            this.planeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planeTableAdapter = new FlightAlert.AirportDataSetTableAdapters.PlaneTableAdapter();
            this.airportDataSet1 = new FlightAlert.AirportDataSet1();
            this.airportDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.planeTableAdapter1 = new FlightAlert.AirportDataSet1TableAdapters.PlaneTableAdapter();
            this.planeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivingFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depatureDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.datetimelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.destarrivelabel = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.warninglabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeBindingSource1)).BeginInit();
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
            this.destinationDataGridViewTextBoxColumn,
            this.arrivingFromDataGridViewTextBoxColumn,
            this.arrivalDateTimeDataGridViewTextBoxColumn,
            this.depatureDateTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.planeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(393, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 155);
            this.dataGridView1.TabIndex = 0;
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planeBindingSource
            // 
            this.planeBindingSource.DataMember = "Plane";
            this.planeBindingSource.DataSource = this.airportDataSet;
            // 
            // planeTableAdapter
            // 
            this.planeTableAdapter.ClearBeforeFill = true;
            // 
            // airportDataSet1
            // 
            this.airportDataSet1.DataSetName = "AirportDataSet1";
            this.airportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airportDataSet1BindingSource
            // 
            this.airportDataSet1BindingSource.DataSource = this.airportDataSet1;
            this.airportDataSet1BindingSource.Position = 0;
            // 
            // planeBindingSource1
            // 
            this.planeBindingSource1.DataMember = "Plane";
            this.planeBindingSource1.DataSource = this.airportDataSet1BindingSource;
            // 
            // planeTableAdapter1
            // 
            this.planeTableAdapter1.ClearBeforeFill = true;
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
            // 
            // delayedDataGridViewTextBoxColumn
            // 
            this.delayedDataGridViewTextBoxColumn.DataPropertyName = "Delayed";
            this.delayedDataGridViewTextBoxColumn.HeaderText = "Delayed";
            this.delayedDataGridViewTextBoxColumn.Name = "delayedDataGridViewTextBoxColumn";
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // arrivingFromDataGridViewTextBoxColumn
            // 
            this.arrivingFromDataGridViewTextBoxColumn.DataPropertyName = "Arriving From";
            this.arrivingFromDataGridViewTextBoxColumn.HeaderText = "Arriving From";
            this.arrivingFromDataGridViewTextBoxColumn.Name = "arrivingFromDataGridViewTextBoxColumn";
            // 
            // arrivalDateTimeDataGridViewTextBoxColumn
            // 
            this.arrivalDateTimeDataGridViewTextBoxColumn.DataPropertyName = "Arrival DateTime";
            this.arrivalDateTimeDataGridViewTextBoxColumn.HeaderText = "Arrival DateTime";
            this.arrivalDateTimeDataGridViewTextBoxColumn.Name = "arrivalDateTimeDataGridViewTextBoxColumn";
            // 
            // depatureDateTimeDataGridViewTextBoxColumn
            // 
            this.depatureDateTimeDataGridViewTextBoxColumn.DataPropertyName = "Depature DateTime";
            this.depatureDateTimeDataGridViewTextBoxColumn.HeaderText = "Depature DateTime";
            this.depatureDateTimeDataGridViewTextBoxColumn.Name = "depatureDateTimeDataGridViewTextBoxColumn";
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
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(12, 319);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(76, 25);
            this.Time.TabIndex = 5;
            this.Time.Text = "label5";
            this.Time.Click += new System.EventHandler(this.label5_Click);
            // 
            // warninglabel
            // 
            this.warninglabel.AutoSize = true;
            this.warninglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warninglabel.ForeColor = System.Drawing.Color.Red;
            this.warninglabel.Location = new System.Drawing.Point(328, 234);
            this.warninglabel.Name = "warninglabel";
            this.warninglabel.Size = new System.Drawing.Size(99, 25);
            this.warninglabel.TabIndex = 6;
            this.warninglabel.Text = "Warning";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 7;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 262);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 20);
            this.textBox2.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
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
            this.comboBox2.Location = new System.Drawing.Point(21, 356);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // PlanesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 508);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.warninglabel);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.destarrivelabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datetimelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PlanesForm";
            this.Text = "PlanesForm";
            this.Load += new System.EventHandler(this.PlanesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource planeBindingSource;
        private AirportDataSetTableAdapters.PlaneTableAdapter planeTableAdapter;
        private System.Windows.Forms.BindingSource airportDataSet1BindingSource;
        private AirportDataSet1 airportDataSet1;
        private System.Windows.Forms.BindingSource planeBindingSource1;
        private AirportDataSet1TableAdapters.PlaneTableAdapter planeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivingFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depatureDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datetimelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label destarrivelabel;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label warninglabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}