using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final_ATP {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {

            }

        private void panel2_Paint(object sender, PaintEventArgs e) {

            }

        private void pictureBox1_Click(object sender, EventArgs e) {

            }

        private void label1_Click(object sender, EventArgs e) {

            }

        private void btagendamento_Click(object sender, EventArgs e) {
            home.Visible = (false);
            agendamento.Visible = (true);
            medicos.Visible = (false);
            pacientes.Visible = (false);
            agendamento1.BringToFront();
            }

        private void bthome_Click(object sender, EventArgs e) {
            home.Visible = (true);
            agendamento.Visible = (false);
            medicos.Visible = (false);
            pacientes.Visible = (false);
            home1.BringToFront();
            home1.Refresh();
            //Home aux = new Home();
            //aux.label4.Text = aux.ConsultasDoDia()
            //this.();
        }

        private void btmedicos_Click(object sender, EventArgs e) {
            home.Visible = (false);
            agendamento.Visible = (false);
            medicos.Visible = (true);
            pacientes.Visible = (false);
            medicos1.BringToFront();
            }

        private void btpacientes_Click(object sender, EventArgs e) {
            home.Visible = (false);
            agendamento.Visible = (false);
            medicos.Visible = (false);
            pacientes.Visible = (true);
            pacientes1.BringToFront();
            }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Button1_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
    }
