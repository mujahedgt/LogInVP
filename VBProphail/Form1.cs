using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VBProphail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Switch_Click(object sender, EventArgs e)
        {
            string swit = text_First.Text;
            text_First.Text = text_Last.Text;
            text_Last.Text = swit;
        }

        private void text_First_TextChanged(object sender, EventArgs e)
        {
            String mj = text_First.Text;
            int conter = 0;

            for(int i = 0; i < mj.Length; i++)
            {
                if (mj[i] == ' ' || mj[i] == ',' || mj[i] == '\'' || mj[i]=='.') {
                    conter++;
                }
            }
            txtCont2.Text = conter.ToString();
            txtCont.Text = text_First.Text.Length.ToString();
        }
    }
}
