using Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Janelas
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]

        static void Main()
        {
            LoginControlador loginControlador = new LoginControlador();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int resultado = loginControlador.checkIfNoBackOfficeUsers();

            if (resultado == 1)
            {
                Application.Run(new NovoOperador(loginControlador));
            }
            else if (resultado == -1)
            {
                MessageBox.Show("An error occurred. Please check the logs.");
                Application.Exit();
            }
            Application.Run(new Login(loginControlador));

        }
    }
}
