using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        int color = 0;
        public void change()
        {
            switch (color)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.green;
                    pictureBox2.Left = pictureBox2.Left + 13;
                    pictureBox3.Left = pictureBox3.Left + 13;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.yellow;
                    pictureBox2.Left = pictureBox2.Left + 13;
                    pictureBox3.Left = pictureBox3.Left + 13;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.red;
                    if (pictureBox2.Left > pictureBox1.Left)
                    { pictureBox2.Left = pictureBox2.Left + 13; }
                    if (pictureBox3.Left > pictureBox1.Left)
                    { pictureBox3.Left = pictureBox3.Left + 13; }
                    break;
            }
            color = color + 1;
            if (color == 3)
            {
                color = 0;
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            change();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int zero;
            if (int.TryParse(textBox3.Text, out zero))
            {
                if (color == 0)
                {
                    timer1.Interval = zero * 1000;
                }
            }
            int first;
            if (int.TryParse(textBox3.Text, out first))
            {
                if (color == 1)
                {
                    timer1.Interval = first * 1000;
                }
            }
            int sec;
            if (int.TryParse(textBox3.Text, out sec))
            {
                if (color == 2)
                {
                    timer1.Interval = sec * 1000;
                }
            }
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            change();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            change();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
