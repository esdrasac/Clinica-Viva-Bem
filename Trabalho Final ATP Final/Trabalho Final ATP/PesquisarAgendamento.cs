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
    public partial class PesquisarAgendamento : UserControl {
        public PesquisarAgendamento() {
            InitializeComponent();
        }

        private void DataPesquisar_ValueChanged(object sender, EventArgs e) {
            if (datapesquisa.Text != "") {
                listView1.Items.Clear();
                ConsultasClass pesquisa = new ConsultasClass();
                string resultado = pesquisa.PesquisarConsulta(datapesquisa.Text);
                btexcluirMed.Show();
                
                string[] texto = resultado.Split('*');

                for (int i = 0; i < texto.Length; i++) {
                    string[] aux = texto[i].Split('+');
                    ListViewItem lista = new ListViewItem(aux);           
                        listView1.Items.Add(lista);
                    
                }
                
                listView1.Show();
                btexcluirMed.Show();
                listView1.BringToFront();
            }
        }

        private void BtexcluirMed_Click(object sender, EventArgs e) {
            if (listView1.Items.Count > 0) {
                if ((MessageBox.Show("Tem certeza que deseja cancelar esta consulta?", "Cancelar consulta", MessageBoxButtons.YesNo) == DialogResult.Yes)) {

                    string excluir = listView1.SelectedItems[0].Text;
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    ConsultasClass cancelarconsulta = new ConsultasClass();
                    cancelarconsulta.CancelarConsulta(excluir);
                    listView1.Refresh();
                }
            }
            else {
                MessageBox.Show("Selecione uma consulta");
            }
        }
    }
}
