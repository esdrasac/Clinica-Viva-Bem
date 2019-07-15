namespace Trabalho_Final_ATP
{
    partial class PesquisarAgendamento
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
            this.label7 = new System.Windows.Forms.Label();
            this.datapesquisa = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.medico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Especialidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idpac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btexcluirMed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(129)))), ((int)(((byte)(114)))));
            this.label7.Location = new System.Drawing.Point(49, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Data:";
            // 
            // datapesquisa
            // 
            this.datapesquisa.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datapesquisa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datapesquisa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datapesquisa.Location = new System.Drawing.Point(98, 81);
            this.datapesquisa.Name = "datapesquisa";
            this.datapesquisa.Size = new System.Drawing.Size(85, 21);
            this.datapesquisa.TabIndex = 43;
            this.datapesquisa.ValueChanged += new System.EventHandler(this.DataPesquisar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 38);
            this.label2.TabIndex = 39;
            this.label2.Text = "Pesquisar Consultas";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.medico,
            this.Especialidade,
            this.idpac,
            this.paciente,
            this.hora});
            this.listView1.Location = new System.Drawing.Point(52, 105);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(435, 197);
            this.listView1.TabIndex = 44;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 51;
            // 
            // medico
            // 
            this.medico.Text = "Médico";
            this.medico.Width = 102;
            // 
            // Especialidade
            // 
            this.Especialidade.Text = "Especialidade";
            // 
            // paciente
            // 
            this.paciente.Text = "Paciente";
            this.paciente.Width = 103;
            // 
            // idpac
            // 
            this.idpac.Text = "ID Pac.";
            // 
            // hora
            // 
            this.hora.Text = "Hora";
            this.hora.Width = 66;
            // 
            // btexcluirMed
            // 
            this.btexcluirMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.btexcluirMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btexcluirMed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluirMed.ForeColor = System.Drawing.Color.White;
            this.btexcluirMed.Location = new System.Drawing.Point(52, 309);
            this.btexcluirMed.Name = "btexcluirMed";
            this.btexcluirMed.Size = new System.Drawing.Size(144, 25);
            this.btexcluirMed.TabIndex = 49;
            this.btexcluirMed.Text = "Cancelar consulta";
            this.btexcluirMed.UseVisualStyleBackColor = false;
            this.btexcluirMed.Visible = false;
            this.btexcluirMed.Click += new System.EventHandler(this.BtexcluirMed_Click);
            // 
            // PesquisarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btexcluirMed);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.datapesquisa);
            this.Controls.Add(this.label2);
            this.Name = "PesquisarAgendamento";
            this.Size = new System.Drawing.Size(521, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datapesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btexcluirMed;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader paciente;
        private System.Windows.Forms.ColumnHeader medico;
        private System.Windows.Forms.ColumnHeader hora;
        private System.Windows.Forms.ColumnHeader Especialidade;
        private System.Windows.Forms.ColumnHeader idpac;
    }
}
