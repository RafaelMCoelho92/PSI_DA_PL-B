﻿namespace Projeto_DA_PL_B_2223
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.buttonCinema = new System.Windows.Forms.Button();
            this.buttonFilmes = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonSessoes = new System.Windows.Forms.Button();
            this.buttonFuncionarios = new System.Windows.Forms.Button();
            this.labelNomeCinema = new System.Windows.Forms.Label();
            this.buttonSalas = new System.Windows.Forms.Button();
            this.tabControlMenuPrincipal = new System.Windows.Forms.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNomeFuncionarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerFormPrincipal = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCinema
            // 
            this.buttonCinema.Location = new System.Drawing.Point(34, 103);
            this.buttonCinema.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCinema.Name = "buttonCinema";
            this.buttonCinema.Size = new System.Drawing.Size(168, 125);
            this.buttonCinema.TabIndex = 0;
            this.buttonCinema.Text = "Cinema";
            this.buttonCinema.UseVisualStyleBackColor = true;
            this.buttonCinema.Click += new System.EventHandler(this.buttonCinema_Click);
            // 
            // buttonFilmes
            // 
            this.buttonFilmes.Location = new System.Drawing.Point(574, 103);
            this.buttonFilmes.Margin = new System.Windows.Forms.Padding(6);
            this.buttonFilmes.Name = "buttonFilmes";
            this.buttonFilmes.Size = new System.Drawing.Size(168, 125);
            this.buttonFilmes.TabIndex = 3;
            this.buttonFilmes.Text = "Filmes";
            this.buttonFilmes.UseVisualStyleBackColor = true;
            this.buttonFilmes.Click += new System.EventHandler(this.buttonFilmes_Click);
            // 
            // buttonClientes
            // 
            this.buttonClientes.Location = new System.Drawing.Point(934, 103);
            this.buttonClientes.Margin = new System.Windows.Forms.Padding(6);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(168, 125);
            this.buttonClientes.TabIndex = 5;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonSessoes
            // 
            this.buttonSessoes.Location = new System.Drawing.Point(754, 103);
            this.buttonSessoes.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSessoes.Name = "buttonSessoes";
            this.buttonSessoes.Size = new System.Drawing.Size(168, 125);
            this.buttonSessoes.TabIndex = 4;
            this.buttonSessoes.Text = "Sessões";
            this.buttonSessoes.UseVisualStyleBackColor = true;
            this.buttonSessoes.Click += new System.EventHandler(this.buttonSessoes_Click);
            // 
            // buttonFuncionarios
            // 
            this.buttonFuncionarios.Location = new System.Drawing.Point(394, 103);
            this.buttonFuncionarios.Margin = new System.Windows.Forms.Padding(6);
            this.buttonFuncionarios.Name = "buttonFuncionarios";
            this.buttonFuncionarios.Size = new System.Drawing.Size(168, 125);
            this.buttonFuncionarios.TabIndex = 2;
            this.buttonFuncionarios.Text = "Funcionários";
            this.buttonFuncionarios.UseVisualStyleBackColor = true;
            this.buttonFuncionarios.Click += new System.EventHandler(this.buttonFuncionarios_Click);
            // 
            // labelNomeCinema
            // 
            this.labelNomeCinema.AutoSize = true;
            this.labelNomeCinema.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelNomeCinema.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNomeCinema.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCinema.ForeColor = System.Drawing.Color.Blue;
            this.labelNomeCinema.Location = new System.Drawing.Point(657, 25);
            this.labelNomeCinema.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNomeCinema.Name = "labelNomeCinema";
            this.labelNomeCinema.Size = new System.Drawing.Size(264, 53);
            this.labelNomeCinema.TabIndex = 5;
            this.labelNomeCinema.Text = "CINE GEST";
            // 
            // buttonSalas
            // 
            this.buttonSalas.Location = new System.Drawing.Point(214, 103);
            this.buttonSalas.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSalas.Name = "buttonSalas";
            this.buttonSalas.Size = new System.Drawing.Size(168, 125);
            this.buttonSalas.TabIndex = 1;
            this.buttonSalas.Text = "Salas";
            this.buttonSalas.UseVisualStyleBackColor = true;
            this.buttonSalas.Click += new System.EventHandler(this.buttonSalas_Click);
            // 
            // tabControlMenuPrincipal
            // 
            this.tabControlMenuPrincipal.Location = new System.Drawing.Point(34, 261);
            this.tabControlMenuPrincipal.Margin = new System.Windows.Forms.Padding(6);
            this.tabControlMenuPrincipal.Name = "tabControlMenuPrincipal";
            this.tabControlMenuPrincipal.SelectedIndex = 0;
            this.tabControlMenuPrincipal.Size = new System.Drawing.Size(1534, 706);
            this.tabControlMenuPrincipal.TabIndex = 8;
            this.tabControlMenuPrincipal.SelectedIndexChanged += new System.EventHandler(this.tabControlMenuPrincipal_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHora,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelNomeFuncionarioLogado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1528, 42);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHora
            // 
            this.toolStripStatusLabelHora.Name = "toolStripStatusLabelHora";
            this.toolStripStatusLabelHora.Size = new System.Drawing.Size(102, 32);
            this.toolStripStatusLabelHora.Text = "00:00:00";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(259, 32);
            this.toolStripStatusLabel1.Text = "Nome do Funcionario: ";
            // 
            // toolStripStatusLabelNomeFuncionarioLogado
            // 
            this.toolStripStatusLabelNomeFuncionarioLogado.Name = "toolStripStatusLabelNomeFuncionarioLogado";
            this.toolStripStatusLabelNomeFuncionarioLogado.Size = new System.Drawing.Size(0, 32);
            // 
            // timerFormPrincipal
            // 
            this.timerFormPrincipal.Enabled = true;
            this.timerFormPrincipal.Tick += new System.EventHandler(this.timerFormPrincipal_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 574);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControlMenuPrincipal);
            this.Controls.Add(this.buttonSalas);
            this.Controls.Add(this.labelNomeCinema);
            this.Controls.Add(this.buttonFuncionarios);
            this.Controls.Add(this.buttonClientes);
            this.Controls.Add(this.buttonSessoes);
            this.Controls.Add(this.buttonFilmes);
            this.Controls.Add(this.buttonCinema);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormPrincipal";
            this.Text = "CineGest";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCinema;
        private System.Windows.Forms.Button buttonFilmes;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonSessoes;
        private System.Windows.Forms.Button buttonFuncionarios;
        private System.Windows.Forms.Button buttonSalas;
        private System.Windows.Forms.TabControl tabControlMenuPrincipal;
        public System.Windows.Forms.Label labelNomeCinema;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNomeFuncionarioLogado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHora;
        private System.Windows.Forms.Timer timerFormPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

