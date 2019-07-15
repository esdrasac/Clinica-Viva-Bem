using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final_ATP {
    class PacientesClass {
        public string Codpaciente { get; private set; }
        public string Nomepaciente { get; private set; }
        public string Datapaciente { get; private set; }
        public string Enderecopaciente { get; private set; }
        public string Telefonepaciente { get; private set; }


        public PacientesClass(string nomepaciente, string enderecopaciente, string telefonepaciente, string datapaciente) {
            Nomepaciente = nomepaciente;
            Datapaciente = datapaciente;
            Enderecopaciente = enderecopaciente;
            Telefonepaciente = telefonepaciente;

        }

        public PacientesClass() {
        }
        // Gera um codigo aleatório
        public int IdAleatrio() {
            int codaleatorio;
            Random aleatorio = new Random();
            codaleatorio = aleatorio.Next(0, 99999);
            FileStream arqcod = new FileStream("cadastropaciente.txt", FileMode.OpenOrCreate);
            StreamReader ler = new StreamReader(arqcod);
            string linha;
            string textocompleto;
            textocompleto = ler.ReadToEnd();
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

        public string CadastrarPaciente(string nome, string data, string endereco, string telefone) {// Função para cadastrar o paciente
            string cod = IdAleatrio().ToString(); 
            MedicosClass aux = new MedicosClass();
            FileStream arqpac = new FileStream("cadastropaciente.txt", FileMode.Append);
            StreamWriter escrevepac = new StreamWriter(arqpac);
            PacientesClass cadpac = new PacientesClass(nome, data, endereco, telefone);
            
            
            escrevepac.WriteLine($"{cod}*{nome.ToUpper()}*{data}*{endereco.ToUpper()}*{telefone}");
            escrevepac.Close();
            arqpac.Close();
            return cod;
        }


        public string PesquisarPaciente(string nome) { //Funçao para pesquisar o paciente
            FileStream arqpesquisapac = new FileStream("cadastropaciente.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arqpesquisapac);
            string linha;
            string resultado = "";
            string[] texto;
            do {
                linha = ler.ReadLine();
                if(linha != null) {// le o arqquivvo enquanto a linha for diferente de null
                    if(linha.Contains(nome)) {
                        texto = linha.Split('*');
                        resultado +=/*id*/ texto[0] + "+" /*nome*/ + texto[1] + "+" /*nascimento*/ + texto[2] + "+" /*endereço*/ + texto[3] + "+" /*telefone*/ + texto[4] + "*";

                    }
                }
            } while(linha != null);
            ler.Close();
            arqpesquisapac.Close();
            return resultado;
        }


        public void ExcluirPaciente(string id) { // Função extra de excluir paciente já cadastrado
            FileStream arqexcluirpac = new FileStream("cadastropaciente.txt", FileMode.Open);
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

            FileStream arqexcluirpac2 = new FileStream("cadastropaciente.txt", FileMode.Create);
            StreamWriter excluir = new StreamWriter(arqexcluirpac2);
            excluir.WriteLine(texto);
            excluir.Close();
            arqexcluirpac2.Close();

        }

        public string HistoricoPaciente(string id) {// Função que mostra o historico de todos as consultas de um determinado paciente
            FileStream arqpesquisapac = new FileStream("cadastroconsulta.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arqpesquisapac);
            string linha;
            string resultado = "";
            string[] texto;
            do {
                linha = ler.ReadLine();
                if(linha != null) {
                    if(linha.Contains(id)) {
                        texto = linha.Split('*');
                        bool aux = datasAnteiores(texto[6]);
                        if(aux == true) {
                            resultado += texto[0] + "+" + texto[6] + "+" + texto[1] + "+" + texto[2] + "*";
                        }
                    }
                }
            } while(linha != null);
            ler.Close();
            arqpesquisapac.Close();
            return resultado;
        }

        public static bool datasAnteiores(String data) // A FUNÇÃO É BOOL INTENCIONALMENTE
 {
            DateTime hojeDate = DateTime.Today; // DATA E HORA ATUAL
            String aux = hojeDate.ToString(); // AUX RECEBE A DATA E HORA ATUAL EM STRING
            //00:00 13/04/2000
            String hoje = "";
            String diaAS = "", mesAS = "", anoAS = "", diaDS = "", mesDS = "",
           anoDS = "";
            int diaA, mesA, anoA, diaD, mesD, anoD;
            int i;
            for(i = 0; i < 10; i++) {
                hoje += aux[i]; // PARA IGNORAR A HORA ATUAL E DEIXAR SÓ A DATA (DE "20/06/2019 12:55" o valor passa a ser "20/06/2019")

            }
            // TODOS ESSES FOR's EXISTEM PARA SEPARAR O DIA,MES E ANO EM VARIÁVEIS STRINGS DIFERENTES
            for(i = 0; i < 2; i++) {
                diaAS += hoje[i];
                diaDS += data[i];
            }
            for(i = 3; i < 5; i++) {
                mesAS += hoje[i];
                mesDS += data[i];
            }
            for(i = 6; i < 10; i++) {
                anoAS += hoje[i];
                anoDS += data[i];
            }
            // DEPOIS QUE SEPARAMOS, TEMOS QUE PASSAR TUDO PARA INT PARA QUE SEJA POSSÍVEL COMPARAR VALORES MAIORES E MENORES
            diaA = int.Parse(diaAS);
            diaD = int.Parse(diaDS);
            mesA = int.Parse(mesAS);
            mesD = int.Parse(mesDS);
            anoA = int.Parse(anoAS);
            anoD = int.Parse(anoDS);
            //HORA DA COMPARAÇÃO: CASO A DATA SEJA MAIOR: RETORNA FALSE, CASO SEJA MENOR: RETORNA TRUE
            if(anoA < anoD) return false;

            else if(anoA <= anoD && mesA < mesD) return false;

            else if(anoA <= anoD && mesA <= mesD && diaA < diaD) return false;
            else return true;
        }
    }
}
