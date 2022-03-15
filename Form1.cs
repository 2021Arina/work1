// 1 вариант. №1
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Text = "Красный";
            BackColor = Color.Red;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.Text = "Зелёный";
            BackColor = Color.Green;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button3.Text = "Синий";
            BackColor = Color.Blue;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4.Text = "Жёлтый";
            BackColor = Color.Yellow;
        }
    }
}
