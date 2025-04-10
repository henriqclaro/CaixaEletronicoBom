using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaElel
{
    internal static class Program
    {
        public static double saldo = 0;
        public static double investido = 0;
        public static float fixa = 0;
        public static double apostado = 0;
        public static float multiplicador = 0;
        public static byte acertos_aposta = 0;
        public static String numCertos; 
        public static String sorteados;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
