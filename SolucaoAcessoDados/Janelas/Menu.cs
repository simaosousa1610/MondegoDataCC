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
        private Label label3;
        private ComboBox comboBox1;
        private DataGridView dataGridView4;
        private Button button7;
        private Button button6;
        private Button button5;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private IContainer components;

        public Menu(BackofficeMenu backofficeMenu)
        {
            this.backofficeMenu = backofficeMenu;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
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
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 59);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(528, 399);
            this.dataGridView3.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.dataGridView4);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(534, 461);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Registos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Location = new System.Drawing.Point(349, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 101);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 47);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(146, 20);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "Ver Não Validados";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged_1);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 17);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(108, 20);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Ver Inativos";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 110);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(522, 325);
            this.dataGridView4.TabIndex = 11;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Verdana", 8F);
            this.button7.Location = new System.Drawing.Point(224, 70);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 34);
            this.button7.TabIndex = 10;
            this.button7.Text = "Validar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Verdana", 8F);
            this.button6.Location = new System.Drawing.Point(115, 70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 34);
            this.button6.TabIndex = 9;
            this.button6.Text = "Editar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Verdana", 8F);
            this.button5.Location = new System.Drawing.Point(6, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 34);
            this.button5.TabIndex = 8;
            this.button5.Text = "Adicionar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            // comboBox1
            // 
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.dataGridView1.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            LoadOperadores();
            LoadAplicacoes();
            LoadAcessos();
            LoadHistorico();
            LoadResistoHoras();
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

            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.ScrollBars = ScrollBars.Both;
        }
        
        private void LoadAcessos()
        {
            var acessos = backofficeMenu.ListAcessos();
            var operadores = backofficeMenu.ListOperadores();

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

            foreach (DataGridViewColumn column in dataGridView2.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.ScrollBars = ScrollBars.Both;
        }
        
        private void LoadHistorico()
        {
            var historico = backofficeMenu.ListHistorico();

            var historicoToShow = historico.Join(backofficeMenu.ListOperadores(), h => h.intOperador, o => o.intCodigo, (h, o) => new { h.intCodigo, o.strNome, h.dtmDataAcao, h.enuAcao })
                .Join(backofficeMenu.ListAcao(), h => h.enuAcao, a => a.intCodigo, (h, a) => new { h.intCodigo, h.strNome, h.dtmDataAcao, a.tipo })
                .Select(h => new { h.intCodigo, h.strNome, h.tipo, h.dtmDataAcao })
                .OrderByDescending(comparer => comparer.intCodigo)
                .ToList();

            historicoToShow = historicoToShow.Where(h => h.dtmDataAcao >= dateTimePicker1.Value && h.dtmDataAcao <= dateTimePicker2.Value).ToList();

            dataGridView3.DataSource = historicoToShow;

            dataGridView3.Columns["intCodigo"].Visible = false;

            dataGridView3.Columns["strNome"].HeaderText = "Operador";
            dataGridView3.Columns["tipo"].HeaderText = "Ação";
            dataGridView3.Columns["dtmDataAcao"].HeaderText = "Data";

            foreach (DataGridViewColumn column in dataGridView3.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        
        private void LoadAplicacoes()
        {
            var aplicacoes = backofficeMenu.ListAplicacoes();
            Apps.DataSource = aplicacoes;

            Apps.DisplayMember = "strNome";
        }

        private void LoadResistoHoras()
        {
            comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;

            var previousSelectedValue = comboBox1.SelectedValue;

            var operadores = backofficeMenu.ListOperadores();
            comboBox1.DataSource = operadores;
            comboBox1.DisplayMember = "strNome";
            comboBox1.ValueMember = "intCodigo";

            if (previousSelectedValue != null && operadores.Any(o => o.intCodigo == (int)previousSelectedValue))
            {
                comboBox1.SelectedValue = previousSelectedValue;
            }

            var selectedOperadorID = (int)comboBox1.SelectedValue;

            var registos = backofficeMenu.ListRegistosHoras()
                .Where(r => r.intOperador == selectedOperadorID)
                .Select(r => new
                {
                    r.intCodigo,
                    r.dtmInicio,
                    r.dtmFim,
                    r.fltPrecoHora,
                    r.fltPrecoTotal,
                    r.bitValidado,
                    r.bitAtivo
                })
                .OrderByDescending(r => r.intCodigo)
                .ToList();

            if (!checkBox2.Checked)
            {
                registos = registos.Where(r => r.bitAtivo).ToList();
            }

            if (!checkBox3.Checked)
            {
                registos = registos.Where(r => r.bitValidado).ToList();
            }

            dataGridView4.DataSource = registos;

            // Set column headers for the visible columns
            dataGridView4.Columns["intCodigo"].Visible = false;
            dataGridView4.Columns["dtmInicio"].HeaderText = "Inicio";
            dataGridView4.Columns["dtmFim"].HeaderText = "Fim";
            dataGridView4.Columns["fltPrecoHora"].HeaderText = "Preço Hora";
            dataGridView4.Columns["fltPrecoTotal"].HeaderText = "Preço Total";
            dataGridView4.Columns["bitValidado"].HeaderText = "Validado";
            dataGridView4.Columns["bitAtivo"].HeaderText = "Ativo";

            // Set column auto size mode
            foreach (DataGridViewColumn column in dataGridView4.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            AdicionarOperadorForm addForm = new AdicionarOperadorForm(backofficeMenu);
            addForm.ShowDialog();
            this.Menu_Load(sender, e);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedOperadorId = comboBox1.SelectedIndex;
                EditarOperadorForm editForm = new EditarOperadorForm(selectedOperadorId, backofficeMenu);
                editForm.ShowDialog();
                this.Menu_Load(sender, e);
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
                this.Menu_Load(sender, e);
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
            this.Menu_Load(sender, e);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadHistorico();
        }
        
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            LoadHistorico();
        }
        
        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            LoadResistoHoras();
        }
        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            LoadResistoHoras();
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadResistoHoras();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            var selectedOperadorID = (int)comboBox1.SelectedValue;
            NovoEditarRegisto novoRegisto = new NovoEditarRegisto(0, selectedOperadorID, backofficeMenu);
            novoRegisto.ShowDialog();
            this.Menu_Load(sender, e);
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                int selectedRegistoId = (int)dataGridView4.SelectedRows[0].Cells["intCodigo"].Value;
                int selectedOperadorId = (int)comboBox1.SelectedValue;

                NovoEditarRegisto editForm = new NovoEditarRegisto(selectedRegistoId, selectedOperadorId, backofficeMenu);
                editForm.ShowDialog();
                this.Menu_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um registo para editar.");
            }
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                int selectedRegistoId = (int)dataGridView4.SelectedRows[0].Cells["intCodigo"].Value;
                int selectedOperadorId = (int)comboBox1.SelectedValue;
                var result = backofficeMenu.ValidarRegisto(selectedRegistoId);

                MessageBox.Show(result == 0 ? "Registo validado com sucesso!" : "Erro ao validar o registo.");

                LoadResistoHoras();
            }
        }
    }
}