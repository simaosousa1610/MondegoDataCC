using Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Janelas
{
    public partial class EditarOperadorForm : Form
    {
        private BackofficeMenu backofficeMenu = new BackofficeMenu();
        public int id;

        public EditarOperadorForm(int id, BackofficeMenu backoffice )
        {
            this.id = id;
            this.backofficeMenu = backoffice;
            InitializeComponent();
        }

        public void EditarOperadorForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("EditarOperadorForm_Load");
            var operador = backofficeMenu.GetOperador(id);

            if (operador != null)
            {
                textBox1.Text = operador.intCodigo.ToString();
                textBox2.Text = operador.strNome;
                textBox5.Text = operador.fltPrecoHora.ToString();

                if (operador.bitAtivo)
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ( backofficeMenu != null ) {
                // get the id from the textbox
                int id = Convert.ToInt32(textBox1.Text);
                // get the operador from the database
                var operador = backofficeMenu.GetOperador(id);
                // set the values of the textboxes to the values of the operador

                operador.strNome = textBox2.Text;
                operador.fltPrecoHora = (float)Convert.ToDouble(textBox5.Text);

                //check if the checkbox is checked
                if (checkBox1.Checked)
                {
                    operador.bitAtivo = true;
                }
                else
                {
                    operador.bitAtivo = false;
                }

                // save the changes to the database
                if (backofficeMenu.EditOperador(operador) == 0)
                {
                    MessageBox.Show("Operador editado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao editar operador!");
                }
                // close the form
                this.Close();
            }
        }


    }
}
