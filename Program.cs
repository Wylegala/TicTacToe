using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace TicTacToe
{
    static class Program
    {
        // Główna ścieżka wykonywania programu
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Utworzenie 2 wątków dodatkowych: pierwszyWatek, drugiWatek
            // Każdy z wątków zainicjuje jedną z poniższych metod i będzie ją obsługiwał przez czas działania aplikacji
            Thread pierwszyWatek = new Thread(WlaczGre1);
            Thread drugiWatek = new Thread(WlaczGre2);

            pierwszyWatek.Start();
            drugiWatek.Start();
        }

        // Metoda WlaczGre1(), która będzie obsługiwana przez pierwszy z wątków dodatkowych zadeklarowanych w programie
        static void WlaczGre1()
        {
            Application.Run(new TicTacToe());
        }

        // Metoda WlaczGre2(), która będzie obsługiwana przez drugi z wątków dodatkowych zadeklarowanych w programie
        static void WlaczGre2()
        {
            Application.Run(new TicTacToe());
        }
    }
}
