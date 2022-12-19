using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17._12._2022_Ödev__Burçlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            int a = (DateTime.Now.Year - dateTimePicker1.Value.Year);
            TimeSpan b = DateTime.Now - dateTimePicker1.Value;
            textBox1.Text = $"{a}";
            textBox2.Text = b.Days.ToString();
            
            int gun = dateTimePicker1.Value.DayOfYear;

            if (gun < 51 && gun >= 20)
            {
                textBox3.Text = "kova";
            }
            else if (gun < 80 && gun >= 51)
            {
                textBox3.Text = "Balık";
            }
            else if (gun < 111 && gun >= 80)
            {
                textBox3.Text = "Koç";
            }
            else if (gun < 141 && gun >= 111)
            {
                textBox3.Text = "Boğa";
            }
            else if (gun < 173 && gun >= 141)
            {
                textBox3.Text = "İkizler";
            }
            else if (gun < 204 && gun >= 173)
            {
                textBox3.Text = "Yengeç";
            }
            else if (gun < 136 && gun >= 204)
            {
                textBox3.Text = "Aslan";
            }
            else if (gun < 267 && gun >= 136)
            {
                textBox3.Text = "Başak";
            }
            else if (gun < 297 && gun >= 267)
            {
                textBox3.Text = "Terazi";
            }
            else if (gun < 327 && gun >= 297)
            {
                textBox3.Text = "Akrep";
            }
            else if (gun < 356 && gun >= 327)
            {
                textBox3.Text = "Yay";
            }
            else if (gun < 20 || (gun > 356 && gun < 366))
            {
                textBox3.Text = "Oğlak";
            }


        }
    }
}
