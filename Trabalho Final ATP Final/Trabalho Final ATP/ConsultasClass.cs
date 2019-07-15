using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final_ATP {
    class ConsultasClass {
        public string CodConsul { get; private set; }
        public string DataConsul { get; private set; }
        public string HoraConsul { get; private set; }
        public string NomeMed { get; private set; }
        public string NomePac { get; private set; }
        public string CodMed { get; private set; }
        public string CodPac { get; private set; }

        public ConsultasClass(string dataConsul, string horaConsul, string nomeMed, string nomePac) {
            DataConsul = dataConsul;
            HoraConsul = horaConsul;
            NomeMed = nomeMed;
            NomePac = nomePac;
        }

        public ConsultasClass() {
        }
        // Gerador de ID aleatorio
        public int IdAleatrio() {
            int codaleatorio;
            Random aleatorio = new Random();
            codaleatorio = aleatorio.Next(0, 99999);
            FileStream arqdata = new FileStream("cadastroconsulta.txt", FileMode.OpenOrCreate);
            StreamReader ler = new StreamReader(arqdata);
            string linha;
            string textocompleto;
            textocompleto = ler.ReadToEnd();
            if(textocompleto != null) {
                do {
                    linha = ler.ReadLine();
                    if(linha != null) {
                        if(linha.Contains(codaleatorio.ToString())) {
                            codaleatorio = aleatorio.Next(0, 99999);
                        }
                    }
                } while(linha != null);
            }
            ler.Close();
            arqdata.Close();
            return codaleatorio;
        }

        //Encontra o Código do méico digitado para a função cadastrar consulta
        public string[] FindMedCode(string nomecompleto) {
            FileStream med = new FileStream("cadastromedico.txt", FileMode.Open);
            StreamReader ler = new StreamReader(med);
            string linha;
            string[] resultado = new string[3];
            string[] texto;
            do {
                linha = ler.ReadLine();
                if (linha != null) {
                    if (linha.Contains(nomecompleto)) {
                        texto = linha.Split('*');
                        resultado[0] = texto[0];
                        resultado[1] = texto[1];
                        resultado[2] = texto[2];
                    }
                }
            } while (linha != null);
            ler.Close();
            med.Close();
            return resultado;
        }

        //Encontra o código do paciente para a função cadastrar consulta
        public string[] FindPacCode(string nomecompleto) {
            FileStream pac = new FileStream("cadastropaciente.txt", FileMode.Open);
            StreamReader ler = new StreamReader(pac);
            string linha;
            string[] resultado = new string[2];
            string[] texto;
            do {
                linha = ler.ReadLine();
                if (linha != null) {
                    if (linha.Contains(nomecompleto)) {
                        texto = linha.Split('*');
                        resultado[0] = texto[0];
                        resultado[1] = texto[1];
                    }
                }
            } while (linha != null);
            ler.Close();
            pac.Close();
            return resultado;
        }
        // Cadastrar médico
        public string CadastrarConsulta(string nomepaciente, string nomemedico, string dataconsulta, string horaconsulta) {
            string cod;
            string[] codmed = new string[3];
            string[] codpac = new string[2];
            cod = IdAleatrio().ToString();

            FileStream arqdata = new FileStream("cadastroconsulta.txt", FileMode.OpenOrCreate);
            StreamReader ler = new StreamReader(arqdata);
            string linha;
            bool validar = true;
            int nomedomedicovalidar = 0;
            

            // VALIDAR HORA DA CONSULTA
            do {
                linha = ler.ReadLine();
                if (linha != null) {
                    if (linha.Contains(nomemedico)) {
                        if (linha.Contains(dataconsulta)) {
                            nomedomedicovalidar++;
                            if (linha.Contains(horaconsulta)) {
                                MessageBox.Show("Horario indisponível");
                                validar = false;
                                cod = "data erro";
                            }
                        }
                    }
                    
                }
            } while (linha != null);
            if (nomedomedicovalidar > 1) {
                MessageBox.Show("Médico Indisponível(Só é permitido ao médico realizar duas consultas por dia)"); //validar se o medico tem mais de duas consultas no dia
                validar = false;
                cod = "medico erro";
            }
            ler.Close();
            arqdata.Close();
            

            if (validar == true) {
                FileStream arqconsul = new FileStream("cadastroconsulta.txt", FileMode.Append);
                StreamWriter escreveconsul = new StreamWriter(arqconsul);
                ConsultasClass aux = new ConsultasClass(dataconsulta, horaconsulta, nomemedico, nomepaciente);

                codmed = aux.FindMedCode(nomemedico);
                codpac = aux.FindPacCode(nomepaciente);

                //VALIDAR SE EXISTE MEDICO E PACIENTE COM O NOME DIGITADO PELO USUARIO
                if (codmed[1] == nomemedico && codpac[1] == nomepaciente) {
                    //CADASTRA A CONSULTA
                    escreveconsul.WriteLine($"{cod}*{nomemedico}*{codmed[2]}*{codmed[0]}*{nomepaciente}*{codpac[0]}*{dataconsulta}*{horaconsulta}");

                }
                else {
                    MessageBox.Show("Médico ou paciente inválido");
                    cod = "erro";
                }

                escreveconsul.Close();
                arqconsul.Close();
            }
            return cod;
        }


        public string PesquisarConsulta(string data) {// realiza a pesquisa 
            FileStream arqdata = new FileStream("cadastroconsulta.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arqdata);
            string linha;
            string resultado = "";
            string[] texto;
            do {
                linha = ler.ReadLine();
                if (linha != null) {
                    if (linha.Contains(data)) {
                        texto = linha.Split('*');
                        resultado += texto[0] + "+" + texto[1] + "+" + texto[2] + "+" + texto[3] + "+" + texto[4] + "+" + texto[7] + "+" + texto[7] + "*";
                    }
                }
            } while (linha != null);
            ler.Close();
            arqdata.Close();
            return resultado;
        }

        public void CancelarConsulta(string id) { //Cancel a consulta  selecionada pelo usuário no listview
            FileStream arqexcluirconsul = new FileStream("cadastroconsulta.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arqexcluirconsul);
            string linha;
            string texto = null;
            int i = 0;
            do {
                linha = ler.ReadLine();
                if(linha != null) {
                    if(!linha.Contains(id) && linha != "") {
                        texto += "\n" + linha;
                    }
                }
            } while(linha != null);
            ler.Close();
            arqexcluirconsul.Close();

            FileStream arqexcluirconsul2 = new FileStream("cadastroconsulta.txt", FileMode.Create);
            StreamWriter excluir = new StreamWriter(arqexcluirconsul2);
            excluir.WriteLine(texto);
            excluir.Close();
            arqexcluirconsul2.Close();

        }
    }
}

