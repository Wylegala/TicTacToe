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
        public string tura;

        public Gracze()
        {
            tura = "O";
        }

        public void LosujGraczy(Label label1)
        {
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

        public void NastepnyGracz(Label label1)
        {
            if (tura == "O") tura = "X";
            else tura = "O";

            label1.Text = "Tura Gracza: " + this.tura;
        }
    }
}
