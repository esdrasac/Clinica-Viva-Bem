namespace Trabalho_Final_ATP
{
    partial class Pacientes
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacientes));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btPesquisarPaciente = new System.Windows.Forms.Button();
            this.btVoltarPesquisaPaciente = new System.Windows.Forms.Button();
            this.cadastrarPacientes1 = new Trabalho_Final_ATP.CadastrarPacientes();
            this.pesquisarPacientes1 = new Trabalho_Final_ATP.PesquisarPacientes();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(45, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 103);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "PACIENTES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(530, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(530, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(289, 135);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // btPesquisarPaciente
            // 
            this.btPesquisarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.btPesquisarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisarPaciente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisarPaciente.ForeColor = System.Drawing.Color.White;
            this.btPesquisarPaciente.Location = new System.Drawing.Point(371, 72);
            this.btPesquisarPaciente.Name = "btPesquisarPaciente";
            this.btPesquisarPaciente.Size = new System.Drawing.Size(127, 25);
            this.btPesquisarPaciente.TabIndex = 35;
            this.btPesquisarPaciente.Text = "Pesquisar ";
            this.btPesquisarPaciente.UseVisualStyleBackColor = false;
            this.btPesquisarPaciente.Click += new System.EventHandler(this.BtPesquisarMedico_Click);
            // 
            // btVoltarPesquisaPaciente
            // 
            this.btVoltarPesquisaPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.btVoltarPesquisaPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltarPesquisaPaciente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltarPesquisaPaciente.ForeColor = System.Drawing.Color.White;
            this.btVoltarPesquisaPaciente.Location = new System.Drawing.Point(371, 72);
            this.btVoltarPesquisaPaciente.Name = "btVoltarPesquisaPaciente";
            this.btVoltarPesquisaPaciente.Size = new System.Drawing.Size(127, 25);
            this.btVoltarPesquisaPaciente.TabIndex = 48;
            this.btVoltarPesquisaPaciente.Text = "Voltar";
            this.btVoltarPesquisaPaciente.UseVisualStyleBackColor = false;
            this.btVoltarPesquisaPaciente.Click += new System.EventHandler(this.BtVoltarPesquisaMed_Click);
            // 
            // cadastrarPacientes1
            // 
            this.cadastrarPacientes1.Location = new System.Drawing.Point(0, 109);
            this.cadastrarPacientes1.Name = "cadastrarPacientes1";
            this.cadastrarPacientes1.Size = new System.Drawing.Size(521, 350);
            this.cadastrarPacientes1.TabIndex = 49;
            // 
            // pesquisarPacientes1
            // 
            this.pesquisarPacientes1.Location = new System.Drawing.Point(0, 109);
            this.pesquisarPacientes1.Name = "pesquisarPacientes1";
            this.pesquisarPacientes1.Size = new System.Drawing.Size(521, 350);
            this.pesquisarPacientes1.TabIndex = 50;
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cadastrarPacientes1);
            this.Controls.Add(this.btPesquisarPaciente);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btVoltarPesquisaPaciente);
            this.Controls.Add(this.pesquisarPacientes1);
            this.Name = "Pacientes";
            this.Size = new System.Drawing.Size(819, 459);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btPesquisarPaciente;
        private System.Windows.Forms.Button btVoltarPesquisaPaciente;
        private CadastrarPacientes cadastrarPacientes1;
        private PesquisarPacientes pesquisarPacientes1;
    }
}
