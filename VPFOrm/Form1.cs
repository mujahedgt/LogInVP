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

        private async void button1_Click(object sender, EventArgs e)
        {
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:7035/WeatherForecast");
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json"));
            //var result = await client.GetStringAsync("");
            //string mujahed = result.ToString();
            //label1.Text = mujahed;

            if(textBox1.Text =="")
            {
                label4.Text = "Bless enter your name we need to know who we talk to";
            }
            else if(textBox2.Text=="")
            {
                label4.Text = "Bless enter your password to check if it's really you";
            }
            else
            {
                label4.Text = "Thanks " + textBox1.Text + " We glad to have you with us";
            }

        }
    }
}
