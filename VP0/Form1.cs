using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            for(int i =0; i<10; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Name = "txtntwxtbox";
                textBox.Text = "dynamic Text";
                textBox.Location = new Point(x, y);
                textBox.Size = new Size(100, 40);
                Controls.Add(textBox);
                //x++;
                y += 20;
            }
        }
    }
}
