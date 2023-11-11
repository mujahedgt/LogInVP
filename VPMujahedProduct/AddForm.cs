using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPMujahedProduct
{
    public partial class AddForm : Form
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
        public AddForm()
        {
            InitializeComponent();
            foreach(string s in Product)
            {
                cmx_Nam.Items.Add(s);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string Name = cmx_Nam.Text;
            double cost = 0;
            string ct = txt_cost.Text;
            if (double.TryParse(ct, out cost))
            {
                cost = double.Parse(ct);
                if (Name == "" || cost == 0)
                {
                    MessageBox.Show("You dos not enterd a name or cost of broduct");


                }
                else
                {
                    MessageBox.Show("Product Added Sucsseccfuly");
                    cmx_Nam.Text = "";
                    txt_cost.Text = "";
                }
            }
            else
            {
                MessageBox.Show("You enterd a nun double  value in cost");
            }
        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ControleForm f = Application.OpenForms.OfType<ControleForm>().FirstOrDefault();
            if (f != null) f.Show();
        }
    }
}
