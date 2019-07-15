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
    public partial class CadastrarPacientes : UserControl {
        public CadastrarPacientes() {
            InitializeComponent();
        }

           
        
        private void BtCadastrarMedico_Click(object sender, EventArgs e) {
            idPaciente.Hide();
            string telefonePacienteFormatado = TextNoFormatting(telefonePaciente);
            string dataFormatada = TextNoFormatting(dateTimePicker1);
            if (nomePaciente.Text != "" && !String.IsNullOrEmpty(telefonePacienteFormatado) && enderecoPaciente.Text != "" && cidadePaciente.Text != "" && estadoPaciente.Text != "") {
                PacientesClass paciente = new PacientesClass();
                string enderecocompleto = enderecoPaciente.Text + ", " + cidadePaciente.Text + ", " + estadoPaciente.Text;
                idPaciente.Text = paciente.CadastrarPaciente(nomePaciente.Text, dateTimePicker1.Text, enderecocompleto, telefonePaciente.Text);
                
                label9.Show();
                label9.BringToFront();
                idPaciente.Show();
                idPaciente.BringToFront();
                resultadoPesquisa2.Show();
                button1.Show();
                button1.BringToFront();
                button1.Focus();
                nomePaciente.Text = "";
                dateTimePicker1.Text = "";
                enderecoPaciente.Text = "";
                cidadePaciente.Text = "";
                estadoPaciente.Text = "";
                telefonePaciente.Text = "";
                
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
        private void Button1_Click(object sender, EventArgs e) {
            label9.Hide();
            idPaciente.Hide();
            resultadoPesquisa2.Hide();
            btCadastrarMedico.Show();
            button1.Hide();
        }


        private void CadastrarPacientes_Load(object sender, EventArgs e) {
            resultadoPesquisa2.Hide();
            button1.Hide();
        }

    }
}
