namespace Trabalho_Final_ATP {
    partial class CadastrarMedicos {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeMedico = new System.Windows.Forms.TextBox();
            this.especialidadeMedico = new System.Windows.Forms.TextBox();
            this.btCadastrarMedico = new System.Windows.Forms.Button();
            this.btNovaPesquisa = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.telefoneMedico = new System.Windows.Forms.MaskedTextBox();
            this.resultadoPesquisa1 = new Trabalho_Final_ATP.ResultadoPesquisa();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(129)))), ((int)(((byte)(114)))));
            this.label7.Location = new System.Drawing.Point(49, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Telefone: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(129)))), ((int)(((byte)(114)))));
            this.label6.Location = new System.Drawing.Point(49, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Nome: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(129)))), ((int)(((byte)(114)))));
            this.label8.Location = new System.Drawing.Point(49, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Especialidade: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 38);
            this.label2.TabIndex = 38;
            this.label2.Text = "Cadastramento de Médicos";
            // 
            // nomeMedico
            // 
            this.nomeMedico.Location = new System.Drawing.Point(109, 89);
            this.nomeMedico.Name = "nomeMedico";
            this.nomeMedico.Size = new System.Drawing.Size(350, 20);
            this.nomeMedico.TabIndex = 44;
            // 
            // especialidadeMedico
            // 
            this.especialidadeMedico.Location = new System.Drawing.Point(165, 133);
            this.especialidadeMedico.Name = "especialidadeMedico";
            this.especialidadeMedico.Size = new System.Drawing.Size(294, 20);
            this.especialidadeMedico.TabIndex = 46;
            // 
            // btCadastrarMedico
            // 
            this.btCadastrarMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.btCadastrarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarMedico.ForeColor = System.Drawing.Color.White;
            this.btCadastrarMedico.Location = new System.Drawing.Point(125, 285);
            this.btCadastrarMedico.Name = "btCadastrarMedico";
            this.btCadastrarMedico.Size = new System.Drawing.Size(303, 25);
            this.btCadastrarMedico.TabIndex = 48;
            this.btCadastrarMedico.Text = "Cadastrar";
            this.btCadastrarMedico.UseVisualStyleBackColor = false;
            this.btCadastrarMedico.Click += new System.EventHandler(this.BtCadastrarMedico_Click_1);
            // 
            // btNovaPesquisa
            // 
            this.btNovaPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.btNovaPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovaPesquisa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovaPesquisa.ForeColor = System.Drawing.Color.White;
            this.btNovaPesquisa.Location = new System.Drawing.Point(125, 285);
            this.btNovaPesquisa.Name = "btNovaPesquisa";
            this.btNovaPesquisa.Size = new System.Drawing.Size(303, 25);
            this.btNovaPesquisa.TabIndex = 63;
            this.btNovaPesquisa.Text = "Sim";
            this.btNovaPesquisa.UseVisualStyleBackColor = false;
            this.btNovaPesquisa.Click += new System.EventHandler(this.BtNovaPesquisa_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 65;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(129)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(49, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Id cadastrada: ";
            this.label1.Visible = false;
            // 
            // telefoneMedico
            // 
            this.telefoneMedico.Location = new System.Drawing.Point(125, 179);
            this.telefoneMedico.Mask = "(00)99999-9999";
            this.telefoneMedico.Name = "telefoneMedico";
            this.telefoneMedico.Size = new System.Drawing.Size(85, 20);
            this.telefoneMedico.TabIndex = 47;
            // 
            // resultadoPesquisa1
            // 
            this.resultadoPesquisa1.Location = new System.Drawing.Point(0, 0);
            this.resultadoPesquisa1.Name = "resultadoPesquisa1";
            this.resultadoPesquisa1.Size = new System.Drawing.Size(521, 350);
            this.resultadoPesquisa1.TabIndex = 58;
            this.resultadoPesquisa1.Visible = false;
            // 
            // CadastrarMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultadoPesquisa1);
            this.Controls.Add(this.telefoneMedico);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.especialidadeMedico);
            this.Controls.Add(this.nomeMedico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCadastrarMedico);
            this.Controls.Add(this.btNovaPesquisa);
            this.Name = "CadastrarMedicos";
            this.Size = new System.Drawing.Size(521, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox nomeMedico;
        public System.Windows.Forms.TextBox especialidadeMedico;
        public ResultadoPesquisa resultadoPesquisa1;
        public System.Windows.Forms.Button btCadastrarMedico;
        public System.Windows.Forms.Button btNovaPesquisa;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox telefoneMedico;
    }
}
