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
    public partial class ProductPage : Form
    {
        public ProductPage(string name ,double cost)
        {
            InitializeComponent();
            lbl_Name.Text = name;
            lbl_Cost.Text = Convert.ToString(cost);
        }

    }
}
