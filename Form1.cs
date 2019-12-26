using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        int klikniec = 0;
        bool wygrana = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (klikniec < 9 && wygrana != true)
            {
                if (klikniec % 2 == 0 && button1.Text != "X")
                {
                    button1.Text = "O";
                    label1.Text = "Tura Gracza: X";
                    klikniec++;

                    if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                    if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                    if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                }
                if (klikniec % 2 == 1 && button1.Text != "O")
                {
                    button1.Text = "X";
                    label1.Text = "Tura Gracza: O";
                    klikniec++;

                    if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                    if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                    if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                }

                if (klikniec == 9 && wygrana == false)
                {
                    label1.Text = "        Remis";
                    button10.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (klikniec < 9 && wygrana != true)
            {
                if (klikniec % 2 == 0 && button2.Text != "X")
                {
                    button2.Text = "O";
                    label1.Text = "Tura Gracza: X";
                    klikniec++;

                    if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                    if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                }
                if (klikniec % 2 == 1 && button2.Text != "O")
                {
                    button2.Text = "X";
                    label1.Text = "Tura Gracza: O";
                    klikniec++;

                    if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                    if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                }

                if (klikniec == 9 && wygrana == false)
                {
                    label1.Text = "        Remis";
                    button10.Visible = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (klikniec < 9 && wygrana != true)
            {
                if (klikniec % 2 == 0 && button3.Text != "X")
                {
                    button3.Text = "O";
                    label1.Text = "Tura Gracza: X";
                    klikniec++;

                    if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                    if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                    if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                }
                if (klikniec % 2 == 1 && button3.Text != "O")
                {
                    button3.Text = "X";
                    label1.Text = "Tura Gracza: O";
                    klikniec++;

                    if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                    if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                    if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                }

                if (klikniec == 9 && wygrana == false)
                {
                    label1.Text = "        Remis";
                    button10.Visible = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (klikniec < 9 && wygrana != true)
            {
                if (klikniec % 2 == 0 && button4.Text != "X")
                {
                    button4.Text = "O";
                    label1.Text = "Tura Gracza: X";
                    klikniec++;

                    if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                    if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                }
                if (klikniec % 2 == 1 && button4.Text != "O")
                {
                    button4.Text = "X";
                    label1.Text = "Tura Gracza: O";
                    klikniec++;

                    if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                    if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                }

                if (klikniec == 9 && wygrana == false)
                {
                    label1.Text = "        Remis";
                    button10.Visible = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (klikniec < 9 && wygrana != true)
            {
                if (klikniec % 2 == 0 && button5.Text != "X")
                {
                    button5.Text = "O";
                    label1.Text = "Tura Gracza: X";
                    klikniec++;

                    if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                    if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                    if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                }
                if (klikniec % 2 == 1 && button5.Text != "O")
                {
                    button5.Text = "X";
                    label1.Text = "Tura Gracza: O";
                    klikniec++;

                    if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                    if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                    if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                }

                if (klikniec == 9 && wygrana == false)
                {
                    label1.Text = "        Remis";
                    button10.Visible = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (klikniec < 9 && wygrana != true)
            {
                if (klikniec % 2 == 0 && button6.Text != "X")
                {
                    button6.Text = "O";
                    label1.Text = "Tura Gracza: X";
                    klikniec++;

                    if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                    if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                }
                if (klikniec % 2 == 1 && button6.Text != "O")
                {
                    button6.Text = "X";
                    label1.Text = "Tura Gracza: O";
                    klikniec++;

                    if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                    if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                }

                if (klikniec == 9 && wygrana == false)
                {
                    label1.Text = "        Remis";
                    button10.Visible = true;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (klikniec < 9 && wygrana != true)
            {
                if (klikniec % 2 == 0 && button7.Text != "X")
                {
                    button7.Text = "O";
                    label1.Text = "Tura Gracza: X";
                    klikniec++;

                    if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                    if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                    if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                }
                if (klikniec % 2 == 1 && button7.Text != "O")
                {
                    button7.Text = "X";
                    label1.Text = "Tura Gracza: O";
                    klikniec++;

                    if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                    if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                    if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                }

                if (klikniec == 9 && wygrana == false)
                {
                    label1.Text = "        Remis";
                    button10.Visible = true;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (klikniec < 9 && wygrana != true)
            {
                if (klikniec % 2 == 0 && button8.Text != "X")
                {
                    button8.Text = "O";
                    label1.Text = "Tura Gracza: X";
                    klikniec++;

                    if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                    if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                }
                if (klikniec % 2 == 1 && button8.Text != "O")
                {
                    button8.Text = "X";
                    label1.Text = "Tura Gracza: O";
                    klikniec++;

                    if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                    if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                }

                if (klikniec == 9 && wygrana == false)
                {
                    label1.Text = "        Remis";
                    button10.Visible = true;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(klikniec < 9 && wygrana != true)
            {
                if (klikniec % 2 == 0 && button9.Text != "X")
                {
                    button9.Text = "O";
                    label1.Text = "Tura Gracza: X";
                    klikniec++;

                    if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                    if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                    if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: O";
                    }
                }
                if (klikniec % 2 == 1 && button9.Text != "O")
                {
                    button9.Text = "X";
                    label1.Text = "Tura Gracza: O";
                    klikniec++;

                    if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                    if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                    if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                    {
                        wygrana = true;
                        button10.Visible = true;
                        label1.Text = "Wygrał Gracz: X";
                    }
                }

                if (klikniec == 9 && wygrana == false)
                {
                    label1.Text = "        Remis";
                    button10.Visible = true;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            klikniec = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            label1.Text = "Tura Gracza: O";
            wygrana = false;
            button10.Visible = false;
        }
    }
}
