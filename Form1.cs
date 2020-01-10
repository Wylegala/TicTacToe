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
        // Utworzenie nowego obiektu klasy Gracze
        Gracze Gracze1 = new Gracze();

        public TicTacToe()
        {
            InitializeComponent();

            // Wylosowanie gracza rozpoczynającego grę i wyświetlenie odpowiedniego komunikatu na ekranie
            Gracze1.LosujGraczy(GlownyTekst);
        }

        // Utworzenie nowej instancji klasy MistrzGry, który będzie zarządzał rozgrywką
        MistrzGry Mistrz1 = new MistrzGry();


        // Poniżej znajdują się okodowane zdarzenia kliknięcia w każde z 9 pól gry w kółko i krzyżyk oraz przycisk nowej gry

        // Zdarzenie kliknięcia w 1 pole
        private void button1_Click(object sender, EventArgs e)
        {
            // Sprawdzenie czy w pole 1 został już wpisany 'X' albo 'O' podczas poprzednich tur
            // Sprawdzenie czy gra nadal trwa - gra kończy się gdy zmienna wygrana == true
            if (pole1.Text == "" && Mistrz1.ZwrocWygrana() != true)
            {
                // Jeżeli pole było puste a gra wciąż trwa, to wpisujemy 'X' albo 'O' w zależności który gracz wykonuje aktualny ruch
                pole1.Text = Gracze1.AktywnyGracz();

                // Zatrudniamy MistrzaGry do wywołania metody KoniecGry() - działanie metody zostało opisane w klasie MistrzGry
                Mistrz1.KoniecTury(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            }
        }

        // Zdarzenie kliknięcia w 2 pole
        private void button2_Click(object sender, EventArgs e)
        {
            // Sprawdzenie czy w pole 2 został już wpisany 'X' albo 'O' podczas poprzednich tur
            // Sprawdzenie czy gra nadal trwa - gra kończy się gdy zmienna wygrana == true
            if (pole2.Text == "" && Mistrz1.ZwrocWygrana() != true)
            {
                // Jeżeli pole było puste a gra wciąż trwa, to wpisujemy 'X' albo 'O' w zależności który gracz wykonuje aktualny ruch
                pole2.Text = Gracze1.AktywnyGracz();

                // Zatrudniamy MistrzaGry do wywołania metody KoniecGry() - działanie metody zostało opisane w klasie MistrzGry
                Mistrz1.KoniecTury(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            }
        }

        // Zdarzenie kliknięcia w 3 pole
        private void button3_Click(object sender, EventArgs e)
        {
            // Sprawdzenie czy w pole 3 został już wpisany 'X' albo 'O' podczas poprzednich tur
            // Sprawdzenie czy gra nadal trwa - gra kończy się gdy zmienna wygrana == true
            if (pole3.Text == "" && Mistrz1.ZwrocWygrana() != true)
            {
                // Jeżeli pole było puste a gra wciąż trwa, to wpisujemy 'X' albo 'O' w zależności który gracz wykonuje aktualny ruch
                pole3.Text = Gracze1.AktywnyGracz();

                // Zatrudniamy MistrzaGry do wywołania metody KoniecGry() - działanie metody zostało opisane w klasie MistrzGry
                Mistrz1.KoniecTury(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            }
        }

        // Zdarzenie kliknięcia w 4 pole
        private void button4_Click(object sender, EventArgs e)
        {
            // Sprawdzenie czy w pole 4 został już wpisany 'X' albo 'O' podczas poprzednich tur
            // Sprawdzenie czy gra nadal trwa - gra kończy się gdy zmienna wygrana == true
            if (pole4.Text == "" && Mistrz1.ZwrocWygrana() != true)
            {
                // Jeżeli pole było puste a gra wciąż trwa, to wpisujemy 'X' albo 'O' w zależności który gracz wykonuje aktualny ruch
                pole4.Text = Gracze1.AktywnyGracz();

                // Zatrudniamy MistrzaGry do wywołania metody KoniecGry() - działanie metody zostało opisane w klasie MistrzGry
                Mistrz1.KoniecTury(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            }
        }

        // Zdarzenie kliknięcia w 5 pole
        private void button5_Click(object sender, EventArgs e)
        {
            // Sprawdzenie czy w pole 5 został już wpisany 'X' albo 'O' podczas poprzednich tur
            // Sprawdzenie czy gra nadal trwa - gra kończy się gdy zmienna wygrana == true
            if (pole5.Text == "" && Mistrz1.ZwrocWygrana() != true)
            {
                // Jeżeli pole było puste a gra wciąż trwa, to wpisujemy 'X' albo 'O' w zależności który gracz wykonuje aktualny ruch
                pole5.Text = Gracze1.AktywnyGracz();

                // Zatrudniamy MistrzaGry do wywołania metody KoniecGry() - działanie metody zostało opisane w klasie MistrzGry
                Mistrz1.KoniecTury(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            }
        }

        // Zdarzenie kliknięcia w 6 pole
        private void button6_Click(object sender, EventArgs e)
        {
            // Sprawdzenie czy w pole 6 został już wpisany 'X' albo 'O' podczas poprzednich tur
            // Sprawdzenie czy gra nadal trwa - gra kończy się gdy zmienna wygrana == true
            if (pole6.Text == "" && Mistrz1.ZwrocWygrana() != true)
            {
                // Jeżeli pole było puste a gra wciąż trwa, to wpisujemy 'X' albo 'O' w zależności który gracz wykonuje aktualny ruch
                pole6.Text = Gracze1.AktywnyGracz();

                // Zatrudniamy MistrzaGry do wywołania metody KoniecGry() - działanie metody zostało opisane w klasie MistrzGry
                Mistrz1.KoniecTury(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            }
        }

        // Zdarzenie kliknięcia w 7 pole
        private void button7_Click(object sender, EventArgs e)
        {
            // Sprawdzenie czy w pole 7 został już wpisany 'X' albo 'O' podczas poprzednich tur
            // Sprawdzenie czy gra nadal trwa - gra kończy się gdy zmienna wygrana == true
            if (pole7.Text == "" && Mistrz1.ZwrocWygrana() != true)
            {
                // Jeżeli pole było puste a gra wciąż trwa, to wpisujemy 'X' albo 'O' w zależności który gracz wykonuje aktualny ruch
                pole7.Text = Gracze1.AktywnyGracz();

                // Zatrudniamy MistrzaGry do wywołania metody KoniecGry() - działanie metody zostało opisane w klasie MistrzGry
                Mistrz1.KoniecTury(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            }
        }

        // Zdarzenie kliknięcia w 8 pole
        private void button8_Click(object sender, EventArgs e)
        {
            // Sprawdzenie czy w pole 8 został już wpisany 'X' albo 'O' podczas poprzednich tur
            // Sprawdzenie czy gra nadal trwa - gra kończy się gdy zmienna wygrana == true
            if (pole8.Text == "" && Mistrz1.ZwrocWygrana() != true)
            {
                // Jeżeli pole było puste a gra wciąż trwa, to wpisujemy 'X' albo 'O' w zależności który gracz wykonuje aktualny ruch
                pole8.Text = Gracze1.AktywnyGracz();

                // Zatrudniamy MistrzaGry do wywołania metody KoniecGry() - działanie metody zostało opisane w klasie MistrzGry
                Mistrz1.KoniecTury(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            }
        }

        // Zdarzenie kliknięcia w 9 pole
        private void button9_Click(object sender, EventArgs e)
        {
            // Sprawdzenie czy w pole 9 został już wpisany 'X' albo 'O' podczas poprzednich tur
            // Sprawdzenie czy gra nadal trwa - gra kończy się gdy zmienna wygrana == true
            if (pole9.Text == "" && Mistrz1.ZwrocWygrana() != true)
            {
                // Jeżeli pole było puste a gra wciąż trwa, to wpisujemy 'X' albo 'O' w zależności który gracz wykonuje aktualny ruch
                pole9.Text = Gracze1.AktywnyGracz();

                // Zatrudniamy MistrzaGry do wywołania metody KoniecGry() - działanie metody zostało opisane w klasie MistrzGry
                Mistrz1.KoniecTury(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            }
        }

        // Zdarzenie kliknięcia w przycisk nowej gry
        private void button10_Click(object sender, EventArgs e)
        {
            // MistrzGry obsługuje też funkcjonalność przycisku nowej gry przez motodę NowaGra(), któa została opisana w klasie MistrzGry
            Mistrz1.NowaGra(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst);
        }
    }
}
