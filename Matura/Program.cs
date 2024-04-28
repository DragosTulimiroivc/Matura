using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Matura
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Matura m = new Matura();
            using (StreamReader file = new StreamReader(@"Ucenici.csv"))
            {
                Ucenici.br = 0;
                while (!file.EndOfStream)
                {
                    string[] Red = file.ReadLine().Split(';');
                    for (int i = 0; i < 8; i++)
                    {
                        Ucenici.matrica[Ucenici.br, i] = Red[i];
                    }
                    Ucenici.br++;
                }
            }
            Application.Run(m);
        }
    }
}
