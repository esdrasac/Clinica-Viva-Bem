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
    public partial class Medicos : UserControl {
        public Medicos() {
            InitializeComponent();
            }

        private void BtPesquisar_Click(object sender, EventArgs e) {
            pesquisarMedico1.Show();
            cadastrarMedicos1.Hide();
            btPesquisarMedico.Hide();
            btVoltarPesquisaMed.Show();
        }

        private void BtVoltarPesquisa_Click(object sender, EventArgs e) {
            pesquisarMedico1.Hide();
            cadastrarMedicos1.Show();
            btVoltarPesquisaMed.Hide();
            btPesquisarMedico.Show();
        }
    }
    }
