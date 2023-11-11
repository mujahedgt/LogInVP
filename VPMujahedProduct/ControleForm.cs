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
    public partial class ControleForm : Form
    {
        Form1 Dad;
        public ControleForm()
        {
            InitializeComponent();
        }
        
        private void ControleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (f != null) f.Close();
        }

        private void btn_Serch_Click(object sender, EventArgs e)
        {
            SerchForm serchForm = new SerchForm();
            serchForm.Show();
            this.Hide();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
            this.Hide();
        }
    }
}
