using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class MistrzGry : Gracze
    {
        // Zdefiniowanie pól kluczownych dla działania aplikacji
        // bool wygrana - kontrolka informująca czy gra została zakończona wygraną jednego z graczy
        private bool wygrana;
        // jeżeli gra została wygrana to pole char zwyciezca będzie przechowywało identyfikator gracza, który wygrał ('X' / 'O')
        private char zwyciezca;
        // wygraneX to liczba wszystkich wygranych gracza X przez cały czas działania aplikacji
        private int wygraneX;
        // wygraneO to liczba wszystkich wygranych gracza O przez cały czas działania aplikacji
        private int wygraneO;
        // int ruchy jest inkrementowane co turę i służy do sprawdzenia czy wykonano już 9 ruchów i gra powinna zakończyć się remisem
        private int ruchy;

        // Przypisanie domyślnych wartości
        public MistrzGry()
        {
            this.wygrana = false;
            this.wygraneO = 0;
            this.wygraneX = 0;
            this.ruchy = 0;
            this.zwyciezca = ' ';
        }

        // Metoda zwracająca true jeżeli gra została wygrana przez któregoś z graczy
        public bool ZwrocWygrana()
        {
            return this.wygrana;
        }

        // Metoda CzyWygrana(), która przyjmuje jako argumenty 9 pól planszy, referencję przycisku nowej gry, referencję do obiektu graczy i 3 referencje do pól tekstowych
        public void CzyWygrana(Button Pole1, Button Pole2, Button Pole3,
                               Button Pole4, Button Pole5, Button Pole6,
                               Button Pole7, Button Pole8, Button Pole9,
                               Button PrzyciskNowaGra, Gracze gracze, Label GlownyTekst, Label LabelSumaWygrO, Label LabelSumaWygrX)
        {
            // Pierwszym krokiem jaki wykonuje ta metoda jest sprawdzenie czy została spełniona jedna z wygrowających kombinacji wymienionych poniżej
            // Poziome kombinacje
            if (Pole1.Text == "X" && Pole2.Text == "X" && Pole3.Text == "X" && this.wygrana != true)
            {
                // Grę wygrywa gracz 'X', więc przypisujemy tą wartość do zmiennej zwyciezca i zaznaczamy kontrolkę wygrana = true
                this.zwyciezca = 'X';
                this.wygrana = true;

                // Kolorujemy pola zwycięskiej kombinacji na zielono
                Pole1.BackColor = System.Drawing.Color.LightGreen;
                Pole2.BackColor = System.Drawing.Color.LightGreen;
                Pole3.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole1.Text == "O" && Pole2.Text == "O" && Pole3.Text == "O" && this.wygrana != true)
            {
                // Grę wygrywa gracz 'O', więc przypisujemy tą wartość do zmiennej zwyciezca i zaznaczamy kontrolkę wygrana = true
                this.zwyciezca = 'O';
                this.wygrana = true;

                // Kolorujemy pola zwycięskiej kombinacji na zielono
                Pole1.BackColor = System.Drawing.Color.LightGreen;
                Pole2.BackColor = System.Drawing.Color.LightGreen;
                Pole3.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole4.Text == "X" && Pole5.Text == "X" && Pole6.Text == "X" && this.wygrana != true)
            {
                // Grę wygrywa gracz 'X', więc przypisujemy tą wartość do zmiennej zwyciezca i zaznaczamy kontrolkę wygrana = true
                this.zwyciezca = 'X';
                this.wygrana = true;

                // Kolorujemy pola zwycięskiej kombinacji na zielono
                Pole4.BackColor = System.Drawing.Color.LightGreen;
                Pole5.BackColor = System.Drawing.Color.LightGreen;
                Pole6.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole4.Text == "O" && Pole5.Text == "O" && Pole6.Text == "O" && this.wygrana != true)
            {
                // Grę wygrywa gracz 'O', więc przypisujemy tą wartość do zmiennej zwyciezca i zaznaczamy kontrolkę wygrana = true
                this.zwyciezca = 'O';
                this.wygrana = true;

                // Kolorujemy pola zwycięskiej kombinacji na zielono
                Pole4.BackColor = System.Drawing.Color.LightGreen;
                Pole5.BackColor = System.Drawing.Color.LightGreen;
                Pole6.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole7.Text == "X" && Pole8.Text == "X" && Pole9.Text == "X" && this.wygrana != true)
            {
                // Grę wygrywa gracz 'X', więc przypisujemy tą wartość do zmiennej zwyciezca i zaznaczamy kontrolkę wygrana = true
                this.zwyciezca = 'X';
                this.wygrana = true;

                // Kolorujemy pola zwycięskiej kombinacji na zielono
                Pole7.BackColor = System.Drawing.Color.LightGreen;
                Pole8.BackColor = System.Drawing.Color.LightGreen;
                Pole9.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole7.Text == "O" && Pole8.Text == "O" && Pole9.Text == "O" && this.wygrana != true)
            {
                // Grę wygrywa gracz 'O', więc przypisujemy tą wartość do zmiennej zwyciezca i zaznaczamy kontrolkę wygrana = true
                this.zwyciezca = 'O';
                this.wygrana = true;

                // Kolorujemy pola zwycięskiej kombinacji na zielono
                Pole7.BackColor = System.Drawing.Color.LightGreen;
                Pole8.BackColor = System.Drawing.Color.LightGreen;
                Pole9.BackColor = System.Drawing.Color.LightGreen;
            }

            // Pionowe kombinacje
            if (Pole1.Text == "X" && Pole4.Text == "X" && Pole7.Text == "X" && this.wygrana != true)
            {
                // Grę wygrywa gracz 'X', więc przypisujemy tą wartość do zmiennej zwyciezca i zaznaczamy kontrolkę wygrana = true
                this.zwyciezca = 'X';
                this.wygrana = true;

                // Kolorujemy pola zwycięskiej kombinacji na zielono
                Pole1.BackColor = System.Drawing.Color.LightGreen;
                Pole4.BackColor = System.Drawing.Color.LightGreen;
                Pole7.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole1.Text == "O" && Pole4.Text == "O" && Pole7.Text == "O" && this.wygrana != true)
            {
                // Grę wygrywa gracz 'O', więc przypisujemy tą wartość do zmiennej zwyciezca i zaznaczamy kontrolkę wygrana = true
                this.zwyciezca = 'O';
                this.wygrana = true;

                // Kolorujemy pola zwycięskiej kombinacji na zielono
                Pole1.BackColor = System.Drawing.Color.LightGreen;
                Pole4.BackColor = System.Drawing.Color.LightGreen;
                Pole7.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole2.Text == "X" && Pole5.Text == "X" && Pole8.Text == "X" && this.wygrana != true)
            {
                // Grę wygrywa gracz 'X', więc przypisujemy tą wartość do zmiennej zwyciezca i zaznaczamy kontrolkę wygrana = true
                this.zwyciezca = 'X';
                this.wygrana = true;

                // Kolorujemy pola zwycięskiej kombinacji na zielono
                Pole2.BackColor = System.Drawing.Color.LightGreen;
                Pole5.BackColor = System.Drawing.Color.LightGreen;
                Pole8.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole2.Text == "O" && Pole5.Text == "O" && Pole8.Text == "O" && this.wygrana != true)
            {
                // Grę wygrywa gracz 'O', więc przypisujemy tą wartość do zmiennej zwyciezca i zaznaczamy kontrolkę wygrana = true
                this.zwyciezca = 'O';
                this.wygrana = true;

                // Kolorujemy pola zwycięskiej kombinacji na zielono
                Pole2.BackColor = System.Drawing.Color.LightGreen;
                Pole5.BackColor = System.Drawing.Color.LightGreen;
                Pole8.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole3.Text == "X" && Pole6.Text == "X" && Pole9.Text == "X" && this.wygrana != true)
            {
                // Grę wygrywa gracz 'X', więc przypisujemy tą wartość do zmiennej zwyciezca i zaznaczamy kontrolkę wygrana = true
                this.zwyciezca = 'X';
                this.wygrana = true;

                // Kolorujemy pola zwycięskiej kombinacji na zielono
                Pole3.BackColor = System.Drawing.Color.LightGreen;
                Pole6.BackColor = System.Drawing.Color.LightGreen;
                Pole9.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole3.Text == "O" && Pole6.Text == "O" && Pole9.Text == "O" && this.wygrana != true)
            {
                // Grę wygrywa gracz 'O', więc przypisujemy tą wartość do zmiennej zwyciezca i zaznaczamy kontrolkę wygrana = true
                this.zwyciezca = 'O';
                this.wygrana = true;

                // Kolorujemy pola zwycięskiej kombinacji na zielono
                Pole3.BackColor = System.Drawing.Color.LightGreen;
                Pole6.BackColor = System.Drawing.Color.LightGreen;
                Pole9.BackColor = System.Drawing.Color.LightGreen;
            }

            // Ukośne kombinacje
            if (Pole1.Text == "X" && Pole5.Text == "X" && Pole9.Text == "X" && this.wygrana != true)
            {
                // Grę wygrywa gracz 'X', więc przypisujemy tą wartość do zmiennej zwyciezca i zaznaczamy kontrolkę wygrana = true
                this.zwyciezca = 'X';
                this.wygrana = true;

                // Kolorujemy pola zwycięskiej kombinacji na zielono
                Pole1.BackColor = System.Drawing.Color.LightGreen;
                Pole5.BackColor = System.Drawing.Color.LightGreen;
                Pole9.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole1.Text == "O" && Pole5.Text == "O" && Pole9.Text == "O" && this.wygrana != true)
            {
                // Grę wygrywa gracz 'O', więc przypisujemy tą wartość do zmiennej zwyciezca i zaznaczamy kontrolkę wygrana = true
                this.zwyciezca = 'O';
                this.wygrana = true;

                // Kolorujemy pola zwycięskiej kombinacji na zielono
                Pole1.BackColor = System.Drawing.Color.LightGreen;
                Pole5.BackColor = System.Drawing.Color.LightGreen;
                Pole9.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole3.Text == "X" && Pole5.Text == "X" && Pole7.Text == "X" && this.wygrana != true)
            {
                // Grę wygrywa gracz 'X', więc przypisujemy tą wartość do zmiennej zwyciezca i zaznaczamy kontrolkę wygrana = true
                this.zwyciezca = 'X';
                this.wygrana = true;

                // Kolorujemy pola zwycięskiej kombinacji na zielono
                Pole3.BackColor = System.Drawing.Color.LightGreen;
                Pole5.BackColor = System.Drawing.Color.LightGreen;
                Pole7.BackColor = System.Drawing.Color.LightGreen;
            }
            if (Pole3.Text == "O" && Pole5.Text == "O" && Pole7.Text == "O" && this.wygrana != true)
            {
                // Grę wygrywa gracz 'O', więc przypisujemy tą wartość do zmiennej zwyciezca i zaznaczamy kontrolkę wygrana = true
                this.zwyciezca = 'O';
                this.wygrana = true;

                // Kolorujemy pola zwycięskiej kombinacji na zielono
                Pole3.BackColor = System.Drawing.Color.LightGreen;
                Pole5.BackColor = System.Drawing.Color.LightGreen;
                Pole7.BackColor = System.Drawing.Color.LightGreen;
            }

            // Kolejnym krokiem po sprawdzeniu zwycieskich kombinacji u ustawieniu kontrolek jest wyświetlenie informacji który gracz wygrał (jeżeli nastąpiła wygrana) lub wywołanie metody NastępnyGracz() aby rozpocząć następną turę
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
                // Przycisk nowej gry jest domyślnie ukryty, więc jeżeli gra zostąła wygrana to chcemy go pokazać
                PrzyciskNowaGra.Visible = true;
            }
            else
            {
                // Wywłoanie metody NastepnyGracz() aby rozpocząć następną rundę
                gracze.NastepnyGracz(GlownyTekst);
                GlownyTekst.Text = "Tura Gracza: " + gracze.AktywnyGracz();
            }
        }

        // Metoda CzyRemis() monitoruje czy gra została zremisowana żeby można było rozpocząć nową po wykonaniu 9 ruchów bez wygranej
        public void CzyRemis(Label GlownyTekst, Button PrzyciskNowaGra)
        {
            if (this.ruchy == 9 && this.wygrana != true)
            {
                GlownyTekst.Text = "       Remis";

                PrzyciskNowaGra.Visible = true;
            }
        }

        // Metoda KoniecTury() to jedyna metoda wywoływana podczas wpisania X albo O w dowolne pole na planszy
        // Metoda odpowiada za wywołanie pozostałych metod tej klasy sprawdzających czy gra została wygrana lub nastąpił remis, a także inkrementację wykonanych ruchów podczas obecnej gry
        public void KoniecTury(Button Pole1, Button Pole2, Button Pole3, Button Pole4, Button Pole5, Button Pole6, Button Pole7, Button Pole8, Button Pole9, Button PrzyciskNowaGra, Gracze gracze, Label GlownyTekst, Label LabelSumaWygrO, Label LabelSumaWygrX)
        {
            this.ruchy++;
            this.CzyWygrana(Pole1, Pole2, Pole3, Pole4, Pole5, Pole6, Pole7, Pole8, Pole9, PrzyciskNowaGra, gracze, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            this.CzyRemis(GlownyTekst, PrzyciskNowaGra);
        }

        // Metoda NowaGra() odpowiada za obsługę kliknięcia w przycisk nowej gry który pokazuje się po wygraniu gry przez jednego z graczy lub zremisowaniu po 9 ruchach
        public void NowaGra(Button Pole1, Button Pole2, Button Pole3, Button Pole4, Button Pole5, Button Pole6, Button Pole7, Button Pole8, Button Pole9, Button PrzyciskNowaGra, Gracze gracze, Label GlownyTekst)
        {
            // Czyścimy wartości wpisane przez graczy do wszystkich 9 pól na planszy
            Pole1.Text = "";
            Pole2.Text = "";
            Pole3.Text = "";
            Pole4.Text = "";
            Pole5.Text = "";
            Pole6.Text = "";
            Pole7.Text = "";
            Pole8.Text = "";
            Pole9.Text = "";

            // Ustawiamy tło pól na domyślny kolor, bo jeżeli gra zostła wygrana to niektóre pola będą miały zielone tło
            Pole1.BackColor = System.Drawing.SystemColors.Control;
            Pole2.BackColor = System.Drawing.SystemColors.Control;
            Pole3.BackColor = System.Drawing.SystemColors.Control;
            Pole4.BackColor = System.Drawing.SystemColors.Control;
            Pole5.BackColor = System.Drawing.SystemColors.Control;
            Pole6.BackColor = System.Drawing.SystemColors.Control;
            Pole7.BackColor = System.Drawing.SystemColors.Control;
            Pole8.BackColor = System.Drawing.SystemColors.Control;
            Pole9.BackColor = System.Drawing.SystemColors.Control;

            // Ponowne ustawienie kontrolek i pól śledzących przebieg gry na wartości domyślne - takie same jak w konstruktorze tej klasy
            this.wygrana = false;
            this.zwyciezca = ' ';
            this.ruchy = 0;

            // Ponowne ukrycie przycisku nowej gry
            PrzyciskNowaGra.Visible = false;

            // Wylosowanie gracza rozpoczynającegokolejną rozgrywkę
            gracze.LosujGraczy(GlownyTekst);
        }
    }
}
