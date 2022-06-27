using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Tic_Tac_Toe_5
{

    public partial class Form1 : Form
    {
        public static int player = 1;
        public static int player1_wins = 0;
        public static int player2_wins = 0;
        public static int ties = 0;
        public static int p = 0;
        public static int pc = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (b7.Text == "" & player == 1) { b7.Text = "X"; }
            if (b7.Text == "" & player == 2) { b7.Text = "O"; }
            if (player == 1) player = 2;
            else if (player == 2) player = 1;
            win();
        }


        private void b1_Click(object sender, EventArgs e)
        {
            if (b1.Text == "" & player == 1) { b1.Text = "X"; }
            if (b1.Text == "" & player == 2) { b1.Text = "O"; }
            if (player == 1) player = 2;
            else if (player == 2) player = 1;
            win();
        }


        private void win()
        {
            if (player == 1 | player == 2)
            {


                //orizontia
                if (b1.Text == "X" & b2.Text == "X" & b3.Text == "X" & b4.Text == "X" & b5.Text == "X")
                {
                    p = 1;
                }
                if (b6.Text == "X" & b7.Text == "X" & b8.Text == "X" & b9.Text == "X" & b10.Text == "X")
                {
                    p = 1;
                }
                if (b11.Text == "X" & b12.Text == "X" & b13.Text == "X" & b14.Text == "X" & b15.Text == "X")
                {
                    p = 1;
                }
                if (b16.Text == "X" & b17.Text == "X" & b18.Text == "X" & b19.Text == "X" & b20.Text == "X")
                {
                    p = 1;
                }
                if (b21.Text == "X" & b22.Text == "X" & b23.Text == "X" & b24.Text == "X" & b25.Text == "X")
                {
                    p = 1;
                }


                if (b1.Text == "O" & b2.Text == "O" & b3.Text == "O" & b4.Text == "O" & b5.Text == "O")
                {
                    p = 2;
                }
                if (b6.Text == "O" & b7.Text == "O" & b8.Text == "O" & b9.Text == "O" & b10.Text == "O")
                {
                    p = 2;
                }
                if (b11.Text == "O" & b12.Text == "O" & b13.Text == "O" & b14.Text == "O" & b15.Text == "O")
                {
                    p = 2;
                }
                if (b16.Text == "O" & b17.Text == "O" & b18.Text == "O" & b19.Text == "O" & b20.Text == "O")
                {
                    p = 2;
                }
                if (b21.Text == "O" & b22.Text == "O" & b23.Text == "O" & b24.Text == "O" & b25.Text == "O")
                {
                    p = 2;
                }


                //diagwnia
                if (b25.Text == "O" & b19.Text == "O" & b13.Text == "O" & b7.Text == "O" & b1.Text == "O")
                {
                    p = 2;
                }


                if (b1.Text == "X" & b7.Text == "X" & b13.Text == "X" & b19.Text == "X" & b25.Text == "X")
                {
                    p = 1;
                }


                //KATHETA
                if (b1.Text == "X" & b6.Text == "X" & b11.Text == "X" & b16.Text == "X" & b21.Text == "X")
                {
                    p = 1;
                }
                if (b2.Text == "X" & b7.Text == "X" & b12.Text == "X" & b17.Text == "X" & b25.Text == "X")
                {
                    p = 1;
                }
                if (b3.Text == "X" & b8.Text == "X" & b13.Text == "X" & b18.Text == "X" & b23.Text == "X")
                {
                    p = 1;
                }
                if (b4.Text == "X" & b9.Text == "X" & b14.Text == "X" & b19.Text == "X" & b24.Text == "X")
                {
                    p = 1;
                }
                if (b5.Text == "X" & b10.Text == "X" & b15.Text == "X" & b20.Text == "X" & b25.Text == "X")
                {
                    p = 1;
                }



                if (b1.Text == "O" & b6.Text == "0" & b11.Text == "O" & b16.Text == "O" & b21.Text == "O")
                {
                    p = 2;
                }
                if (b2.Text == "O" & b7.Text == "O" & b12.Text == "O" & b17.Text == "O" & b25.Text == "O")
                {
                    p = 2;
                }
                if (b3.Text == "O" & b8.Text == "O" & b13.Text == "O" & b18.Text == "O" & b23.Text == "O")
                {
                    p = 2;
                }
                if (b4.Text == "O" & b9.Text == "O" & b14.Text == "O" & b19.Text == "O" & b24.Text == "O")
                {
                    p = 2;
                }
                if (b5.Text == "O" & b10.Text == "O" & b15.Text == "O" & b20.Text == "O" & b25.Text == "O")
                {
                    p = 2;
                }


                //tie
                if (b1.Text != "" & b2.Text != "" & b3.Text != "" & b4.Text != "" & b5.Text != "" & b6.Text != "" & b7.Text != "" & b8.Text != "" & b1.Text != "" & b9.Text != "" & b10.Text != "" & b11.Text != "" & b12.Text != "" & b13.Text != "" & b14.Text != "" & b15.Text != "" & b16.Text != "" & b17.Text != "" & b18.Text != "" & b19.Text != "" & b20.Text != "" & b21.Text != "" & b22.Text != "" & b23.Text != "" & b24.Text != "" & b25.Text != "") p = 3;

            }



            //decide winner
            if (p == 1)
            {
                label4.Text = "Player Win: Player 1";
                label5.Text = "Player Lost: Player 2";
                player1_wins = player1_wins + 1;
                label1.Text = "Players1 Wins:" + player1_wins.ToString();
                p = 0;
                player = 3;
            }
            if (p == 2)
            {
                label4.Text = "Player Win: Player 2";
                label5.Text = "Player Lost: Player 1";
                player2_wins = player2_wins + 1;
                label2.Text = "Players2 Wins:" + player2_wins.ToString();
                p = 0;
                player = 3;
            }
            if (p == 3)
            {
                ties = ties + 1;
                label3.Text = ties.ToString();
                label4.Text = "Player Win: Tie";
                label5.Text = "Player Lost: Tie";
                label3.Text = "Ties:" + ties.ToString();
                p = 0;
                player = 3;
                
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
{

}

private void Reset_Button_Click(object sender, EventArgs e)
{
    p = 0;
    player = 1;
    b1.Text = "";
    b2.Text = "";
    b3.Text = "";
    b4.Text = "";
    b5.Text = "";
    b6.Text = "";
    b7.Text = "";
    b8.Text = "";
    b9.Text = "";
    b10.Text = "";
    b11.Text = "";
    b12.Text = "";
    b13.Text = "";
    b14.Text = "";
    b15.Text = "";
    b16.Text = "";
    b17.Text = "";
    b18.Text = "";
    b19.Text = "";
    b20.Text = "";
    b21.Text = "";
    b22.Text = "";
    b23.Text = "";
    b24.Text = "";
    b25.Text = "";
}

private void button1_Click(object sender, EventArgs e)
{
    p = 0;
    player = 2;
    b1.Text = "";
    b2.Text = "";
    b3.Text = "";
    b4.Text = "";
    b5.Text = "";
    b6.Text = "";
    b7.Text = "";
    b8.Text = "";
    b9.Text = "";
    b10.Text = "";
    b11.Text = "";
    b12.Text = "";
    b13.Text = "";
    b14.Text = "";
    b15.Text = "";
    b16.Text = "";
    b17.Text = "";
    b18.Text = "";
    b19.Text = "";
    b20.Text = "";
    b21.Text = "";
    b22.Text = "";
    b23.Text = "";
    b24.Text = "";
    b25.Text = "";
}

private void b18_Click(object sender, EventArgs e)
{
    if (b18.Text == "" & player == 1) { b18.Text = "X"; }
    if (b18.Text == "" & player == 2) { b18.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}

private void b2_Click(object sender, EventArgs e)
{
    if (b2.Text == "" & player == 1) { b2.Text = "X"; }
    if (b2.Text == "" & player == 2) { b2.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}

private void b3_Click(object sender, EventArgs e)
{
    if (b3.Text == "" & player == 1) { b3.Text = "X"; }
    if (b3.Text == "" & player == 2) { b3.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}

private void b4_Click(object sender, EventArgs e)
{
    if (b4.Text == "" & player == 1) { b4.Text = "X"; }
    if (b4.Text == "" & player == 2) { b4.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}

private void b5_Click(object sender, EventArgs e)
{
    if (b5.Text == "" & player == 1) { b5.Text = "X"; }
    if (b5.Text == "" & player == 2) { b5.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}


private void b6_Click(object sender, EventArgs e)
{
    if (b6.Text == "" & player == 1) { b6.Text = "X"; }
    if (b6.Text == "" & player == 2) { b6.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}

private void b8_Click(object sender, EventArgs e)
{
    if (b8.Text == "" & player == 1) { b8.Text = "X"; }
    if (b8.Text == "" & player == 2) { b8.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}

private void b9_Click(object sender, EventArgs e)
{
    if (b9.Text == "" & player == 1) { b9.Text = "X"; }
    if (b9.Text == "" & player == 2) { b9.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}

private void b10_Click(object sender, EventArgs e)
{
    if (b10.Text == "" & player == 1) { b10.Text = "X"; }
    if (b10.Text == "" & player == 2) { b10.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}

private void b11_Click(object sender, EventArgs e)
{
    if (b11.Text == "" & player == 1) { b11.Text = "X"; }
    if (b11.Text == "" & player == 2) { b11.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}

private void b12_Click(object sender, EventArgs e)
{
    if (b12.Text == "" & player == 1) { b12.Text = "X"; }
    if (b12.Text == "" & player == 2) { b12.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}

private void b13_Click(object sender, EventArgs e)
{
    if (b13.Text == "" & player == 1) { b13.Text = "X"; }
    if (b13.Text == "" & player == 2) { b13.Text = "O"; }
    if (player == 1) { player = 2; }
    else if (player == 2) player = 1;
    win();
}

private void b14_Click(object sender, EventArgs e)
{
    if (b14.Text == "" & player == 1) { b14.Text = "X"; }
    if (b14.Text == "" & player == 2) { b14.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}

private void b15_Click(object sender, EventArgs e)
{
    if (b15.Text == "" & player == 1) { b15.Text = "X"; }
    if (b15.Text == "" & player == 2) { b15.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    if (p != 1 | p != 2 | p != 3) win();
}

private void b16_Click(object sender, EventArgs e)
{
    if (b16.Text == "" & player == 1) { b16.Text = "X"; }
    if (b16.Text == "" & player == 2) { b16.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}

private void b17_Click(object sender, EventArgs e)
{
    if (b17.Text == "" & player == 1) { b17.Text = "X"; }
    if (b17.Text == "" & player == 2) { b17.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}

private void b19_Click(object sender, EventArgs e)
{
    if (b19.Text == "" & player == 1) { b19.Text = "X"; }
    if (b19.Text == "" & player == 2) { b19.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}

private void b20_Click(object sender, EventArgs e)
{
    if (b20.Text == "" & player == 1) { b20.Text = "X"; }
    if (b20.Text == "" & player == 2) { b20.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}

private void b21_Click(object sender, EventArgs e)
{
    if (b21.Text == "" & player == 1) { b21.Text = "X"; }
    if (b21.Text == "" & player == 2) { b21.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}

private void b22_Click(object sender, EventArgs e)
{
    if (b22.Text == "" & player == 1) { b22.Text = "X"; }
    if (b22.Text == "" & player == 2) { b22.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}

private void b23_Click(object sender, EventArgs e)
{
    if (b23.Text == "" & player == 1) { b23.Text = "X"; }
    if (b23.Text == "" & player == 2) { b23.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}

private void b24_Click(object sender, EventArgs e)
{
    if (b24.Text == "" & player == 1) { b24.Text = "X"; }
    if (b24.Text == "" & player == 2) { b24.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}

private void b25_Click(object sender, EventArgs e)
{
    if (b25.Text == "" & player == 1) { b25.Text = "X"; }
    if (b25.Text == "" & player == 2) { b25.Text = "O"; }
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
    win();
}
private void versus_pc()
{
    pc = 1;

    
        if (p != 0)
        {
            timer1.Stop();
        }
    

    if (player == 2 & pc == 1)
    {
        var rnd = new Random();
        int a = rnd.Next(1, 26);
        if (this.Controls["b" + a].Text == "")
        {
            this.Controls["b" + a].Text = "O";
            
            if (player == 2) player = 1;
                    win();
                }
        
    }

}

private void button2_Click(object sender, EventArgs e)
{
    timer1.Start();
}

private void timer1_Tick(object sender, EventArgs e)
{
    versus_pc();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pc = 0;
            p = 0;
            player = 1;
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b5.Text = "";
            b6.Text = "";
            b7.Text = "";
            b8.Text = "";
            b9.Text = "";
            b10.Text = "";
            b11.Text = "";
            b12.Text = "";
            b13.Text = "";
            b14.Text = "";
            b15.Text = "";
            b16.Text = "";
            b17.Text = "";
            b18.Text = "";
            b19.Text = "";
            b20.Text = "";
            b21.Text = "";
            b22.Text = "";
            b23.Text = "";
            b24.Text = "";
            b25.Text = "";
        }
    }
}
