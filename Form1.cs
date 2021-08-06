using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        long currentServicePrice;
        long totalPrice;


        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontchange = new FontDialog();
            if (fontchange.ShowDialog() == DialogResult.OK &  !String.IsNullOrEmpty(richTextBox1.Text)) {

                richTextBox1.SelectionFont = fontchange.Font;
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            if (NoOpt.Checked)
            {
                if (Hairstyle.Checked)
                {
                    currentServicePrice = 60;
                    totalPrice = 245;
                }
                else if (MKover.Checked)
                {
                    currentServicePrice = 125;
                    totalPrice = 370;

                }
                else if (Manq.Checked)
                {
                    currentServicePrice = 35;
                    totalPrice = 405;
                }
                else if (Perm.Checked)
                {
                    currentServicePrice = 200;
                    totalPrice = 605;
                }
            }
            string currentp = currentServicePrice.ToString();
            string totalp = totalPrice.ToString();

            richTextBox1.AppendText(currentp);
            richTextBox2.AppendText(totalp);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}