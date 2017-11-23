using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "9";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "+";
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "-";
        }

        private void btntimes_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "*";
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "/";
        }

        private void btnmodulo_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "%";
        }
    }
}
