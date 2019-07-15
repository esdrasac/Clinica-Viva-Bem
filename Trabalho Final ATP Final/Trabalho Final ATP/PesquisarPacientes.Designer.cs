namespace Trabalho_Final_ATP {
    partial class PesquisarPacientes {
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
            this.label2 = new System.Windows.Forms.Label();
            this.nomePaciente = new System.Windows.Forms.TextBox();
            this.btPesquisarPac = new System.Windows.Forms.Button();
            this.btNovaPesquisaPac = new System.Windows.Forms.Button();
            this.btexcluirPac = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nascimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.label2.Size = new System.Drawing.Size(307, 38);
            this.label2.TabIndex = 41;
            this.label2.Text = "Pesquisar Paciente";
            // 
            // nomePaciente
            // 
            this.nomePaciente.Location = new System.Drawing.Point(52, 89);
            this.nomePaciente.Name = "nomePaciente";
            this.nomePaciente.Size = new System.Drawing.Size(326, 20);
            this.nomePaciente.TabIndex = 46;
            // 
            // btPesquisarPac
            // 
            this.btPesquisarPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.btPesquisarPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisarPac.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisarPac.ForeColor = System.Drawing.Color.White;
            this.btPesquisarPac.Location = new System.Drawing.Point(384, 84);
            this.btPesquisarPac.Name = "btPesquisarPac";
            this.btPesquisarPac.Size = new System.Drawing.Size(103, 25);
            this.btPesquisarPac.TabIndex = 47;
            this.btPesquisarPac.Text = "Pesquisar ";
            this.btPesquisarPac.UseVisualStyleBackColor = false;
            this.btPesquisarPac.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // btNovaPesquisaPac
            // 
            this.btNovaPesquisaPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.btNovaPesquisaPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovaPesquisaPac.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovaPesquisaPac.ForeColor = System.Drawing.Color.White;
            this.btNovaPesquisaPac.Location = new System.Drawing.Point(363, 309);
            this.btNovaPesquisaPac.Name = "btNovaPesquisaPac";
            this.btNovaPesquisaPac.Size = new System.Drawing.Size(124, 25);
            this.btNovaPesquisaPac.TabIndex = 51;
            this.btNovaPesquisaPac.Text = "Nova pesquisa";
            this.btNovaPesquisaPac.UseVisualStyleBackColor = false;
            this.btNovaPesquisaPac.Visible = false;
            this.btNovaPesquisaPac.Click += new System.EventHandler(this.BtNovaPesquisaPac_Click);
            // 
            // btexcluirPac
            // 
            this.btexcluirPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.btexcluirPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btexcluirPac.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluirPac.ForeColor = System.Drawing.Color.White;
            this.btexcluirPac.Location = new System.Drawing.Point(52, 309);
            this.btexcluirPac.Name = "btexcluirPac";
            this.btexcluirPac.Size = new System.Drawing.Size(124, 25);
            this.btexcluirPac.TabIndex = 50;
            this.btexcluirPac.Text = "Excluir cadastro";
            this.btexcluirPac.UseVisualStyleBackColor = false;
            this.btexcluirPac.Visible = false;
            this.btexcluirPac.Click += new System.EventHandler(this.BtexcluirPac_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Nome,
            this.Nascimento,
            this.Endereco,
            this.telefone});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listView1.Location = new System.Drawing.Point(52, 78);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(435, 225);
            this.listView1.TabIndex = 54;
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
            this.Nome.Width = 103;
            // 
            // Nascimento
            // 
            this.Nascimento.Text = "Nascimento";
            this.Nascimento.Width = 74;
            // 
            // Endereco
            // 
            this.Endereco.Text = "Endereço";
            this.Endereco.Width = 142;
            // 
            // telefone
            // 
            this.telefone.Text = "Telefone";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listView2.Location = new System.Drawing.Point(52, 78);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(435, 225);
            this.listView2.TabIndex = 55;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID consulta";
            this.columnHeader1.Width = 52;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data consulta";
            this.columnHeader2.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Médico";
            this.columnHeader3.Width = 133;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Especialidade";
            this.columnHeader4.Width = 142;
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
            this.btHistorico.TabIndex = 56;
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
            this.back.TabIndex = 59;
            this.back.Text = "Voltar";
            this.back.UseVisualStyleBackColor = false;
            this.back.Visible = false;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // PesquisarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back);
            this.Controls.Add(this.btHistorico);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btNovaPesquisaPac);
            this.Controls.Add(this.btexcluirPac);
            this.Controls.Add(this.btPesquisarPac);
            this.Controls.Add(this.nomePaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Name = "PesquisarPacientes";
            this.Size = new System.Drawing.Size(521, 350);
            this.Load += new System.EventHandler(this.PesquisarPacientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomePaciente;
        private System.Windows.Forms.Button btPesquisarPac;
        private System.Windows.Forms.Button btNovaPesquisaPac;
        private System.Windows.Forms.Button btexcluirPac;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Endereco;
        private System.Windows.Forms.ColumnHeader Nascimento;
        private System.Windows.Forms.ColumnHeader telefone;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btHistorico;
        private System.Windows.Forms.Button back;
    }
}
