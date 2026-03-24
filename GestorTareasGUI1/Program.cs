using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorTareasGUI1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ----------------------------
            // LÍNEA PARA SIMULAR CONFLICTO
            // En la rama feature/login:
            Console.WriteLine("Login implementado");

            // En la rama feature/registro:
            Console.WriteLine("Registro implementado");
            // ----------------------------

            Application.Run(new Form1());
        }
    }
}