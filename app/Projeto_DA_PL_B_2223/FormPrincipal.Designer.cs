namespace Projeto_DA_PL_B_2223
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
            this.buttonCinema = new System.Windows.Forms.Button();
            this.buttonFilmes = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonSessoes = new System.Windows.Forms.Button();
            this.buttonFuncionarios = new System.Windows.Forms.Button();
            this.labelNomeCinema = new System.Windows.Forms.Label();
            this.buttonSalas = new System.Windows.Forms.Button();
            this.tabControlMenuPrincipal = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // buttonCinema
            // 
            this.buttonCinema.Location = new System.Drawing.Point(34, 103);
            this.buttonCinema.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.buttonFilmes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.buttonClientes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.buttonSessoes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.buttonFuncionarios.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.buttonSalas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.tabControlMenuPrincipal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControlMenuPrincipal.Name = "tabControlMenuPrincipal";
            this.tabControlMenuPrincipal.SelectedIndex = 0;
            this.tabControlMenuPrincipal.Size = new System.Drawing.Size(1534, 706);
            this.tabControlMenuPrincipal.TabIndex = 8;
            this.tabControlMenuPrincipal.SelectedIndexChanged += new System.EventHandler(this.tabControlMenuPrincipal_SelectedIndexChanged);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1746, 1022);
            this.Controls.Add(this.tabControlMenuPrincipal);
            this.Controls.Add(this.buttonSalas);
            this.Controls.Add(this.labelNomeCinema);
            this.Controls.Add(this.buttonFuncionarios);
            this.Controls.Add(this.buttonClientes);
            this.Controls.Add(this.buttonSessoes);
            this.Controls.Add(this.buttonFilmes);
            this.Controls.Add(this.buttonCinema);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormPrincipal";
            this.Text = "CineGest";
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
    }
}

