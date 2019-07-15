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
    public partial class PesquisarMedico : UserControl {
        public PesquisarMedico() {
            InitializeComponent();
        }

        private void BtPesquisar_Click(object sender, EventArgs e) {

            if (nomeMedico.Text != "") {
                listView1.Items.Clear();
                MedicosClass pesquisa = new MedicosClass();
                string resultado =  pesquisa.PesquisarMedico(nomeMedico.Text.ToUpper());
                btexcluirMed.Show();
                btNovaPesquisaMed.Show();

                string[] texto = resultado.Split('*');

                for (int i = 0; i < texto.Length; i++) {
                    string[] aux = texto[i].Split('+');

                    ListViewItem lista = new ListViewItem(aux);

                    listView1.Items.Add(lista);
                }

                listView1.Show();
                btexcluirMed.Show();
                btNovaPesquisaMed.Show();
                btHistorico.Show();
                listView1.BringToFront();
            }
            else {
                MessageBox.Show("Digite uma pesquisa");
            }
        }

        private void BtNovaPesquisaMed_Click(object sender, EventArgs e) {
            labelresultPesquisaMed.Text = "";
            btNovaPesquisaMed.Hide();
            btexcluirMed.Hide();
            btHistorico.Hide();
            listView2.Hide();
            nomeMedico.Text = "";
            listView1.Hide();
            

        }

        private void BtexcluirMed_Click(object sender, EventArgs e) {
            if (listView1.Items.Count > 0) {
                if ((MessageBox.Show("Tem certeza que deseja excluir este cadastro?", "Excluir cadastro", MessageBoxButtons.YesNo) == DialogResult.Yes)) {

                    string excluir = listView1.SelectedItems[0].Text;
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    MedicosClass excluircadastro = new MedicosClass();
                    excluircadastro.ExcluirMedico(excluir);
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
                    MedicosClass historico2 = new MedicosClass();
                    string resultado = historico2.HistoricoMedico(historico);
                    string[] texto = resultado.Split('*');

                    for(int i = 0; i < texto.Length - 1; i++) {
                        string[] aux = texto[i].Split('+');


                        ListViewItem lista = new ListViewItem(aux);

                        listView2.Items.Add(lista);


                    }

                    listView2.Show();
                    listView2.BringToFront();
                    listView2.Refresh();
                    btexcluirMed.Hide();
                    back.Show();
                    back.BringToFront();
                }
                catch(Exception) {
                    MessageBox.Show("Selecione um Médico");
                }

            }
            else {
                MessageBox.Show("Lista Vazia");
            }
        }

        private void Back_Click(object sender, EventArgs e) {
            listView2.Items.Clear();
            listView2.Hide();
            btexcluirMed.Show();
            back.Hide();
            listView2.Refresh();
        }
    }
}
