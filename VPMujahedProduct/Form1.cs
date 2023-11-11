using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPMujahedProduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            string n = "Mujahed";
            string p = "123";

            if (txt_Name.Text == "")
            {
                MessageBox.Show("Enter User Name Pleas");
            }
            else if (txt_Password.Text == "")
            {
                MessageBox.Show("Enter Password Pleas");
            }
            else
            { 
                if(txt_Name.Text ==n&&txt_Password.Text ==p)
                {
                    ControleForm controleForm = new ControleForm();
                    controleForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You have enterd a wrong pass or neme");
                }
            }
        }
    }
}
