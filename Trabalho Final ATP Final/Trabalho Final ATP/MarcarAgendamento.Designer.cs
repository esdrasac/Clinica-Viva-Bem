namespace Trabalho_Final_ATP
{
    partial class marcaragendamento1
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
            this.medicoAgenda = new System.Windows.Forms.TextBox();
            this.pacienteAgenda = new System.Windows.Forms.TextBox();
            this.btMarcarAgenda = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.horaAgenda = new System.Windows.Forms.ComboBox();
            this.idconsultaAgenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btNovaPesquisa = new System.Windows.Forms.Button();
            this.dataAgenda = new System.Windows.Forms.DateTimePicker();
            this.resultadoPesquisa1 = new Trabalho_Final_ATP.ResultadoPesquisa();
            this.SuspendLayout();
            // 
            // medicoAgenda
            // 
            this.medicoAgenda.Location = new System.Drawing.Point(127, 133);
            this.medicoAgenda.Name = "medicoAgenda";
            this.medicoAgenda.Size = new System.Drawing.Size(301, 20);
            this.medicoAgenda.TabIndex = 36;
            // 
            // pacienteAgenda
            // 
            this.pacienteAgenda.Location = new System.Drawing.Point(127, 89);
            this.pacienteAgenda.Name = "pacienteAgenda";
            this.pacienteAgenda.Size = new System.Drawing.Size(301, 20);
            this.pacienteAgenda.TabIndex = 34;
            // 
            // btMarcarAgenda
            // 
            this.btMarcarAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.btMarcarAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMarcarAgenda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMarcarAgenda.ForeColor = System.Drawing.Color.White;
            this.btMarcarAgenda.Location = new System.Drawing.Point(127, 285);
            this.btMarcarAgenda.Name = "btMarcarAgenda";
            this.btMarcarAgenda.Size = new System.Drawing.Size(301, 25);
            this.btMarcarAgenda.TabIndex = 39;
            this.btMarcarAgenda.Text = "Marcar";
            this.btMarcarAgenda.UseVisualStyleBackColor = false;
            this.btMarcarAgenda.Click += new System.EventHandler(this.BtMarcarAgenda_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(129)))), ((int)(((byte)(114)))));
            this.label7.Location = new System.Drawing.Point(49, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(129)))), ((int)(((byte)(114)))));
            this.label6.Location = new System.Drawing.Point(49, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Paciênte: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(129)))), ((int)(((byte)(114)))));
            this.label8.Location = new System.Drawing.Point(49, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Médico: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 38);
            this.label2.TabIndex = 26;
            this.label2.Text = "Agendamento de Consultas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(129)))), ((int)(((byte)(114)))));
            this.label5.Location = new System.Drawing.Point(262, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Hora:";
            // 
            // horaAgenda
            // 
            this.horaAgenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.horaAgenda.FormattingEnabled = true;
            this.horaAgenda.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30"});
            this.horaAgenda.Location = new System.Drawing.Point(312, 179);
            this.horaAgenda.Name = "horaAgenda";
            this.horaAgenda.Size = new System.Drawing.Size(116, 21);
            this.horaAgenda.TabIndex = 38;
            // 
            // idconsultaAgenda
            // 
            this.idconsultaAgenda.Location = new System.Drawing.Point(165, 86);
            this.idconsultaAgenda.Name = "idconsultaAgenda";
            this.idconsultaAgenda.ReadOnly = true;
            this.idconsultaAgenda.Size = new System.Drawing.Size(102, 20);
            this.idconsultaAgenda.TabIndex = 41;
            this.idconsultaAgenda.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(129)))), ((int)(((byte)(114)))));
            this.label9.Location = new System.Drawing.Point(49, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Id da consulta: ";
            this.label9.Visible = false;
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
            this.btNovaPesquisa.TabIndex = 64;
            this.btNovaPesquisa.Text = "Sim";
            this.btNovaPesquisa.UseVisualStyleBackColor = false;
            this.btNovaPesquisa.Visible = false;
            this.btNovaPesquisa.Click += new System.EventHandler(this.BtNovaPesquisa_Click);
            // 
            // dataAgenda
            // 
            this.dataAgenda.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataAgenda.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dataAgenda.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataAgenda.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataAgenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataAgenda.Location = new System.Drawing.Point(98, 179);
            this.dataAgenda.Name = "dataAgenda";
            this.dataAgenda.Size = new System.Drawing.Size(85, 21);
            this.dataAgenda.TabIndex = 37;
            // 
            // resultadoPesquisa1
            // 
            this.resultadoPesquisa1.Location = new System.Drawing.Point(0, 0);
            this.resultadoPesquisa1.Name = "resultadoPesquisa1";
            this.resultadoPesquisa1.Size = new System.Drawing.Size(521, 350);
            this.resultadoPesquisa1.TabIndex = 39;
            this.resultadoPesquisa1.Visible = false;
            this.resultadoPesquisa1.Load += new System.EventHandler(this.ResultadoPesquisa1_Load);
            // 
            // marcaragendamento1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btNovaPesquisa);
            this.Controls.Add(this.idconsultaAgenda);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.resultadoPesquisa1);
            this.Controls.Add(this.horaAgenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.medicoAgenda);
            this.Controls.Add(this.pacienteAgenda);
            this.Controls.Add(this.btMarcarAgenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataAgenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Name = "marcaragendamento1";
            this.Size = new System.Drawing.Size(521, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox medicoAgenda;
        private System.Windows.Forms.TextBox pacienteAgenda;
        private System.Windows.Forms.Button btMarcarAgenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox horaAgenda;
        private ResultadoPesquisa resultadoPesquisa1;
        private System.Windows.Forms.TextBox idconsultaAgenda;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btNovaPesquisa;
        private System.Windows.Forms.DateTimePicker dataAgenda;
    }
}
