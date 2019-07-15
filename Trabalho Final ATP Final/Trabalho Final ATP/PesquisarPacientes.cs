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
    public partial class PesquisarPacientes : UserControl {
        public PesquisarPacientes() {
            InitializeComponent();
        }

        private void BtPesquisar_Click(object sender, EventArgs e) {
            if (nomePaciente.Text != "") {

                listView1.Items.Clear();

                PacientesClass pac = new PacientesClass();

                string resultado = pac.PesquisarPaciente(nomePaciente.Text.ToUpper());
                string[] texto = resultado.Split('*');

                for (int i = 0; i < texto.Length - 1; i++) {
                    string[] aux = texto[i].Split('+');

                    ListViewItem lista = new ListViewItem(aux);

                    listView1.Items.Add(lista);


                }

                listView1.Show();
                btexcluirPac.Show();
                btHistorico.Show();
                btNovaPesquisaPac.Show();
                listView1.BringToFront();
                
                
            }
            else {
                MessageBox.Show("Digite uma pesquisa");

            }
        }

        private void BtNovaPesquisaPac_Click(object sender, EventArgs e) {
            btNovaPesquisaPac.Hide();
            btexcluirPac.Hide();
            btHistorico.Hide();
            nomePaciente.Text = "";
            listView1.Hide();
            listView2.Hide();


        }

        private void PesquisarPacientes_Load(object sender, EventArgs e) {

        }

        private void BtexcluirPac_Click(object sender, EventArgs e) {



            if (listView1.Items.Count > 0) {
                if ((MessageBox.Show("Tem certeza que deseja excluir este cadastro?", "Excluir cadastro", MessageBoxButtons.YesNo) == DialogResult.Yes)){

                    string excluir = listView1.SelectedItems[0].Text;
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    PacientesClass excluircadastro = new PacientesClass();
                    excluircadastro.ExcluirPaciente(excluir);
                    listView1.Refresh();
                    
                }
            }
            else {
                MessageBox.Show("Selecione um cadastro");
            }



        }

        private void BtHistorico_Click(object sender, EventArgs e) {
            
            if (listView1.Items.Count > 0) {
                try {
                    string historico = listView1.SelectedItems[0].Text;
                    PacientesClass historico2 = new PacientesClass();
                    string resultado = historico2.HistoricoPaciente(historico);
                    string[] texto = resultado.Split('*');

                    for(int i = 0; i < texto.Length - 1; i++) {
                        string[] aux = texto[i].Split('+');

                        ListViewItem lista = new ListViewItem(aux);

                        listView2.Items.Add(lista);


                    }

                    listView2.Show();
                    listView2.BringToFront();
                    listView2.Refresh();
                    btexcluirPac.Hide();
                    back.Show();
                    back.BringToFront();
                }
                catch(Exception) {
                    MessageBox.Show("Selecione um paciente");
                }
            }
            else {
                MessageBox.Show("Lista Vazia");
            }
        }

        private void Back_Click(object sender, EventArgs e) {
            listView2.Items.Clear();
            listView2.Hide();
            btexcluirPac.Show();
            back.Hide();
        }
    }
}
