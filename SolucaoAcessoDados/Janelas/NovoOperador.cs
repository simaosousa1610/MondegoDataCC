using Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Janelas
{
    public partial class NovoOperador : Form
    {
        private LoginControlador loginControlador;
        public NovoOperador(LoginControlador loginControlador)
        {
            this.loginControlador = loginControlador;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NovoOperador_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username.Length <= 0 || password.Length <= 0)
            {
                MessageBox.Show("Invalid username or password!");
            }
            else
            {
                var resultado = loginControlador.criarOperadorBackOffice(username, password);
                if (resultado == "Login Successfull")
                {
                    this.DialogResult = DialogResult.OK; 
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(resultado);
                }
            }
        }
    }
}
