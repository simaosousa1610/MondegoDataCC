using Controladores;
using Modelos;
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
    public partial class AdicionarOperadorForm : Form
    {
        private BackofficeMenu backofficeMenu = new BackofficeMenu();

        public AdicionarOperadorForm(BackofficeMenu backoffice)
        {
            this.backofficeMenu = backoffice;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (backofficeMenu != null)
            {
                Operadores operador = new Operadores();
                operador.strNome = textBox2.Text;
                operador.fltPrecoHora = (float)Convert.ToDouble(textBox5.Text);
                operador.bitAtivo = checkBox1.Checked;
                operador.SetPassword(textBox5.Text);

                if (backofficeMenu.AddOperador(operador) == 0) 
                    { MessageBox.Show("Operador adicionado com sucesso!"); }
                else 
                    { MessageBox.Show("Erro ao adicionar operador!"); }

                this.Close();

            }
        }
    }
}
