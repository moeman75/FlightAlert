﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightAlert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //weatherCheckButton
        private void button1_Click(object sender, EventArgs e)
        {
            weather form = new weather();
            form.Show();
        }

        private void PlaneButton_Click(object sender, EventArgs e)
        {
            PlanesForm form = new PlanesForm();
            form.Show();
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
