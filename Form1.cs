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

            Gracze1.LosujGraczy(GlownyTekst);
        }

        MistrzGry Mistrz1 = new MistrzGry();

        private void button1_Click(object sender, EventArgs e)
        {
            if (pole1.Text == "" && Mistrz1.wygrana != true)
            {
                pole1.Text = Gracze1.tura;
                Mistrz1.KoniecTury(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pole2.Text == "" && Mistrz1.wygrana != true)
            {
                pole2.Text = Gracze1.tura;
                Mistrz1.KoniecTury(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pole3.Text == "" && Mistrz1.wygrana != true)
            {
                pole3.Text = Gracze1.tura;
                Mistrz1.KoniecTury(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pole4.Text == "" && Mistrz1.wygrana != true)
            {
                pole4.Text = Gracze1.tura;
                Mistrz1.KoniecTury(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pole5.Text == "" && Mistrz1.wygrana != true)
            {
                pole5.Text = Gracze1.tura;
                Mistrz1.KoniecTury(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pole6.Text == "" && Mistrz1.wygrana != true)
            {
                pole6.Text = Gracze1.tura;
                Mistrz1.KoniecTury(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (pole7.Text == "" && Mistrz1.wygrana != true)
            {
                pole7.Text = Gracze1.tura;
                Mistrz1.KoniecTury(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (pole8.Text == "" && Mistrz1.wygrana != true)
            {
                pole8.Text = Gracze1.tura;
                Mistrz1.KoniecTury(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (pole9.Text == "" && Mistrz1.wygrana != true)
            {
                pole9.Text = Gracze1.tura;
                Mistrz1.KoniecTury(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst, LabelSumaWygrO, LabelSumaWygrX);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Mistrz1.NowaGra(pole1, pole2, pole3, pole4, pole5, pole6, pole7, pole8, pole9, PrzyciskNowaGra, Gracze1, GlownyTekst);
        }
    }
}
