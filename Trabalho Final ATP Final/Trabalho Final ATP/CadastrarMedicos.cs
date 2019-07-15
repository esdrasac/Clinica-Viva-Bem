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
    public partial class CadastrarMedicos : UserControl {
        public CadastrarMedicos() {
            InitializeComponent();
        }


        public void BtCadastrarMedico_Click_1(object sender, EventArgs e) {
            label1.Hide();
            textBox1.Hide();
            string telefoneMedicoFormatado = TextNoFormatting(telefoneMedico);
            if (nomeMedico.Text != "" && especialidadeMedico.Text != "" && telefoneMedicoFormatado != "") {
                MedicosClass med = new MedicosClass();
                textBox1.Text = med.CadastrarMedico(nomeMedico.Text, especialidadeMedico.Text, telefoneMedico.Text);
                string nome = nomeMedico.Text;
                nomeMedico.Text = "";
                especialidadeMedico.Text = "";
                telefoneMedico.Text = "";
                resultadoPesquisa1.Show();
                btNovaPesquisa.Show();
                btNovaPesquisa.BringToFront();
                btNovaPesquisa.Focus();
                label1.Show();
                label1.BringToFront();
                textBox1.Show();
                textBox1.BringToFront();
            }

            else {
                MessageBox.Show("Preencha todos os campos");
            }


        }
        public string TextNoFormatting(MaskedTextBox _mask) {
            _mask.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            String retString = _mask.Text;
            _mask.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return retString;
        }
            private void BtNovaPesquisa_Click(object sender, EventArgs e) {
            resultadoPesquisa1.Hide();
            label1.Hide();
            textBox1.Hide();
            btNovaPesquisa.Hide();
        }
    }
}
