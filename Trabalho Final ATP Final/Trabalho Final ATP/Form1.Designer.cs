namespace Trabalho_Final_ATP {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.medicos = new System.Windows.Forms.Panel();
            this.pacientes = new System.Windows.Forms.Panel();
            this.agendamento = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btpacientes = new System.Windows.Forms.Button();
            this.btmedicos = new System.Windows.Forms.Button();
            this.btagendamento = new System.Windows.Forms.Button();
            this.bthome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.home1 = new Trabalho_Final_ATP.Home();
            this.pacientes1 = new Trabalho_Final_ATP.Pacientes();
            this.medicos1 = new Trabalho_Final_ATP.Medicos();
            this.agendamento1 = new Trabalho_Final_ATP.Agendamento();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.medicos);
            this.panel1.Controls.Add(this.pacientes);
            this.panel1.Controls.Add(this.agendamento);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btpacientes);
            this.panel1.Controls.Add(this.btmedicos);
            this.panel1.Controls.Add(this.btagendamento);
            this.panel1.Controls.Add(this.bthome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 471);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // medicos
            // 
            this.medicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.medicos.Location = new System.Drawing.Point(0, 167);
            this.medicos.Name = "medicos";
            this.medicos.Size = new System.Drawing.Size(11, 39);
            this.medicos.TabIndex = 9;
            this.medicos.Visible = false;
            // 
            // pacientes
            // 
            this.pacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.pacientes.Location = new System.Drawing.Point(0, 212);
            this.pacientes.Name = "pacientes";
            this.pacientes.Size = new System.Drawing.Size(11, 39);
            this.pacientes.TabIndex = 8;
            this.pacientes.Visible = false;
            // 
            // agendamento
            // 
            this.agendamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.agendamento.Location = new System.Drawing.Point(0, 122);
            this.agendamento.Name = "agendamento";
            this.agendamento.Size = new System.Drawing.Size(11, 39);
            this.agendamento.TabIndex = 8;
            this.agendamento.Visible = false;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.home.Location = new System.Drawing.Point(0, 77);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(11, 39);
            this.home.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Gray;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 432);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 39);
            this.button5.TabIndex = 5;
            this.button5.Text = "Sair";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btpacientes
            // 
            this.btpacientes.FlatAppearance.BorderSize = 0;
            this.btpacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btpacientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpacientes.ForeColor = System.Drawing.Color.Gray;
            this.btpacientes.Image = ((System.Drawing.Image)(resources.GetObject("btpacientes.Image")));
            this.btpacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btpacientes.Location = new System.Drawing.Point(12, 212);
            this.btpacientes.Name = "btpacientes";
            this.btpacientes.Size = new System.Drawing.Size(167, 39);
            this.btpacientes.TabIndex = 4;
            this.btpacientes.Text = "Pacientes";
            this.btpacientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btpacientes.UseVisualStyleBackColor = true;
            this.btpacientes.Click += new System.EventHandler(this.btpacientes_Click);
            // 
            // btmedicos
            // 
            this.btmedicos.FlatAppearance.BorderSize = 0;
            this.btmedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmedicos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmedicos.ForeColor = System.Drawing.Color.Gray;
            this.btmedicos.Image = ((System.Drawing.Image)(resources.GetObject("btmedicos.Image")));
            this.btmedicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmedicos.Location = new System.Drawing.Point(12, 167);
            this.btmedicos.Name = "btmedicos";
            this.btmedicos.Size = new System.Drawing.Size(164, 39);
            this.btmedicos.TabIndex = 3;
            this.btmedicos.Text = "Médicos";
            this.btmedicos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmedicos.UseVisualStyleBackColor = true;
            this.btmedicos.Click += new System.EventHandler(this.btmedicos_Click);
            // 
            // btagendamento
            // 
            this.btagendamento.FlatAppearance.BorderSize = 0;
            this.btagendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btagendamento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btagendamento.ForeColor = System.Drawing.Color.Gray;
            this.btagendamento.Image = ((System.Drawing.Image)(resources.GetObject("btagendamento.Image")));
            this.btagendamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btagendamento.Location = new System.Drawing.Point(12, 122);
            this.btagendamento.Name = "btagendamento";
            this.btagendamento.Size = new System.Drawing.Size(167, 39);
            this.btagendamento.TabIndex = 2;
            this.btagendamento.Text = "Agendamento";
            this.btagendamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btagendamento.UseVisualStyleBackColor = true;
            this.btagendamento.Click += new System.EventHandler(this.btagendamento_Click);
            // 
            // bthome
            // 
            this.bthome.FlatAppearance.BorderSize = 0;
            this.bthome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthome.ForeColor = System.Drawing.Color.Gray;
            this.bthome.Image = ((System.Drawing.Image)(resources.GetObject("bthome.Image")));
            this.bthome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthome.Location = new System.Drawing.Point(9, 77);
            this.bthome.Name = "bthome";
            this.bthome.Size = new System.Drawing.Size(167, 39);
            this.bthome.TabIndex = 1;
            this.bthome.Text = "Home";
            this.bthome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bthome.UseVisualStyleBackColor = true;
            this.bthome.Click += new System.EventHandler(this.bthome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(90)))), ((int)(((byte)(78)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(179, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 13);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.home1);
            this.panel4.Controls.Add(this.pacientes1);
            this.panel4.Controls.Add(this.medicos1);
            this.panel4.Controls.Add(this.agendamento1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(179, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(819, 459);
            this.panel4.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(771, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(816, 459);
            this.home1.TabIndex = 0;
            // 
            // pacientes1
            // 
            this.pacientes1.Location = new System.Drawing.Point(0, 0);
            this.pacientes1.Name = "pacientes1";
            this.pacientes1.Size = new System.Drawing.Size(819, 459);
            this.pacientes1.TabIndex = 3;
            // 
            // medicos1
            // 
            this.medicos1.Location = new System.Drawing.Point(0, 0);
            this.medicos1.Name = "medicos1";
            this.medicos1.Size = new System.Drawing.Size(819, 459);
            this.medicos1.TabIndex = 2;
            // 
            // agendamento1
            // 
            this.agendamento1.Location = new System.Drawing.Point(0, 0);
            this.agendamento1.Name = "agendamento1";
            this.agendamento1.Size = new System.Drawing.Size(819, 459);
            this.agendamento1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 471);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viva Bem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bthome;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btpacientes;
        private System.Windows.Forms.Button btmedicos;
        private System.Windows.Forms.Button btagendamento;
        private System.Windows.Forms.Panel home;
        private System.Windows.Forms.Panel medicos;
        private System.Windows.Forms.Panel pacientes;
        private System.Windows.Forms.Panel agendamento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private Home home1;
        private Pacientes pacientes1;
        private Medicos medicos1;
        private Agendamento agendamento1;
        private System.Windows.Forms.Button button1;
    }
}

