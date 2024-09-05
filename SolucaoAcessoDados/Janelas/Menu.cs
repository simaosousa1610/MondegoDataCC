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
    public partial class Menu : Form
    {

        private BackofficeMenu backofficeMenu = new BackofficeMenu();
        private TabPage tabPage4;
        private TabPage tabPage3;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private Button button4;
        private Button button3;
        private TabPage tabPage1;
        private CheckBox checkBox1;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private ListBox Apps;
        private DataGridView dataGridView3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ListBox listBox1;
        private Label label3;
        private ComboBox comboBox1;
        private IContainer components;

        public Menu(BackofficeMenu backofficeMenu)
        {
            this.backofficeMenu = backofficeMenu;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Apps = new System.Windows.Forms.ListBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.dateTimePicker2);
            this.tabPage4.Controls.Add(this.dateTimePicker1);
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(534, 461);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Histórico";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(534, 461);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Registos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.Apps);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(534, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Acessos";
            // 
            // Apps
            // 
            this.Apps.Font = new System.Drawing.Font("Verdana", 10F);
            this.Apps.FormattingEnabled = true;
            this.Apps.ItemHeight = 20;
            this.Apps.Location = new System.Drawing.Point(8, 46);
            this.Apps.Name = "Apps";
            this.Apps.ScrollAlwaysVisible = true;
            this.Apps.Size = new System.Drawing.Size(159, 404);
            this.Apps.TabIndex = 6;
            this.Apps.SelectedIndexChanged += new System.EventHandler(this.Aplicações_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(173, 46);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(355, 404);
            this.dataGridView2.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Verdana", 8F);
            this.button4.Location = new System.Drawing.Point(282, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "Editar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 8F);
            this.button3.Location = new System.Drawing.Point(173, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Adicionar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(534, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Operadores";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(420, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Ver Inativos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(522, 409);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 10F);
            this.tabControl1.ItemSize = new System.Drawing.Size(130, 30);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(542, 499);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 59);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(528, 399);
            this.dataGridView3.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(50, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 23);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2024, 9, 5, 22, 4, 45, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(233, 19);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(104, 23);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label1.Location = new System.Drawing.Point(2, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label2.Location = new System.Drawing.Point(198, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fim";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Operador";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Verdana", 10F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(360, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(159, 84);
            this.listBox1.TabIndex = 7;
            // 
            // Menu
            // 
            this.ClientSize = new System.Drawing.Size(566, 523);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu BackOffice";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            LoadOperadores();
            LoadAplicacoes();
            LoadAcessos();
            LoadHistorico();
        }


        private void LoadOperadores()
        {
            var operadores = backofficeMenu.ListOperadores();

            if (!checkBox1.Checked)
            {
                operadores = operadores.Where(o => o.bitAtivo).ToList();
            }

            dataGridView1.DataSource = operadores;

            dataGridView1.Columns["strPasswordHash"].Visible = false;
            dataGridView1.Columns["strPasswordSalt"].Visible = false;
            dataGridView1.Columns["fltPrecoHora"].Visible = false;
            dataGridView1.Columns["bitAtivo"].Visible = false;

            dataGridView1.Columns["intCodigo"].HeaderText = "Código";
            dataGridView1.Columns["strNome"].HeaderText = "Nome";

            dataGridView1.Columns["intCodigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["strNome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.ScrollBars = ScrollBars.Both;

        }

        private void LoadAcessos()
        {
            var acessos = backofficeMenu.ListAcessos();
            var operadores = backofficeMenu.ListOperadores();

            // Load only the acessos that are related to the selected app
            if (Apps.SelectedItem != null)
            {
                var selectedApp = (Aplicacao)Apps.SelectedItem;
                acessos = acessos.Where(a => a.intAplicacao == selectedApp.intCodigo).ToList();
            }

            var acessosToShow = acessos.Join(operadores, a => a.intOperador, o => o.intCodigo, (a, o) => new { a.intCodigo, o.strNome, a.bitAtivo }).ToList();

            dataGridView2.DataSource = acessosToShow;

            dataGridView2.Columns["intCodigo"].HeaderText = "Código";
            dataGridView2.Columns["strNome"].HeaderText = "Nome";

            dataGridView2.Columns["bitAtivo"].HeaderText = "Ativo";
            dataGridView2.Columns["bitAtivo"].DefaultCellStyle.NullValue = "X";

            dataGridView2.Columns["intCodigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns["strNome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView2.ScrollBars = ScrollBars.Both;
        }
        
        private void LoadHistorico()
        {
            var historico = backofficeMenu.ListHistorico();

            // show operador name instead of id, tipo of action instead of id, and date in a readable format
            // join the historico with the operadores, acao and convert the date to a readable format
            var historicoToShow = historico.Join(backofficeMenu.ListOperadores(), h => h.intOperador, o => o.intCodigo, (h, o) => new { h.intCodigo, o.strNome, h.dtmDataAcao, h.enuAcao })
                .Join(backofficeMenu.ListAcao(), h => h.enuAcao, a => a.intCodigo, (h, a) => new { h.intCodigo, h.strNome, h.dtmDataAcao, a.tipo })
                .Select(h => new { h.intCodigo, h.strNome, h.tipo, h.dtmDataAcao }).ToList();


            // only show records between the selected dates
            historicoToShow = historicoToShow.Where(h => h.dtmDataAcao >= dateTimePicker1.Value && h.dtmDataAcao <= dateTimePicker2.Value).ToList();

            dataGridView3.DataSource = historicoToShow;

            dataGridView3.Columns["intCodigo"].Visible = false;

            dataGridView3.Columns["strNome"].HeaderText = "Operador";
            dataGridView3.Columns["tipo"].HeaderText = "Ação";
            dataGridView3.Columns["dtmDataAcao"].HeaderText = "Data";

            dataGridView3.Columns["strNome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.Columns["tipo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.Columns["dtmDataAcao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        private void LoadAplicacoes()
        {
            var aplicacoes = backofficeMenu.ListAplicacoes();
            Apps.DataSource = aplicacoes;

            // show the Aplicacao name
            Apps.DisplayMember = "strNome";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            AdicionarOperadorForm addForm = new AdicionarOperadorForm(backofficeMenu);
            addForm.ShowDialog();
            LoadOperadores();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedOperadorId = (int)dataGridView1.SelectedRows[0].Cells["intCodigo"].Value;
                EditarOperadorForm editForm = new EditarOperadorForm(selectedOperadorId, backofficeMenu);
                editForm.ShowDialog();
                LoadOperadores();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um operador para editar.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LoadOperadores();
        }

        private void Aplicações_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAcessos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int selectedAcessoId = (int)dataGridView2.SelectedRows[0].Cells["intCodigo"].Value;
                EditarAcessoForm editForm = new EditarAcessoForm(selectedAcessoId, backofficeMenu, (Aplicacao)Apps.SelectedItem);
                editForm.ShowDialog();
                LoadAcessos();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um acesso para editar.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditarAcessoForm editForm = new EditarAcessoForm(backofficeMenu, (Aplicacao)Apps.SelectedItem);
            editForm.ShowDialog();
            LoadAcessos();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadHistorico();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            LoadHistorico();
        }
    }

}