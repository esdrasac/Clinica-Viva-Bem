using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final_ATP {
    public partial class Agendamento : UserControl {
        public Agendamento() {
            InitializeComponent();
            }

        private void BtPesquisar_Click(object sender, EventArgs e)
        {
            pesquisarAgendamento1.BringToFront();
            btVoltarPesquisa.BringToFront();
        }

        private void BtVoltarPesquisa_Click(object sender, EventArgs e)
        {
            marcarAgendamento1.BringToFront();
            btPesquisar.BringToFront();
        }
    }
    }
