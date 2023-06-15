namespace Projeto_DA_PL_B_2223
{
    partial class FormSala
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonApagarSala = new System.Windows.Forms.Button();
            this.groupBoxListaSalas = new System.Windows.Forms.GroupBox();
            this.listBoxSalas = new System.Windows.Forms.ListBox();
            this.groupBoxInserirSalas = new System.Windows.Forms.GroupBox();
            this.textBoxFilas = new System.Windows.Forms.TextBox();
            this.textBoxNomeSala = new System.Windows.Forms.TextBox();
            this.textBoxColunas = new System.Windows.Forms.TextBox();
            this.buttonAdicionarSala = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxListaSalas.SuspendLayout();
            this.groupBoxInserirSalas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1212, 667);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonApagarSala);
            this.tabPage1.Controls.Add(this.groupBoxListaSalas);
            this.tabPage1.Controls.Add(this.groupBoxInserirSalas);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1196, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sala";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonApagarSala
            // 
            this.buttonApagarSala.Location = new System.Drawing.Point(424, 342);
            this.buttonApagarSala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonApagarSala.Name = "buttonApagarSala";
            this.buttonApagarSala.Size = new System.Drawing.Size(152, 62);
            this.buttonApagarSala.TabIndex = 5;
            this.buttonApagarSala.Text = "Apagar Sala";
            this.buttonApagarSala.UseVisualStyleBackColor = true;
            this.buttonApagarSala.Click += new System.EventHandler(this.buttonApagarSala_Click);
            // 
            // groupBoxListaSalas
            // 
            this.groupBoxListaSalas.Controls.Add(this.listBoxSalas);
            this.groupBoxListaSalas.Location = new System.Drawing.Point(604, 29);
            this.groupBoxListaSalas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxListaSalas.Name = "groupBoxListaSalas";
            this.groupBoxListaSalas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxListaSalas.Size = new System.Drawing.Size(572, 504);
            this.groupBoxListaSalas.TabIndex = 8;
            this.groupBoxListaSalas.TabStop = false;
            this.groupBoxListaSalas.Text = "Lista de Salas";
            // 
            // listBoxSalas
            // 
            this.listBoxSalas.FormattingEnabled = true;
            this.listBoxSalas.ItemHeight = 25;
            this.listBoxSalas.Location = new System.Drawing.Point(6, 31);
            this.listBoxSalas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxSalas.Name = "listBoxSalas";
            this.listBoxSalas.Size = new System.Drawing.Size(548, 454);
            this.listBoxSalas.TabIndex = 6;
            this.listBoxSalas.SelectedIndexChanged += new System.EventHandler(this.listBoxSalas_SelectedIndexChanged);
            // 
            // groupBoxInserirSalas
            // 
            this.groupBoxInserirSalas.Controls.Add(this.textBoxFilas);
            this.groupBoxInserirSalas.Controls.Add(this.textBoxNomeSala);
            this.groupBoxInserirSalas.Controls.Add(this.textBoxColunas);
            this.groupBoxInserirSalas.Controls.Add(this.buttonAdicionarSala);
            this.groupBoxInserirSalas.Controls.Add(this.label7);
            this.groupBoxInserirSalas.Controls.Add(this.label5);
            this.groupBoxInserirSalas.Controls.Add(this.label4);
            this.groupBoxInserirSalas.Location = new System.Drawing.Point(6, 29);
            this.groupBoxInserirSalas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxInserirSalas.Name = "groupBoxInserirSalas";
            this.groupBoxInserirSalas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxInserirSalas.Size = new System.Drawing.Size(572, 292);
            this.groupBoxInserirSalas.TabIndex = 0;
            this.groupBoxInserirSalas.TabStop = false;
            this.groupBoxInserirSalas.Text = "Configurar Sala";
            // 
            // textBoxFilas
            // 
            this.textBoxFilas.Location = new System.Drawing.Point(196, 96);
            this.textBoxFilas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilas.MaxLength = 2;
            this.textBoxFilas.Name = "textBoxFilas";
            this.textBoxFilas.Size = new System.Drawing.Size(152, 31);
            this.textBoxFilas.TabIndex = 2;
            // 
            // textBoxNomeSala
            // 
            this.textBoxNomeSala.Location = new System.Drawing.Point(196, 42);
            this.textBoxNomeSala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNomeSala.Name = "textBoxNomeSala";
            this.textBoxNomeSala.Size = new System.Drawing.Size(348, 31);
            this.textBoxNomeSala.TabIndex = 1;
            // 
            // textBoxColunas
            // 
            this.textBoxColunas.Location = new System.Drawing.Point(196, 148);
            this.textBoxColunas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxColunas.MaxLength = 2;
            this.textBoxColunas.Name = "textBoxColunas";
            this.textBoxColunas.Size = new System.Drawing.Size(152, 31);
            this.textBoxColunas.TabIndex = 3;
            // 
            // buttonAdicionarSala
            // 
            this.buttonAdicionarSala.Location = new System.Drawing.Point(196, 196);
            this.buttonAdicionarSala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdicionarSala.Name = "buttonAdicionarSala";
            this.buttonAdicionarSala.Size = new System.Drawing.Size(152, 62);
            this.buttonAdicionarSala.TabIndex = 4;
            this.buttonAdicionarSala.Text = "Adicionar";
            this.buttonAdicionarSala.UseVisualStyleBackColor = true;
            this.buttonAdicionarSala.Click += new System.EventHandler(this.buttonAdicionarSala_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nome da Sala:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "N.º Filas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "N.º Colunas";
            // 
            // FormSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 692);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSala";
            this.Text = "FormSala";
            this.Load += new System.EventHandler(this.FormSala_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxListaSalas.ResumeLayout(false);
            this.groupBoxInserirSalas.ResumeLayout(false);
            this.groupBoxInserirSalas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonApagarSala;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxListaSalas;
        private System.Windows.Forms.ListBox listBoxSalas;
        private System.Windows.Forms.GroupBox groupBoxInserirSalas;
        private System.Windows.Forms.TextBox textBoxNomeSala;
        private System.Windows.Forms.Button buttonAdicionarSala;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFilas;
        private System.Windows.Forms.TextBox textBoxColunas;
    }
}