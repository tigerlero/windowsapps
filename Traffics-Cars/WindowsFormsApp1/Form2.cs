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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int color1 = 0;
        int color2 = 0;
        public void change()
        {

            switch (color2)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.green;
                    pictureBox2.Image = Properties.Resources.red;
                    pictureBox5.Top = pictureBox5.Top - 13;
                    if (pictureBox4.Left > pictureBox2.Left)
                    { pictureBox2.Left = pictureBox2.Left + 13; }

                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.yellow;
                    pictureBox2.Image = Properties.Resources.red_yellow;
                    if (pictureBox4.Left < pictureBox2.Left) { pictureBox5.Top = pictureBox5.Top - 13; }
                    if (pictureBox4.Left > pictureBox2.Left)
                    { pictureBox4.Left = pictureBox4.Left + 13; }

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.red;
                    pictureBox2.Image = Properties.Resources.green;

                    pictureBox4.Left = pictureBox4.Left + 13;
                    if (pictureBox5.Top < pictureBox1.Left)
                    { pictureBox5.Top = pictureBox5.Top - 13; }

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.red_yellow;
                    pictureBox2.Image = Properties.Resources.yellow;
                    if (pictureBox5.Top < pictureBox1.Top)
                    {
                        pictureBox4.Left = pictureBox4.Left + 13;
                    }
                    break;
            }
            color1 = color1 + 1;
            if (color1 == 4)
            {
                color1 = 0;
            }
            color2 = color2 + 1;
            if (color2 == 4)
            {
                color2 = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            change();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            change();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int zero1, zero2, first1, first2, sec1, sec2;
            if (int.TryParse(textBox1.Text, out zero1) && (int.TryParse(textBox4.Text, out zero2)))
            {
                if ((color1 == 0) && (color2 == 0))
                {
                    timer1.Interval = zero1 * 1000;
                    timer2.Interval = zero2 * 1000;
                }
            }
            if (int.TryParse(textBox1.Text, out sec1) && (int.TryParse(textBox4.Text, out sec2)))
            {
                if ((color1 == 2) && (color2 == 2))
                {
                    timer1.Interval = sec1 * 1000;
                    timer2.Interval = sec2 * 1000;
                }
            }
            if (int.TryParse(textBox1.Text, out first1) && (int.TryParse(textBox4.Text, out first2)))
            {
                if ((color1 == 1) && (color2 == 1))
                {
                    timer1.Interval = first1 * 1000;
                    timer2.Interval = first2 * 1000;
                }
            }
            if (int.TryParse(textBox1.Text, out first1) && (int.TryParse(textBox4.Text, out first2)))
            {
                if ((color1 == 3) && (color2 == 3))
                {
                    timer1.Interval = first1 * 1000;
                    timer2.Interval = first2 * 1000;
                }
            }
            timer1.Start();
            timer2.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            change();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            change();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            change();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
