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

        private void Login_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username.Length <=0 || password.Length <=0)
            {
                MessageBox.Show("Invalid username or password!");
            }
            else {
                var resultado = loginControlador.CheckCredentials(username, password,1);
                if (resultado == "Login Successfull")
                {
                    this.DialogResult = DialogResult.OK;  // Set dialog result instead of closing
                    this.Hide();
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
