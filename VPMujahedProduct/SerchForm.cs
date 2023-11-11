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
    public partial class SerchForm : Form
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
        public SerchForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string serch = textBox1.Text;
            foreach (string s in Product)
            {
                string lower = s.ToLower();
                if (lower.Contains(serch.ToLower()))
                {
                    listBox1.Items.Add(s);
                }
            }

        }

        private void SerchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ControleForm f = Application.OpenForms.OfType<ControleForm>().FirstOrDefault();
            if (f != null) f.Show();
        }
    }
}
