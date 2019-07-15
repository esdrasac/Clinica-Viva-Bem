using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Trabalho_Final_ATP {
    public partial class Home : UserControl {
        public Home() {
            InitializeComponent();
        }


        public void Home_Load(object sender, EventArgs e) { // Função extra>>>>>> carrega altomaticamente as consultas do dia na pagina home
            label4.Text = ConsultasDoDia();
            

            }

        public string ConsultasDoDia() {
            label3.Text = DateTime.Now.ToLocalTime().ToShortDateString();
            FileStream arq = new FileStream("cadastroconsulta.txt", FileMode.OpenOrCreate);
            StreamReader ler = new StreamReader(arq);
            string linha;
            string aux = "";
            string[] texto;
            do {
                linha = ler.ReadLine();
                if(linha != null) {
                    if(linha.Contains(label3.Text)) {
                        texto = linha.Split('*');
                        aux += $"{texto[7]} > PACIENTE {texto[4]} COM O MÉDICO {texto[1]}\n";
                    }
                }
            } while(linha != null);
            ler.Close();
            arq.Close();
            return aux;
        }
    }
}
