using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;

namespace VPTetris
{
    public partial class Form1 : Form
    {
        private int Score = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Cheker(object sender, EventArgs e)
        {
            if(Score == 4)
            {
                MessageBox.Show("Congrats to finesh Tetris Game");
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if(btn1.Text == "")
            {
                btn1.Text = "2";
                btn2.Text = "3";
                btn3.Text = "4";
                btn4.Text = "5";
                Score += 1;
                Cheker(sender, e);
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if(btn6.Text == "")
            {
                btn6.Text = "7";
                btn7.Text = "8";
                btn8.Text = "9";
                btn9.Text = "10";
                Score += 1;
                Cheker(sender, e);
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if(btn11.Text == "")
            {
                btn11.Text = "12";
                btn12.Text = "13";
                Score += 1;
                Cheker(sender, e);
            }

        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if(btn14.Text == "")
            {
                btn14.Text = "15";
                btn15.Text = "16";
                Score += 1;
                Cheker(sender, e);
            }
        }
    }
}
