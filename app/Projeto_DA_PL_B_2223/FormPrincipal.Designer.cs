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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.labelNomeCinema = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNomeFuncionarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerFormPrincipal = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.definiçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_mostrar_sessoes_dia = new System.Windows.Forms.ListBox();
            this.dateTimePickerSessoesFormPrinc = new System.Windows.Forms.DateTimePicker();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNomeCinema = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNomeCinema
            // 
            this.labelNomeCinema.AutoSize = true;
            this.labelNomeCinema.BackColor = System.Drawing.SystemColors.Control;
            this.labelNomeCinema.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNomeCinema.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCinema.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNomeCinema.Location = new System.Drawing.Point(644, 75);
            this.labelNomeCinema.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNomeCinema.Name = "labelNomeCinema";
            this.labelNomeCinema.Size = new System.Drawing.Size(264, 53);
            this.labelNomeCinema.TabIndex = 5;
            this.labelNomeCinema.Text = "CINE GEST";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHora,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelNomeCinema,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelNomeFuncionarioLogado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 863);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1596, 42);
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
            this.toolStripStatusLabelNomeFuncionarioLogado.Size = new System.Drawing.Size(145, 32);
            this.toolStripStatusLabelNomeFuncionarioLogado.Text = "FAÇA LOGIN";
            this.toolStripStatusLabelNomeFuncionarioLogado.Click += new System.EventHandler(this.toolStripStatusLabelNomeFuncionarioLogado_Click);
            // 
            // timerFormPrincipal
            // 
            this.timerFormPrincipal.Enabled = true;
            this.timerFormPrincipal.Tick += new System.EventHandler(this.timerFormPrincipal_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.definiçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1596, 48);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // definiçõesToolStripMenuItem
            // 
            this.definiçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cinemaToolStripMenuItem,
            this.salaToolStripMenuItem,
            this.funcionarioToolStripMenuItem,
            this.sessoesToolStripMenuItem,
            this.filmesToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.definiçõesToolStripMenuItem.Name = "definiçõesToolStripMenuItem";
            this.definiçõesToolStripMenuItem.Size = new System.Drawing.Size(146, 44);
            this.definiçõesToolStripMenuItem.Text = "Definições";
            // 
            // cinemaToolStripMenuItem
            // 
            this.cinemaToolStripMenuItem.Name = "cinemaToolStripMenuItem";
            this.cinemaToolStripMenuItem.Size = new System.Drawing.Size(282, 44);
            this.cinemaToolStripMenuItem.Text = "Cinema";
            this.cinemaToolStripMenuItem.Click += new System.EventHandler(this.cinemaToolStripMenuItem_Click);
            // 
            // salaToolStripMenuItem
            // 
            this.salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            this.salaToolStripMenuItem.Size = new System.Drawing.Size(282, 44);
            this.salaToolStripMenuItem.Text = "Salas";
            this.salaToolStripMenuItem.Click += new System.EventHandler(this.salasToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(282, 44);
            this.funcionarioToolStripMenuItem.Text = "Funcionários";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // sessoesToolStripMenuItem
            // 
            this.sessoesToolStripMenuItem.Name = "sessoesToolStripMenuItem";
            this.sessoesToolStripMenuItem.Size = new System.Drawing.Size(282, 44);
            this.sessoesToolStripMenuItem.Text = "Sessões";
            this.sessoesToolStripMenuItem.Click += new System.EventHandler(this.sessoesToolStripMenuItem_Click);
            // 
            // filmesToolStripMenuItem
            // 
            this.filmesToolStripMenuItem.Name = "filmesToolStripMenuItem";
            this.filmesToolStripMenuItem.Size = new System.Drawing.Size(282, 44);
            this.filmesToolStripMenuItem.Text = "Filmes";
            this.filmesToolStripMenuItem.Click += new System.EventHandler(this.filmesToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(282, 44);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // listBox_mostrar_sessoes_dia
            // 
            this.listBox_mostrar_sessoes_dia.FormattingEnabled = true;
            this.listBox_mostrar_sessoes_dia.ItemHeight = 25;
            this.listBox_mostrar_sessoes_dia.Location = new System.Drawing.Point(66, 183);
            this.listBox_mostrar_sessoes_dia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_mostrar_sessoes_dia.Name = "listBox_mostrar_sessoes_dia";
            this.listBox_mostrar_sessoes_dia.Size = new System.Drawing.Size(1436, 454);
            this.listBox_mostrar_sessoes_dia.TabIndex = 12;
            this.listBox_mostrar_sessoes_dia.DoubleClick += new System.EventHandler(this.listBox_mostrar_sessoes_dia_DoubleClick);
            // 
            // dateTimePickerSessoesFormPrinc
            // 
            this.dateTimePickerSessoesFormPrinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSessoesFormPrinc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerSessoesFormPrinc.Location = new System.Drawing.Point(616, 136);
            this.dateTimePickerSessoesFormPrinc.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePickerSessoesFormPrinc.MinDate = new System.DateTime(2023, 6, 3, 0, 0, 0, 0);
            this.dateTimePickerSessoesFormPrinc.Name = "dateTimePickerSessoesFormPrinc";
            this.dateTimePickerSessoesFormPrinc.Size = new System.Drawing.Size(320, 32);
            this.dateTimePickerSessoesFormPrinc.TabIndex = 13;
            this.dateTimePickerSessoesFormPrinc.ValueChanged += new System.EventHandler(this.dateTimePickerSessoesFormPrinc_ValueChanged);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(203, 32);
            this.toolStripStatusLabel2.Text = "Nome do Cinema";
            // 
            // toolStripStatusLabelNomeCinema
            // 
            this.toolStripStatusLabelNomeCinema.Name = "toolStripStatusLabelNomeCinema";
            this.toolStripStatusLabelNomeCinema.Size = new System.Drawing.Size(237, 32);
            this.toolStripStatusLabelNomeCinema.Text = "toolStripStatusLabel3";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 905);
            this.Controls.Add(this.dateTimePickerSessoesFormPrinc);
            this.Controls.Add(this.listBox_mostrar_sessoes_dia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelNomeCinema);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormPrincipal";
            this.Text = "CineGest";
            this.Activated += new System.EventHandler(this.FormPrincipal_Activated);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelNomeCinema;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNomeFuncionarioLogado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHora;
        private System.Windows.Forms.Timer timerFormPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem definiçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox_mostrar_sessoes_dia;
        private System.Windows.Forms.DateTimePicker dateTimePickerSessoesFormPrinc;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNomeCinema;
    }
}

