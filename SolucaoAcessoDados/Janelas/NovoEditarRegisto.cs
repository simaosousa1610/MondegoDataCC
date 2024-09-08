using Controladores;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Janelas
{
    public partial class NovoEditarRegisto : Form
    {
        int selectedOperadorID;
        int selectedRegistoID;
        BackofficeMenu BackofficeMenu;

        public NovoEditarRegisto(int selectedRegistoID, int selectedOperadorID, BackofficeMenu backofficeMenu)
        {
            this.BackofficeMenu = backofficeMenu;
            this.selectedOperadorID = selectedOperadorID;
            this.selectedRegistoID = selectedRegistoID;
            InitializeComponent();
        }

        private void NovoEditarRegisto_Load(object sender, EventArgs e)
        {
            if (selectedRegistoID != 0)
            {
                var registo = BackofficeMenu.GetRegistoHoras(selectedRegistoID);

                dateTimePicker1.Value = registo.dtmInicio.Date;
                dateTimePicker3.Value = registo.dtmInicio.Date + registo.dtmInicio.TimeOfDay; dateTimePicker2.Value = registo.dtmFim;

                dateTimePicker2.Value = registo.dtmFim.Date;
                dateTimePicker4.Value = registo.dtmFim.Date + registo.dtmFim.TimeOfDay;

                textBox4.Text = registo.fltPrecoHora.ToString();
                textBox5.Text = registo.fltPrecoTotal.ToString();

                checkBox3.Checked = registo.bitValidado;
                checkBox1.Checked = registo.bitAtivo;
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
                textBox4.Text = "0";
                textBox5.Text = "0";
                checkBox1.Checked = true;
                checkBox3.Checked = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (BackofficeMenu != null)
            {
                RegistoHoras registo = new RegistoHoras();

                registo.intOperador = selectedOperadorID;

                DateTime dtmInicio = dateTimePicker1.Value.Date +
                    dateTimePicker3.Value.TimeOfDay;
                DateTime dtmFim = dateTimePicker2.Value.Date +
                    dateTimePicker4.Value.TimeOfDay;

                registo.dtmInicio = dtmInicio;
                registo.dtmFim = dtmFim;

                registo.bitAtivo = checkBox1.Checked ? true : false;
                registo.bitValidado = checkBox3.Checked ? true : false;

                registo.fltPrecoHora = (float)Convert.ToDouble(textBox4.Text);
                registo.fltPrecoTotal = (float)Convert.ToDouble(textBox5.Text);

                if (selectedRegistoID == 0) {
                    if (BackofficeMenu.AddRegisto(registo) == 0)
                        this.Close();
                }
                else
                {
                    registo.intCodigo = selectedRegistoID;
                    if (BackofficeMenu.EditRegisto(registo) == 0)
                        this.Close();
                }

            }
        }
    }
}
