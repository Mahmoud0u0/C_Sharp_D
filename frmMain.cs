using FirstProjectWithForms.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectWithForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnShowForm1_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            //frm.Show();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This The Message", "Title", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("You Prissed OK");
            }

            //MessageBox.Show("This The Message", "Title", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new frmPizza();

            frm.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //pictureBox1.Image = Resources.h;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //pictureBox1.Image = Resources.g;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //pictureBox1.Image = Resources.f;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile("C:\\Users\\97252\\Pictures\\oruProject\\logo.png");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = Resources.h;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Resources.g;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.Image = Resources.f;
            }
            else
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\97252\\Pictures\\oruProject\\logo.png");
            }
        }
    }
}
