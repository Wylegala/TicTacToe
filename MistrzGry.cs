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
            wygrana = false;
            remis = false;
            wygraneO = 0;
            wygraneX = 0;
            ruchy = 0;
        }

        public void CzyWygrana(string pole1, string pole2, string pole3,
                               string pole4, string pole5, string pole6,
                               string pole7, string pole8, string pole9)
        {
            // Poziome
            if (pole1 == "X" && pole2 == "X" && pole3 == "X") { this.zwyciezca = 'X'; this.wygrana = true; }
            if (pole1 == "O" && pole2 == "O" && pole3 == "O") { this.zwyciezca = 'O'; this.wygrana = true; }
            if (pole4 == "X" && pole5 == "X" && pole6 == "X") { this.zwyciezca = 'X'; this.wygrana = true; }
            if (pole4 == "O" && pole5 == "O" && pole6 == "O") { this.zwyciezca = 'O'; this.wygrana = true; }
            if (pole7 == "X" && pole8 == "X" && pole9 == "X") { this.zwyciezca = 'X'; this.wygrana = true; }
            if (pole7 == "O" && pole8 == "O" && pole9 == "O") { this.zwyciezca = 'O'; this.wygrana = true; }

            // Pionowe
            if (pole1 == "X" && pole4 == "X" && pole7 == "X") { this.zwyciezca = 'X'; this.wygrana = true; }
            if (pole1 == "O" && pole4 == "O" && pole7 == "O") { this.zwyciezca = 'O'; this.wygrana = true; }
            if (pole2 == "X" && pole5 == "X" && pole8 == "X") { this.zwyciezca = 'X'; this.wygrana = true; }
            if (pole2 == "O" && pole5 == "O" && pole8 == "O") { this.zwyciezca = 'O'; this.wygrana = true; }
            if (pole3 == "X" && pole6 == "X" && pole9 == "X") { this.zwyciezca = 'X'; this.wygrana = true; }
            if (pole3 == "O" && pole6 == "O" && pole9 == "O") { this.zwyciezca = 'O'; this.wygrana = true; }

            // Skosy
            if (pole1 == "X" && pole5 == "X" && pole9 == "X") { this.zwyciezca = 'X'; this.wygrana = true; }
            if (pole1 == "O" && pole5 == "O" && pole9 == "O") { this.zwyciezca = 'O'; this.wygrana = true; }
            if (pole3 == "X" && pole5 == "X" && pole7 == "X") { this.zwyciezca = 'X'; this.wygrana = true; }
            if (pole3 == "O" && pole5 == "O" && pole7 == "O") { this.zwyciezca = 'O'; this.wygrana = true; }

            /*
            if (this.wygrana == true)
            {
                sumaO = "Wygrane Osdas: ";


                if (this.zwyciezca == 'O')
                {
                    ++this.wygraneO;
                    sumaO = "Wygrane O: " + this.wygraneO;
                }
                else
                {
                    ++this.wygraneX;
                    sumaX = "Wygrane X: " + this.wygraneX;
                }
            }
            */
        }

        public bool CzyRemis()
        {
            if (this.ruchy == 9 && this.wygrana != true)
            {
                this.remis = true;
            }
            return remis;
        }

        public void KoniecTury(Button button1, Button button2, Button button3, Button button4, Button button5, Button button6, Button button7, Button button8, Button button9)
        {
            this.ruchy++;
            this.CzyWygrana(button1.Text, button2.Text, button3.Text, button4.Text, button5.Text, button6.Text, button7.Text, button8.Text, button9.Text);
            this.CzyRemis();
        }

        public void Punkty(Label label)
        {
            if (this.zwyciezca == 'O') label.Text = "Wygrał gracz O!";
            else label.Text = "Wygrał gracz X!";
        }
    }
}
