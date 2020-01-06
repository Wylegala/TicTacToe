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

        Gracze Gracze1 = new Gracze();

        public TicTacToe()
        {
            InitializeComponent();

            Gracze1.LosujGraczy(label1);
        }

        MistrzGry Mistrz1 = new MistrzGry();

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "" && Mistrz1.wygrana != true)
            {
                button1.Text = Gracze1.tura;
                Mistrz1.KoniecTury(button1, button2, button3, button4, button5, button6, button7, button8, button9);

                if (Mistrz1.wygrana == true)
                {
                    label1.Text = "Wygrana!";
                }
                else
                {
                    Gracze1.NastepnyGracz(label1);
                    label1.Text = "Tura Gracza: " + Gracze1.tura;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "" && Mistrz1.wygrana != true)
            {
                button2.Text = Gracze1.tura;
                Mistrz1.KoniecTury(button1, button2, button3, button4, button5, button6, button7, button8, button9);

                if (Mistrz1.wygrana == true)
                {
                    label1.Text = "Wygrana!";
                }
                else
                {
                    Gracze1.NastepnyGracz(label1);
                    label1.Text = "Tura Gracza: " + Gracze1.tura;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "" && Mistrz1.wygrana != true)
            {
                button3.Text = Gracze1.tura;
                Mistrz1.KoniecTury(button1, button2, button3, button4, button5, button6, button7, button8, button9);

                if (Mistrz1.wygrana == true)
                {
                    label1.Text = "Wygrana!";
                }
                else
                {
                    Gracze1.NastepnyGracz(label1);
                    label1.Text = "Tura Gracza: " + Gracze1.tura;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "" && Mistrz1.wygrana != true)
            {
                button4.Text = Gracze1.tura;
                Mistrz1.KoniecTury(button1, button2, button3, button4, button5, button6, button7, button8, button9);

                if (Mistrz1.wygrana == true)
                {
                    label1.Text = "Wygrana!";
                }
                else
                {
                    Gracze1.NastepnyGracz(label1);
                    label1.Text = "Tura Gracza: " + Gracze1.tura;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "" && Mistrz1.wygrana != true)
            {
                button5.Text = Gracze1.tura;
                Mistrz1.KoniecTury(button1, button2, button3, button4, button5, button6, button7, button8, button9);

                if (Mistrz1.wygrana == true)
                {
                    label1.Text = "Wygrana!";
                }
                else
                {
                    Gracze1.NastepnyGracz(label1);
                    label1.Text = "Tura Gracza: " + Gracze1.tura;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "" && Mistrz1.wygrana != true)
            {
                button6.Text = Gracze1.tura;
                Mistrz1.KoniecTury(button1, button2, button3, button4, button5, button6, button7, button8, button9);

                if (Mistrz1.wygrana == true)
                {
                    label1.Text = "Wygrana!";
                }
                else
                {
                    Gracze1.NastepnyGracz(label1);
                    label1.Text = "Tura Gracza: " + Gracze1.tura;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "" && Mistrz1.wygrana != true)
            {
                button7.Text = Gracze1.tura;
                Mistrz1.KoniecTury(button1, button2, button3, button4, button5, button6, button7, button8, button9);

                if (Mistrz1.wygrana == true)
                {
                    label1.Text = "Wygrana!";
                }
                else
                {
                    Gracze1.NastepnyGracz(label1);
                    label1.Text = "Tura Gracza: " + Gracze1.tura;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "" && Mistrz1.wygrana != true)
            {
                button8.Text = Gracze1.tura;
                Mistrz1.KoniecTury(button1, button2, button3, button4, button5, button6, button7, button8, button9);

                if (Mistrz1.wygrana == true)
                {
                    label1.Text = "Wygrana!";
                }
                else
                {
                    Gracze1.NastepnyGracz(label1);
                    label1.Text = "Tura Gracza: " + Gracze1.tura;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "" && Mistrz1.wygrana != true)
            {
                button9.Text = Gracze1.tura;
                Mistrz1.KoniecTury(button1, button2, button3, button4, button5, button6, button7, button8, button9);

                if (Mistrz1.wygrana == true)
                {
                    label1.Text = "Wygrana!";
                }
                else
                {
                    Gracze1.NastepnyGracz(label1);
                    label1.Text = "Tura Gracza: " + Gracze1.tura;
                }
            }
        }

        // Implemetacja przycisku nowej gry
        private void button10_Click(object sender, EventArgs e)
        {
            
        }
    }
}
