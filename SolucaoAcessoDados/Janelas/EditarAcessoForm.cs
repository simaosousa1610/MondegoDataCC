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
    public partial class EditarAcessoForm : Form
    {
        BackofficeMenu BackofficeMenu;
        int selectedAcessoId;

        public EditarAcessoForm(int selectedAcessoId, BackofficeMenu backofficeMenu)
        {
            this.BackofficeMenu = backofficeMenu;
            this.selectedAcessoId = selectedAcessoId;
            InitializeComponent();
        }

        public void LoadOperadores()
        {
            var operadores = BackofficeMenu.ListOperadores();
            comboBox1.DataSource = operadores;
            comboBox1.DisplayMember = "strNome";
            comboBox1.ValueMember = "intCodigo";


            if (selectedAcessoId == 0) {
                comboBox1.SelectedIndex = 0;
                checkBox2.Checked = true;
            } else {
                var acesso = BackofficeMenu.GetAcesso(selectedAcessoId);
                comboBox1.SelectedValue = acesso.intOperador;
                checkBox2.Checked = acesso.bitAtivo;
            }
        }

        private void EditarAcessoForm_Load(object sender, EventArgs e)
        {
            LoadOperadores();
            textBox3.Text = BackofficeMenu.GetAcesso(selectedAcessoId).strToken;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // get the selected operador and the token from the text box
            var operador = (Modelos.Operadores)comboBox1.SelectedItem;
            string token = textBox3.Text;

            // create a new Acesso object with the selected operador and token
            Acesso acesso = new Acesso();
            acesso.intCodigo = selectedAcessoId;
            acesso.intOperador = operador.intCodigo;
            acesso.bitAtivo = checkBox2.Checked;
            acesso.strToken = token;

            if (BackofficeMenu.EditAcesso(acesso) == 0)
            {
                MessageBox.Show("Acesso editado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao editar o acesso!");
            }

            this.Close();
        }
    }
}