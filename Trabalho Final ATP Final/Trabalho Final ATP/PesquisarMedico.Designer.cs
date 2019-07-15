namespace Trabalho_Final_ATP {
    partial class PesquisarMedico {
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
            this.label2 = new System.Windows.Forms.Label();
            this.nomeMedico = new System.Windows.Forms.TextBox();
            this.btPesquisarMed = new System.Windows.Forms.Button();
            this.labelresultPesquisaMed = new System.Windows.Forms.Label();
            this.btexcluirMed = new System.Windows.Forms.Button();
            this.btNovaPesquisaMed = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.especialidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btHistorico = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 38);
            this.label2.TabIndex = 40;
            this.label2.Text = "Pesquisar Médico";
            // 
            // nomeMedico
            // 
            this.nomeMedico.Location = new System.Drawing.Point(52, 89);
            this.nomeMedico.Name = "nomeMedico";
            this.nomeMedico.Size = new System.Drawing.Size(326, 20);
            this.nomeMedico.TabIndex = 45;
            // 
            // btPesquisarMed
            // 
            this.btPesquisarMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.btPesquisarMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisarMed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisarMed.ForeColor = System.Drawing.Color.White;
            this.btPesquisarMed.Location = new System.Drawing.Point(384, 84);
            this.btPesquisarMed.Name = "btPesquisarMed";
            this.btPesquisarMed.Size = new System.Drawing.Size(103, 25);
            this.btPesquisarMed.TabIndex = 46;
            this.btPesquisarMed.Text = "Pesquisar ";
            this.btPesquisarMed.UseVisualStyleBackColor = false;
            this.btPesquisarMed.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // labelresultPesquisaMed
            // 
            this.labelresultPesquisaMed.AutoSize = true;
            this.labelresultPesquisaMed.Location = new System.Drawing.Point(52, 113);
            this.labelresultPesquisaMed.Name = "labelresultPesquisaMed";
            this.labelresultPesquisaMed.Size = new System.Drawing.Size(0, 13);
            this.labelresultPesquisaMed.TabIndex = 47;
            // 
            // btexcluirMed
            // 
            this.btexcluirMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.btexcluirMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btexcluirMed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluirMed.ForeColor = System.Drawing.Color.White;
            this.btexcluirMed.Location = new System.Drawing.Point(52, 309);
            this.btexcluirMed.Name = "btexcluirMed";
            this.btexcluirMed.Size = new System.Drawing.Size(124, 25);
            this.btexcluirMed.TabIndex = 48;
            this.btexcluirMed.Text = "Excluir cadastro";
            this.btexcluirMed.UseVisualStyleBackColor = false;
            this.btexcluirMed.Visible = false;
            this.btexcluirMed.Click += new System.EventHandler(this.BtexcluirMed_Click);
            // 
            // btNovaPesquisaMed
            // 
            this.btNovaPesquisaMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.btNovaPesquisaMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovaPesquisaMed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovaPesquisaMed.ForeColor = System.Drawing.Color.White;
            this.btNovaPesquisaMed.Location = new System.Drawing.Point(363, 309);
            this.btNovaPesquisaMed.Name = "btNovaPesquisaMed";
            this.btNovaPesquisaMed.Size = new System.Drawing.Size(124, 25);
            this.btNovaPesquisaMed.TabIndex = 49;
            this.btNovaPesquisaMed.Text = "Nova pesquisa";
            this.btNovaPesquisaMed.UseVisualStyleBackColor = false;
            this.btNovaPesquisaMed.Visible = false;
            this.btNovaPesquisaMed.Click += new System.EventHandler(this.BtNovaPesquisaMed_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Nome,
            this.especialidade,
            this.telefone});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listView1.Location = new System.Drawing.Point(52, 78);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(435, 225);
            this.listView1.TabIndex = 55;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 52;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 163;
            // 
            // especialidade
            // 
            this.especialidade.Text = "Especialidade";
            this.especialidade.Width = 116;
            // 
            // telefone
            // 
            this.telefone.Text = "Telefone";
            this.telefone.Width = 100;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listView2.Location = new System.Drawing.Point(52, 78);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(435, 225);
            this.listView2.TabIndex = 56;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID consulta";
            this.columnHeader1.Width = 67;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data consulta";
            this.columnHeader2.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Paciente";
            this.columnHeader3.Width = 261;
            // 
            // btHistorico
            // 
            this.btHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.btHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHistorico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistorico.ForeColor = System.Drawing.Color.White;
            this.btHistorico.Location = new System.Drawing.Point(207, 309);
            this.btHistorico.Name = "btHistorico";
            this.btHistorico.Size = new System.Drawing.Size(124, 25);
            this.btHistorico.TabIndex = 57;
            this.btHistorico.Text = "Histórico";
            this.btHistorico.UseVisualStyleBackColor = false;
            this.btHistorico.Visible = false;
            this.btHistorico.Click += new System.EventHandler(this.BtHistorico_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(207, 309);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(124, 25);
            this.back.TabIndex = 58;
            this.back.Text = "Voltar";
            this.back.UseVisualStyleBackColor = false;
            this.back.Visible = false;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // PesquisarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back);
            this.Controls.Add(this.btHistorico);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btNovaPesquisaMed);
            this.Controls.Add(this.btexcluirMed);
            this.Controls.Add(this.labelresultPesquisaMed);
            this.Controls.Add(this.btPesquisarMed);
            this.Controls.Add(this.nomeMedico);
            this.Controls.Add(this.label2);
            this.Name = "PesquisarMedico";
            this.Size = new System.Drawing.Size(521, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeMedico;
        private System.Windows.Forms.Button btPesquisarMed;
        private System.Windows.Forms.Label labelresultPesquisaMed;
        private System.Windows.Forms.Button btexcluirMed;
        private System.Windows.Forms.Button btNovaPesquisaMed;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader telefone;
        private System.Windows.Forms.ColumnHeader especialidade;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btHistorico;
        private System.Windows.Forms.Button back;
    }
}
