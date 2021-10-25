using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitKatBro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Boolean turn;
        public int count;
        
        
        static void pushButton(Button b, bool turn, int count)
        {
            if (turn)
            {
                b.BackColor = Color.Pink;
                b.Text = "X";
            }
            else
            {
                b.BackColor = Color.LightBlue;
                b.Text = "O";
            }
            b.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pushButton((Button)sender, turn, count);
            turn = !turn;
            count++;
            check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pushButton((Button)sender, turn, count);
            turn = !turn;
            count++;
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pushButton((Button)sender, turn, count);
            turn = !turn;
            count++;
            check();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pushButton((Button)sender, turn, count);
            turn = !turn;
            count++;
            check();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pushButton((Button)sender, turn, count);
            turn = !turn;
            count++;
            check();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pushButton((Button)sender, turn, count);
            turn = !turn;
            count++;
            check();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pushButton((Button)sender, turn, count);
            turn = !turn;
            count++;
            check();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pushButton((Button)sender, turn, count);
            turn = !turn;
            count++;
            check();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pushButton((Button)sender, turn, count);
            turn = !turn;
            count++;
            check();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            startAgain();
        }
        
        public void check()
        {
            
            static Boolean checkWin(Button box1, Button box2, Button box3)
            {
                if ((box1.Text == box2.Text) && (box2.Text == box3.Text) && box1.Text != "")
                {
                    box1.BackColor = Color.Red;
                    box2.BackColor = Color.Red;
                    box3.BackColor = Color.Red;
                    MessageBox.Show(box1.Text + "s Win!!\r\n" + "Press okay to continue");
                    return true;
                }
                else return false;
            }
            
            if(count >= 5)
            {
                if (checkWin(button1, button2, button3)) startAgain();
                else if (checkWin(button4, button5, button6)) startAgain();
                else if (checkWin(button7, button8, button9)) startAgain();
                else if (checkWin(button1, button4, button7)) startAgain();
                else if (checkWin(button2, button5, button8)) startAgain();
                else if (checkWin(button3, button6, button9)) startAgain();
                else if (checkWin(button1, button5, button9)) startAgain();
                else if (checkWin(button3, button5, button7)) startAgain();

                if (count == 9)
                {
                    MessageBox.Show("Its a draw");
                    startAgain();
                }
            }
        }


        public void startAgain()
        {
            count = 0;
            foreach (Control b in Controls.OfType<Button>())
            {
                if(b != button10)
                {
                    b.BackColor = default;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
        }

        
    }
}
