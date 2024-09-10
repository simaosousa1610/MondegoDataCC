using Controladores;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Janelas
{
    public partial class EditarAcessoForm : Form
    {
        BackofficeMenu BackofficeMenu;
        Aplicacao App;
        int selectedAcessoId = 0;

        public EditarAcessoForm(int selectedAcessoId, BackofficeMenu backofficeMenu, Aplicacao app)
        {
            this.App = app;
            this.BackofficeMenu = backofficeMenu;
            this.selectedAcessoId = selectedAcessoId;
            InitializeComponent();
        }

        public EditarAcessoForm(BackofficeMenu backofficeMenu, Aplicacao app)
        {
            this.App = app;
            this.BackofficeMenu = backofficeMenu;
            selectedAcessoId = 0;
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
            if (selectedAcessoId != 0)
                textBox3.Text = BackofficeMenu.GetAcesso(selectedAcessoId).strToken;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var operador = (Modelos.Operadores)comboBox1.SelectedItem;
            string token = textBox3.Text;

            // get the application 
            Acesso acesso = new Acesso();
            acesso.intCodigo = selectedAcessoId;
            acesso.intOperador = operador.intCodigo;
            acesso.intAplicacao = App.intCodigo;
            acesso.bitAtivo = checkBox2.Checked;
            acesso.strToken = token;

            if (selectedAcessoId == 0)
                if (BackofficeMenu.AddAcesso(acesso) == 0)
                    MessageBox.Show("Acesso adicionado com sucesso!");
                else
                    MessageBox.Show("Erro ao adicionar o acesso!");
            else
                if (BackofficeMenu.EditAcesso(acesso) == 0)
                    MessageBox.Show("Acesso editado com sucesso!");
                else
                    MessageBox.Show("Erro ao editar o acesso!");

            

            this.Close();
        }
    }
}