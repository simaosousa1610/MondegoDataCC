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

            // Check if there are no BackOffice users
            int resultado = loginControlador.checkIfNoBackOfficeUsers();

            // If no users exist, create a new operator
            if (resultado == 0)
            {
                using (NovoOperador novoOperadorForm = new NovoOperador(loginControlador))
                {
                    if (novoOperadorForm.ShowDialog() != DialogResult.OK)
                    {
                        // If operator creation fails, exit the application
                        return;
                    }
                }
            }

            // After an operator exists or has been created, show the login form
            using (Login loginForm = new Login(loginControlador))
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // If login is successful, proceed to launch the Menu
                    BackofficeMenu backofficeMenu = new BackofficeMenu();
                    Menu menuForm = new Menu(backofficeMenu);

                    // Run the main application menu
                    Application.Run(menuForm);
                }
            }
        }
    }
}
