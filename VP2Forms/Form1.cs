using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP2Forms
{
    public partial class Form1 : Form
    {
        string[] Product = {"Smartphone",
            "Laptop",
            "Coffee Maker",
            "Headphones",
            "Fitness Tracker",
            "Digital Camera",
            "Smartwatch",
            "Bluetooth Speaker",
            "Gaming Console",
            "E-book Reader",
            "Tablet",
            "Portable Charger",
            "Wireless Earbuds",
            "Robot Vacuum Cleaner",
            "3D Printer",
            "Drone",
            "Smart Thermostat",
            "Electric Toothbrush",
            "Fitness Apparel",
            "Sunglasses"};
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = txt_UserName.Text;
            string Pass = txt_Passowrd.Text;
            if(Name =="mujahed"&& Pass == "123")
            {
                lbl_cost.Show();
                lbl_Name.Show();
                button2.Show();
                cmx_Nam.Show();
                foreach(string s in Product)
                {
                    cmx_Nam.Items.Add(s);
                }
                txt_cost.Show();
                btn_LogOut.Show();
            }
            else
            {
                MessageBox.Show("Rong Name Or Password");
            }
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            txt_Passowrd.Text= string.Empty;
            txt_UserName.Text= string.Empty;
            lbl_cost.Hide();
            lbl_Name.Hide();
            button2.Hide();
            cmx_Nam.Hide();
            txt_cost.Hide();
            btn_LogOut.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Name = cmx_Nam.Text;
            double cost = 0;
            string ct = txt_cost.Text;
            if(double.TryParse(ct, out cost))
            {
                cost  = double.Parse(ct);
                if (Name == "" || cost == 0)
                {
                    MessageBox.Show("You dos not enterd a name or cost of broduct");


                }
                else
                {
                    ProductPage MyProduct = new ProductPage(Name, cost);
                    MyProduct.Show();
                }
            }
            else
            {
                MessageBox.Show("You enterd a nun double  value in cost");
            }

        }
    }
}
