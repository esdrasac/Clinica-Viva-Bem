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
    public partial class Pacientes : UserControl
    {
        public Pacientes()
        {
            InitializeComponent();
        }

        private void BtPesquisarMedico_Click(object sender, EventArgs e) {
            pesquisarPacientes1.BringToFront();
            btVoltarPesquisaPaciente.BringToFront();
            cadastrarPacientes1.Refresh();
        }

        private void BtVoltarPesquisaMed_Click(object sender, EventArgs e) {
            cadastrarPacientes1.BringToFront();
            btPesquisarPaciente.BringToFront();
            pesquisarPacientes1.Refresh();
        }
    }
}
