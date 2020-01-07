using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class MistrzGry
    {
        public bool wygrana;
        public bool remis;
        public char zwyciezca;
        public int wygraneX;
        public int wygraneO;
        public int ruchy;

        public MistrzGry()
        {
            this.wygrana = false;
            this.remis = false;
            this.wygraneO = 0;
            this.wygraneX = 0;
            this.ruchy = 0;
            this.zwyciezca = ' ';
        }

        public void CzyWygrana(Button Pole1, Button Pole2, Button Pole3,
                               Button Pole4, Button Pole5, Button Pole6,
                               Button Pole7, Button Pole8, Button Pole9,
                               Button PrzyciskNowaGra, Gracze gracze, Label GlownyTekst, Label LabelSumaWygrO, Label LabelSumaWygrX)
        {
            // Poziome
            if (Pole1.Text == "X" && Pole2.Text == "X" && Pole3.Text == "X" && this.wygrana != true)
            {
                this.zwyciezca = 'X';
                this.wygrana = true;
                
                Pole1.BackColor = System.Drawing.Color.LightGreen;
                Pole2.BackColor = System.Drawing.Color.LightGreen;
                Pole3.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole1.Text == "O" && Pole2.Text == "O" && Pole3.Text == "O" && this.wygrana != true)
            {
                this.zwyciezca = 'O';
                this.wygrana = true;

                Pole1.BackColor = System.Drawing.Color.LightGreen;
                Pole2.BackColor = System.Drawing.Color.LightGreen;
                Pole3.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole4.Text == "X" && Pole5.Text == "X" && Pole6.Text == "X" && this.wygrana != true)
            {
                this.zwyciezca = 'X';
                this.wygrana = true;

                Pole4.BackColor = System.Drawing.Color.LightGreen;
                Pole5.BackColor = System.Drawing.Color.LightGreen;
                Pole6.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole4.Text == "O" && Pole5.Text == "O" && Pole6.Text == "O" && this.wygrana != true)
            {
                this.zwyciezca = 'O';
                this.wygrana = true;

                Pole4.BackColor = System.Drawing.Color.LightGreen;
                Pole5.BackColor = System.Drawing.Color.LightGreen;
                Pole6.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole7.Text == "X" && Pole8.Text == "X" && Pole9.Text == "X" && this.wygrana != true)
            {
                this.zwyciezca = 'X';
                this.wygrana = true;

                Pole7.BackColor = System.Drawing.Color.LightGreen;
                Pole8.BackColor = System.Drawing.Color.LightGreen;
                Pole9.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole7.Text == "O" && Pole8.Text == "O" && Pole9.Text == "O" && this.wygrana != true)
            {
                this.zwyciezca = 'O';
                this.wygrana = true;

                Pole7.BackColor = System.Drawing.Color.LightGreen;
                Pole8.BackColor = System.Drawing.Color.LightGreen;
                Pole9.BackColor = System.Drawing.Color.LightGreen;
            }

            // Pionowe
            if (Pole1.Text == "X" && Pole4.Text == "X" && Pole7.Text == "X" && this.wygrana != true)
            {
                this.zwyciezca = 'X';
                this.wygrana = true;

                Pole1.BackColor = System.Drawing.Color.LightGreen;
                Pole4.BackColor = System.Drawing.Color.LightGreen;
                Pole7.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole1.Text == "O" && Pole4.Text == "O" && Pole7.Text == "O" && this.wygrana != true)
            {
                this.zwyciezca = 'O';
                this.wygrana = true;

                Pole1.BackColor = System.Drawing.Color.LightGreen;
                Pole4.BackColor = System.Drawing.Color.LightGreen;
                Pole7.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole2.Text == "X" && Pole5.Text == "X" && Pole8.Text == "X" && this.wygrana != true)
            {
                this.zwyciezca = 'X';
                this.wygrana = true;

                Pole2.BackColor = System.Drawing.Color.LightGreen;
                Pole5.BackColor = System.Drawing.Color.LightGreen;
                Pole8.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole2.Text == "O" && Pole5.Text == "O" && Pole8.Text == "O" && this.wygrana != true)
            {
                this.zwyciezca = 'O';
                this.wygrana = true;

                Pole2.BackColor = System.Drawing.Color.LightGreen;
                Pole5.BackColor = System.Drawing.Color.LightGreen;
                Pole8.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole3.Text == "X" && Pole6.Text == "X" && Pole9.Text == "X" && this.wygrana != true)
            {
                this.zwyciezca = 'X';
                this.wygrana = true;

                Pole3.BackColor = System.Drawing.Color.LightGreen;
                Pole6.BackColor = System.Drawing.Color.LightGreen;
                Pole9.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole3.Text == "O" && Pole6.Text == "O" && Pole9.Text == "O" && this.wygrana != true)
            {
                this.zwyciezca = 'O';
                this.wygrana = true;

                Pole3.BackColor = System.Drawing.Color.LightGreen;
                Pole6.BackColor = System.Drawing.Color.LightGreen;
                Pole9.BackColor = System.Drawing.Color.LightGreen;
            }

            // Skosy
            if (Pole1.Text == "X" && Pole5.Text == "X" && Pole9.Text == "X" && this.wygrana != true)
            {
                this.zwyciezca = 'X';
                this.wygrana = true;

                Pole1.BackColor = System.Drawing.Color.LightGreen;
                Pole5.BackColor = System.Drawing.Color.LightGreen;
                Pole9.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole1.Text == "O" && Pole5.Text == "O" && Pole9.Text == "O" && this.wygrana != true)
            {
                this.zwyciezca = 'O';
                this.wygrana = true;

                Pole1.BackColor = System.Drawing.Color.LightGreen;
                Pole5.BackColor = System.Drawing.Color.LightGreen;
                Pole9.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole3.Text == "X" && Pole5.Text == "X" && Pole7.Text == "X" && this.wygrana != true)
            {
                this.zwyciezca = 'X';
                this.wygrana = true;

                Pole3.BackColor = System.Drawing.Color.LightGreen;
                Pole5.BackColor = System.Drawing.Color.LightGreen;
                Pole7.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole3.Text == "O" && Pole5.Text == "O" && Pole7.Text == "O" && this.wygrana != true)
            { 
                this.zwyciezca = 'O';
                this.wygrana = true;

                Pole3.BackColor = System.Drawing.Color.LightGreen;
                Pole5.BackColor = System.Drawing.Color.LightGreen;
                Pole7.BackColor = System.Drawing.Color.LightGreen;
            }

            if (this.wygrana == true)
            {
                if (this.zwyciezca == 'X')
                {
                    GlownyTekst.Text = "    Wygrywa X";
                    
                    this.wygraneX++;
                    LabelSumaWygrX.Text = "Wygrane X: " + this.wygraneX;
                }
                else
                {
                    GlownyTekst.Text = "    Wygrana O";
                    
                    this.wygraneO++;
                    LabelSumaWygrO.Text = "Wygrane O: " + this.wygraneO;
                }
                PrzyciskNowaGra.Visible = true;
            }
            else
            {
                gracze.NastepnyGracz(GlownyTekst);
                GlownyTekst.Text = "Tura Gracza: " + gracze.tura;
            }
        }

        public void CzyRemis(Label GlownyTekst, Button PrzyciskNowaGra)
        {
            if (this.ruchy == 9 && this.wygrana != true)
            {
                this.remis = true;
                GlownyTekst.Text = "       Remis";

                PrzyciskNowaGra.Visible = true;
            }
        }

        public void KoniecTury(Button Pole1, Button Pole2, Button Pole3, Button Pole4, Button Pole5, Button Pole6, Button Pole7, Button Pole8, Button Pole9, Button PrzyciskNowaGra, Gracze gracze, Label GlownyTekst, Label LabelSumaWygrO, Label LabelSumaWygrX)
        {
            this.ruchy++;
            this.CzyWygrana(Pole1, Pole2, Pole3, Pole4, Pole5, Pole6, Pole7, Pole8, Pole9, PrzyciskNowaGra, gracze, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            this.CzyRemis(GlownyTekst, PrzyciskNowaGra);
        }

        public void NowaGra(Button Pole1, Button Pole2, Button Pole3, Button Pole4, Button Pole5, Button Pole6, Button Pole7, Button Pole8, Button Pole9, Button PrzyciskNowaGra, Gracze gracze, Label GlownyTekst)
        {
            Pole1.Text = "";
            Pole2.Text = "";
            Pole3.Text = "";
            Pole4.Text = "";
            Pole5.Text = "";
            Pole6.Text = "";
            Pole7.Text = "";
            Pole8.Text = "";
            Pole9.Text = "";

            Pole1.BackColor = System.Drawing.SystemColors.Control;
            Pole2.BackColor = System.Drawing.SystemColors.Control;
            Pole3.BackColor = System.Drawing.SystemColors.Control;
            Pole4.BackColor = System.Drawing.SystemColors.Control;
            Pole5.BackColor = System.Drawing.SystemColors.Control;
            Pole6.BackColor = System.Drawing.SystemColors.Control;
            Pole7.BackColor = System.Drawing.SystemColors.Control;
            Pole8.BackColor = System.Drawing.SystemColors.Control;
            Pole9.BackColor = System.Drawing.SystemColors.Control;

            this.wygrana = false;
            this.remis = false;
            this.zwyciezca = ' ';
            this.ruchy = 0;

            PrzyciskNowaGra.Visible = false;
            gracze.LosujGraczy(GlownyTekst);
        }

    }
}
