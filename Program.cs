using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace TicTacToe
{
    static class Program
    {
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread pierwszyWatek = new Thread(WlaczGre1);
            Thread drugiWatek = new Thread(WlaczGre2);

            pierwszyWatek.Start();
            drugiWatek.Start();
        }

        static void WlaczGre1()
        {
            Application.Run(new TicTacToe());
        }
        static void WlaczGre2()
        {
            Application.Run(new TicTacToe());
        }
    }
}
