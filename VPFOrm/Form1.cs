using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPFOrm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_LogIn_Click(object sender, EventArgs e)
        {
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:7035/WeatherForecast");
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json"));
            //var result = await client.GetStringAsync("");
            //string mujahed = result.ToString();
            //label1.Text = mujahed;
           

            if(text_UserName.Text =="")
            {
                MessageBox.Show("Bless enter your name we need to know who we talk to");
                //label4.Text = "";
            }
            else if(text_Passowrd.Text=="")
            {
                MessageBox.Show("Bless enter your password to check if it's really you");
                //label4.Text = "";
            }
            else
            {
                string UserName = text_UserName.Text;
                label4.Text = "Thanks " + UserName + " We glad to have you with us";
            }

        }
    }
}
