namespace Trabalho_Final_ATP {
    partial class Agendamento {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agendamento));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.marcarAgendamento1 = new Trabalho_Final_ATP.marcaragendamento1();
            this.pesquisarAgendamento1 = new Trabalho_Final_ATP.PesquisarAgendamento();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btVoltarPesquisa = new System.Windows.Forms.Button();
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
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGENDA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(530, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(530, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(289, 135);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // marcarAgendamento1
            // 
            this.marcarAgendamento1.Location = new System.Drawing.Point(0, 109);
            this.marcarAgendamento1.Name = "marcarAgendamento1";
            this.marcarAgendamento1.Size = new System.Drawing.Size(521, 350);
            this.marcarAgendamento1.TabIndex = 25;
            // 
            // pesquisarAgendamento1
            // 
            this.pesquisarAgendamento1.Location = new System.Drawing.Point(0, 109);
            this.pesquisarAgendamento1.Name = "pesquisarAgendamento1";
            this.pesquisarAgendamento1.Size = new System.Drawing.Size(521, 350);
            this.pesquisarAgendamento1.TabIndex = 26;
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.ForeColor = System.Drawing.Color.White;
            this.btPesquisar.Location = new System.Drawing.Point(371, 72);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(127, 25);
            this.btPesquisar.TabIndex = 33;
            this.btPesquisar.Text = "Pesquisar ";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // btVoltarPesquisa
            // 
            this.btVoltarPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.btVoltarPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltarPesquisa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltarPesquisa.ForeColor = System.Drawing.Color.White;
            this.btVoltarPesquisa.Location = new System.Drawing.Point(371, 72);
            this.btVoltarPesquisa.Name = "btVoltarPesquisa";
            this.btVoltarPesquisa.Size = new System.Drawing.Size(127, 25);
            this.btVoltarPesquisa.TabIndex = 46;
            this.btVoltarPesquisa.Text = "Voltar";
            this.btVoltarPesquisa.UseVisualStyleBackColor = false;
            this.btVoltarPesquisa.Click += new System.EventHandler(this.BtVoltarPesquisa_Click);
            // 
            // Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.marcarAgendamento1);
            this.Controls.Add(this.pesquisarAgendamento1);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btVoltarPesquisa);
            this.Name = "Agendamento";
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
        private marcaragendamento1 marcarAgendamento1;
        private PesquisarAgendamento pesquisarAgendamento1;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btVoltarPesquisa;
    }
    }
