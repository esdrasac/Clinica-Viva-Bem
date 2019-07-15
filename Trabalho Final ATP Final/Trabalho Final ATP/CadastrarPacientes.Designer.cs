namespace Trabalho_Final_ATP {
    partial class CadastrarPacientes {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.enderecoPaciente = new System.Windows.Forms.TextBox();
            this.btCadastrarMedico = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cidadePaciente = new System.Windows.Forms.TextBox();
            this.cidade = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.estadoPaciente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idPaciente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.MaskedTextBox();
            this.nomePaciente = new System.Windows.Forms.TextBox();
            this.telefonePaciente = new System.Windows.Forms.MaskedTextBox();
            this.resultadoPesquisa2 = new Trabalho_Final_ATP.ResultadoPesquisa();
            this.SuspendLayout();
            // 
            // enderecoPaciente
            // 
            this.enderecoPaciente.Location = new System.Drawing.Point(132, 165);
            this.enderecoPaciente.Name = "enderecoPaciente";
            this.enderecoPaciente.Size = new System.Drawing.Size(327, 20);
            this.enderecoPaciente.TabIndex = 57;
            // 
            // btCadastrarMedico
            // 
            this.btCadastrarMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.btCadastrarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarMedico.ForeColor = System.Drawing.Color.White;
            this.btCadastrarMedico.Location = new System.Drawing.Point(127, 285);
            this.btCadastrarMedico.Name = "btCadastrarMedico";
            this.btCadastrarMedico.Size = new System.Drawing.Size(301, 25);
            this.btCadastrarMedico.TabIndex = 60;
            this.btCadastrarMedico.Text = "Cadastrar";
            this.btCadastrarMedico.UseVisualStyleBackColor = false;
            this.btCadastrarMedico.Click += new System.EventHandler(this.BtCadastrarMedico_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(129)))), ((int)(((byte)(114)))));
            this.label6.Location = new System.Drawing.Point(49, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Nome: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(129)))), ((int)(((byte)(114)))));
            this.label8.Location = new System.Drawing.Point(49, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 51;
            this.label8.Text = "Endereço: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 38);
            this.label2.TabIndex = 48;
            this.label2.Text = "Cadastramento de Pacientes";
            // 
            // cidadePaciente
            // 
            this.cidadePaciente.Location = new System.Drawing.Point(120, 206);
            this.cidadePaciente.Name = "cidadePaciente";
            this.cidadePaciente.Size = new System.Drawing.Size(115, 20);
            this.cidadePaciente.TabIndex = 58;
            // 
            // cidade
            // 
            this.cidade.AutoSize = true;
            this.cidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(129)))), ((int)(((byte)(114)))));
            this.cidade.Location = new System.Drawing.Point(49, 210);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(65, 16);
            this.cidade.TabIndex = 58;
            this.cidade.Text = "Cidade: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(129)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(273, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Estado: ";
            // 
            // estadoPaciente
            // 
            this.estadoPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoPaciente.FormattingEnabled = true;
            this.estadoPaciente.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espirito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Penambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.estadoPaciente.Location = new System.Drawing.Point(338, 205);
            this.estadoPaciente.Name = "estadoPaciente";
            this.estadoPaciente.Size = new System.Drawing.Size(121, 21);
            this.estadoPaciente.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(129)))), ((int)(((byte)(114)))));
            this.label4.Location = new System.Drawing.Point(49, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 66;
            this.label4.Text = "Nascimento: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(129)))), ((int)(((byte)(114)))));
            this.label7.Location = new System.Drawing.Point(274, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 64;
            this.label7.Text = "Telefone: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(129)))), ((int)(((byte)(114)))));
            this.label9.Location = new System.Drawing.Point(49, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 16);
            this.label9.TabIndex = 71;
            this.label9.Text = "Id do paciente: ";
            this.label9.Visible = false;
            // 
            // idPaciente
            // 
            this.idPaciente.Location = new System.Drawing.Point(167, 85);
            this.idPaciente.Name = "idPaciente";
            this.idPaciente.ReadOnly = true;
            this.idPaciente.Size = new System.Drawing.Size(109, 20);
            this.idPaciente.TabIndex = 72;
            this.idPaciente.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(127, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 25);
            this.button1.TabIndex = 73;
            this.button1.Text = "Sim";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 126);
            this.dateTimePicker1.Mask = "00/00/0000";
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(65, 20);
            this.dateTimePicker1.TabIndex = 55;
            this.dateTimePicker1.ValidatingType = typeof(System.DateTime);
            // 
            // nomePaciente
            // 
            this.nomePaciente.Location = new System.Drawing.Point(109, 89);
            this.nomePaciente.Name = "nomePaciente";
            this.nomePaciente.Size = new System.Drawing.Size(350, 20);
            this.nomePaciente.TabIndex = 54;
            // 
            // telefonePaciente
            // 
            this.telefonePaciente.Location = new System.Drawing.Point(350, 126);
            this.telefonePaciente.Mask = "(00)00000-0000";
            this.telefonePaciente.Name = "telefonePaciente";
            this.telefonePaciente.Size = new System.Drawing.Size(100, 20);
            this.telefonePaciente.TabIndex = 56;
            // 
            // resultadoPesquisa2
            // 
            this.resultadoPesquisa2.Location = new System.Drawing.Point(0, 0);
            this.resultadoPesquisa2.Name = "resultadoPesquisa2";
            this.resultadoPesquisa2.Size = new System.Drawing.Size(521, 350);
            this.resultadoPesquisa2.TabIndex = 68;
            // 
            // CadastrarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultadoPesquisa2);
            this.Controls.Add(this.telefonePaciente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.idPaciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.estadoPaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cidadePaciente);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.enderecoPaciente);
            this.Controls.Add(this.nomePaciente);
            this.Controls.Add(this.btCadastrarMedico);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Name = "CadastrarPacientes";
            this.Size = new System.Drawing.Size(521, 350);
            this.Load += new System.EventHandler(this.CadastrarPacientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox enderecoPaciente;
        private System.Windows.Forms.Button btCadastrarMedico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cidadePaciente;
        private System.Windows.Forms.Label cidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox estadoPaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private ResultadoPesquisa resultadoPesquisa2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idPaciente;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox dateTimePicker1;
        private System.Windows.Forms.TextBox nomePaciente;
        private System.Windows.Forms.MaskedTextBox telefonePaciente;
    }
}
