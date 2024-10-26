﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectWithForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = (textBox2.Enabled == false) ? true : false;
            textBox1.Visible = (textBox1.Visible == false) ? true : false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = (textBox1.BackColor == Color.Red) ? Color.White : Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Text = "MyForm"; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
