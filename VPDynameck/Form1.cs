using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPDynameck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string result = comboBox1.Text;
            if(result == "ComboBox")
            {
                panel1.Controls.Clear();

                for (int i = 0; i < 3; i++)
                {
                    ComboBox comboBox = new ComboBox();
                    comboBox.Name = "ComboBox"+i.ToString();
                    comboBox.Text = "ComboBox"+i.ToString();
                    comboBox.Size = new Size(100, 21);
                    comboBox.Location = new Point(i * 110, 0);
                    panel1.Controls.Add(comboBox);
                }
            }
            else if(result == "Button")
            {
                panel1.Controls.Clear();

                for (int i = 0; i < 3; i++)
                {
                    Button button = new Button();
                    button.Name = "ComboBox" + i.ToString();
                    button.Text = "ComboBox" + i.ToString();
                    button.Size = new Size(100, 21);
                    button.Location = new Point(i * 110, 0);
                    panel1.Controls.Add(button);
                }
            }
            else if(result == "TextBox")
            {
                panel1.Controls.Clear();


                for (int i = 0; i < 3; i++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Name = "ComboBox" + i.ToString();
                    textBox.Text = "ComboBox" + i.ToString();
                    textBox.Size = new Size(100, 21);
                    textBox.Location = new Point(i * 110, 0);
                    panel1.Controls.Add(textBox);
                }
            }
        }
    }
}
