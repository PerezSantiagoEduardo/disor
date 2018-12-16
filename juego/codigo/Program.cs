
using System.Diagnostics;
using System.Threading;
using System;
using System.Windows.Forms;

namespace Juego_de_la_vida
{
    public static class Program
    {
        private static Mutex propoAcess;

        [STAThread]
        public static void Main()
        {
            if (intanciaPre())
            {
                Application.Exit();
                return;
            }
            Application.Run(new MainForm());
        }


        public static bool intanciaPre()
        {
            
            string NombreAssembly = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
           
            string nombrePropoAces = "Global\\" + NombreAssembly;
            bool nuevoPropoAcces = false;
            try
            {
                propoAcess  = new Mutex(false, nombrePropoAces, out nuevoPropoAcces);
                if (nuevoPropoAcces)
                {
                    return false;
                }
                else
                {
                    propoAcess.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}