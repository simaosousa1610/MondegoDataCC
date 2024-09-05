using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;

namespace Janelas
{
    public partial class Login : Form
    {
        private LoginControlador loginControlador;
        public Login(LoginControlador loginControlador)
        {
            this.loginControlador = loginControlador;
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get the username and password from the textboxes and check if they are correct
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username.Length <=0 || password.Length <=0)
            {
                // if they are incorrect, show an error message
                MessageBox.Show("Invalid username or password!");
            }
            else {
                var resultado = loginControlador.CheckCredentials(username, password,1);
                // how to open the next window?
                if (resultado == "Login Successfull")
                {
                    this.Hide();
                    BackofficeMenu backofficeMenu = new BackofficeMenu();
                    Menu menu = new Menu(backofficeMenu);
                    menu.Show();
                    menu.Focus();
                }
                else
                {
                    MessageBox.Show(resultado);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
