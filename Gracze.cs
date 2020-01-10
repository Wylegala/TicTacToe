using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class Gracze
    {
        // Klasa gracze przechowuje tylko informacje o tym który gracz powinien wykonać ruch w obecnej turze
        //
        // Klasa posiada 2 metody - losującą pierwszego gracza i zmieniającą turnę na następnego gracza
        protected string tura;

        public Gracze()
        {
            tura = "O";
        }

        // Metoda LosujGraczy jest odpowiedzialna za losowy wybór pierwszego gracza
        // Metoda pobiera 1 argument, któym jest tekst gdzie zostanie wyświetlona informacja o tym który gracz powinien wykonać następny ruch
        public void LosujGraczy(Label label1)
        {
            // Pobranie aktualnego czasu systemu i przypisanie do zmiennej seed
            // Zmienna seed, która zmienia się co milisekundę, zostanie następnie podzielona modula przez 2
            // Jeżeli wynik dzielenia jest parzysty to zaczyna gracz X, a jeśli nieparzysty to zaczyna O
            int seed = System.DateTime.Now.Millisecond;
            System.Random los = new Random(seed);
            if (los.Next(1, 100) % 2 == 1)
            {
                tura = "O";
            }
            else
            {
                tura = "X";
            }
            label1.Text = "Tura Gracza: " + this.tura;
        }

        // Przeciążona metoda LosujGraczy(), jeżeli zdecydujemy się nie losować gracza a wybrać na stałe gracza rozpoczyającego rozgrywkę
        public void LosujGraczy(Label label1, char gracz)
        {
            try
            {
                if (gracz == 'X' || gracz == 'O')
                {
                    label1.Text = "Tura Gracza: " + gracz;
                }
                else
                {
                    throw new System.Exception("User Exception");
                }
            }
            catch
            {
                gracz = 'O';
                label1.Text = "Tura Gracza: " + gracz;
            }
        }

        // Metoda NastepnyGracz odpowiada za zmianę tury na anstępnego gracza przez aktualizację zmiennej "tura" i wyświetlenie informacji który gracz powinien wykonać następny ruch
        public void NastepnyGracz(Label label1)
        {
            if (tura == "O") tura = "X";
            else tura = "O";

            label1.Text = "Tura Gracza: " + this.tura;
        }

        // Metoda zwracająca obecnego gracza
        public string AktywnyGracz()
        {
            return this.tura;
        }
    }
}
