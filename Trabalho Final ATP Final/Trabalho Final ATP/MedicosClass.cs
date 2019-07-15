using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final_ATP {
    class MedicosClass {

        public string Nomemed { get; private set; }
        public string Codmed { get; private set; }
        public string Especialidademed { get; private set; }
        public string Telemed { get; private set; }

        public MedicosClass(string nomemed, string especialidademed, string telemed) {
            Nomemed = nomemed;
            Especialidademed = especialidademed;
            Telemed = telemed;
        }

        public MedicosClass() {
        }

        //Gera um id aleatório
        public int IdAleatrio() { 
            int codaleatorio;
            Random aleatorio = new Random();
            codaleatorio = aleatorio.Next(0, 99999);
            FileStream arqcod = new FileStream("cadastropaciente.txt", FileMode.OpenOrCreate);
            StreamReader ler = new StreamReader(arqcod);
            string textocompleto;
            textocompleto = ler.ReadToEnd();
            string linha;
            if(textocompleto != null) {
                do {
                    linha = ler.ReadLine();
                    if(linha != null) { // le a linha enquanto for diferente de null
                        if(linha.Contains(codaleatorio.ToString())) {
                            codaleatorio = aleatorio.Next(0, 99999);
                        }
                    }
                } while(linha != null);

            }
            ler.Close();
            arqcod.Close();
            return codaleatorio;

        }
        //Cadastra o médico
        public string CadastrarMedico(string nome, string espec, string tel) {


            string cod;
            cod = IdAleatrio().ToString();
            FileStream arqmed = new FileStream("cadastromedico.txt", FileMode.Append);
            StreamWriter escrevemed = new StreamWriter(arqmed);
            MedicosClass cadmed = new MedicosClass(nome, espec, tel);
            escrevemed.WriteLine($"{cod}*{nome.ToUpper()}*{espec.ToUpper()}*{tel}");
            escrevemed.Close();
            arqmed.Close();
            return cod;
        }

        public string PesquisarMedico(string nome) { //Pesquisa o médico
            FileStream arqpesquisamed = new FileStream("cadastromedico.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arqpesquisamed);
            string linha;
            string resultado = "";
            string[] texto;
            do {
                linha = ler.ReadLine();
                if (linha != null) {
                    if (linha.Contains(nome)) {
                        texto = linha.Split('*');
                        resultado += texto[0] + "+" + texto[1] + "+" + texto[2] + "+" + texto[3] + "*";
                    }
                }
            } while (linha != null);
            ler.Close();
            arqpesquisamed.Close();
            return resultado;
         
        }

        public void ExcluirMedico(string id) { // Entre as funções extras >>>> Exclui cadastro de médcio
            FileStream arqexcluirpac = new FileStream("cadastromedico.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arqexcluirpac);
            string linha;
            string texto = null;
            do {
                linha = ler.ReadLine();
                if(linha != null) {
                    if(!linha.Contains(id) && linha != "") {
                        texto += "\n" + linha;
                    }
                }
            } while(linha != null);
            ler.Close();
            arqexcluirpac.Close();

            FileStream arqexcluirpac2 = new FileStream("cadastromedico.txt", FileMode.Create);
            StreamWriter excluir = new StreamWriter(arqexcluirpac2);
            excluir.WriteLine(texto);
            excluir.Close();
            arqexcluirpac2.Close();

        }
        public string HistoricoMedico(string id) { //Puxa o histórico do médcico
            FileStream arqpesquisapac = new FileStream("cadastroconsulta.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arqpesquisapac);
            string linha;
            string resultado = "";
            string[] texto;
            do {
                linha = ler.ReadLine();
                if (linha != null) {
                    if (linha.Contains(id)) {
                        texto = linha.Split('*');
                        resultado += texto[0] + "+" + texto[6] + "+" + texto[4] + "*";

                    }
                }
            } while (linha != null);
            ler.Close();
            arqpesquisapac.Close();
            return resultado;
        }
    }
}
