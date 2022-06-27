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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static int earn = 0;
        public static long cred = 999;
        public static int bet = 5;
        public static int bigbet = 15;
        public static int lost = 0;
        public static int won = 0;


        public static int e1 = 1;
        public static int e2 = 2;
        public static int e3 = 3;

        public static int counter = 0;
        DateTime start;
        public static class Util
        {
            private static Random rand;
            private static void Init()
            {
                if (rand == null) rand = new Random();
            }
            public static int Random(int min, int max)
            {
                Init();
                return rand.Next(min,max);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cred >= bet)
            {
                cred = cred - bet;
                lost = lost + bet;
                label6.Text = "Credits: " + cred.ToString();
                label5.Text = "Lost total: " + lost.ToString();
                timer1.Interval = 1000;
                timer1.Tick += new EventHandler(timer1_Tick);
                counter = 0;
                start = DateTime.Now;
                timer1.Start();
            }

            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            e1 = Util.Random(1, 5);
            e2 = Util.Random(1, 5);
            e3 = Util.Random(1, 5);

            this.pictureBox1.Load(e1.ToString() + ".png");
            this.pictureBox2.Load(e2.ToString() + ".png");
            this.pictureBox3.Load(e3.ToString() + ".png");
            if (counter++ >= 3000 || (DateTime.Now - start).TotalSeconds >= 3)
            {
                e1 = Util.Random(1, 5);
                e2 = Util.Random(1, 5);
                e3 = Util.Random(1, 5);

                this.pictureBox1.Load(e1.ToString() + ".png");
                this.pictureBox2.Load(e2.ToString() + ".png");
                this.pictureBox3.Load(e3.ToString() + ".png");

                earn = 0;

                if (e1 == 1 & e2 == 1 & e3 == 1) earn = 100;
                if (e1 == 2 & e2 == 2 & e3 == 2) earn = 30;
                if (e1 == 3 & e2 == 3 & e3 == 3) earn = 25;
                if (e1 == 4 & e2 == 4 & e3 == 4) earn = 15;

                won = won + earn;
                cred = cred + earn;
                label4.Text = "Earn: " + earn.ToString();
                label7.Text = "Won total: " + won.ToString();
                label6.Text = "Credits: " + cred.ToString();

                timer1.Stop();

            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {

            e1 = Util.Random(1, 5);
            e2 = Util.Random(1, 5);
            e3 = Util.Random(1, 5);

            this.pictureBox1.Load(e1.ToString() + ".png");
            this.pictureBox2.Load(e2.ToString() + ".png");
            this.pictureBox3.Load(e3.ToString() + ".png");
            if (counter++ >= 3000 || (DateTime.Now - start).TotalSeconds >= 3)
            {
                e1 = Util.Random(1, 5);
                e2 = Util.Random(1, 5);
                e3 = Util.Random(1, 5);

                this.pictureBox1.Load(e1.ToString() + ".png");
                this.pictureBox2.Load(e2.ToString() + ".png");
                this.pictureBox3.Load(e3.ToString() + ".png");

                earn = 0;

                if (e1 == 1 & e2 == 1 & e3 == 1) earn = 300;
                if (e1 == 2 & e2 == 2 & e3 == 2) earn = 50;
                if (e1 == 3 & e2 == 3 & e3 == 3) earn = 35;
                if (e1 == 4 & e2 == 4 & e3 == 4) earn = 25;

                won = won + earn;
                cred = cred + earn;
                label4.Text = "Earn: " + earn.ToString();
                label7.Text = "Won total: " + won.ToString();
                label6.Text = "Credits: " + cred.ToString();

                timer2.Stop();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cred >= bigbet)
            {
                cred = cred - bigbet;
                lost = lost + bigbet;
                label6.Text = "Credits: " + cred.ToString();
                label5.Text = "Lost total: " + lost.ToString();
                timer2.Interval = 1000;
                timer2.Tick += new EventHandler(timer2_Tick);
                counter = 0;
                start = DateTime.Now;
                timer2.Start();
            }
        }
    }
}
