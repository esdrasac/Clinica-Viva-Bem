using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final_ATP
{
    public partial class marcaragendamento1 : UserControl
    {
        public marcaragendamento1()
        {
            InitializeComponent();
        }

        private void BtMarcarAgenda_Click(object sender, EventArgs e) {
            if  (pacienteAgenda.Text != "" && medicoAgenda.Text != "" && dataAgenda.Text != "" && horaAgenda.Text != "") {
                ConsultasClass consulta = new ConsultasClass();
                idconsultaAgenda.Text = consulta.CadastrarConsulta(pacienteAgenda.Text.ToUpper(), medicoAgenda.Text.ToUpper(), dataAgenda.Text, horaAgenda.Text);
                if (idconsultaAgenda.Text == "erro") {
                    pacienteAgenda.Text = "";
                    medicoAgenda.Text = "";
                    
                }
                else if(idconsultaAgenda.Text == "data erro") {
                    dataAgenda.Text = "";
                    horaAgenda.Text = "";
                }
                else if(idconsultaAgenda.Text == "medico erro") {
                    pacienteAgenda.Text = "";
                    medicoAgenda.Text = "";
                    dataAgenda.Text = "";
                    horaAgenda.Text = "";
                }
                else {
                    resultadoPesquisa1.Show();
                    btNovaPesquisa.Show();
                    btNovaPesquisa.BringToFront();
                    label9.Show();
                    idconsultaAgenda.Show();
                    pacienteAgenda.Text = "";
                    medicoAgenda.Text = "";
                    dataAgenda.Text = null;
                    horaAgenda.Text = "";
                    this.Refresh();
                }
            }
        }

        private void BtNovaPesquisa_Click(object sender, EventArgs e) {
            resultadoPesquisa1.Hide();
            btNovaPesquisa.Hide();
            label9.Hide();
            idconsultaAgenda.Hide();

        }

        private void ResultadoPesquisa1_Load(object sender, EventArgs e) {

        }
    }
}
