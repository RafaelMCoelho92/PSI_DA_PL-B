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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonApagarSala = new System.Windows.Forms.Button();
            this.buttonEditarFilasColunas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownNumeroColunas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumeroFilas = new System.Windows.Forms.NumericUpDown();
            this.groupBoxListaSalas = new System.Windows.Forms.GroupBox();
            this.listBoxSalas = new System.Windows.Forms.ListBox();
            this.groupBoxInserirSalas = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAdicionarSala = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonMenuPrincipal = new System.Windows.Forms.Button();
            this.buttonEditarFuncionarios = new System.Windows.Forms.Button();
            this.buttonEditarCinema = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroColunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroFilas)).BeginInit();
            this.groupBoxListaSalas.SuspendLayout();
            this.groupBoxInserirSalas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1213, 667);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonApagarSala);
            this.tabPage1.Controls.Add(this.buttonMenuPrincipal);
            this.tabPage1.Controls.Add(this.buttonEditarFuncionarios);
            this.tabPage1.Controls.Add(this.buttonEditarCinema);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBoxListaSalas);
            this.tabPage1.Controls.Add(this.groupBoxInserirSalas);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1197, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEditarFilasColunas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownNumeroColunas);
            this.groupBox1.Controls.Add(this.numericUpDownNumeroFilas);
            this.groupBox1.Location = new System.Drawing.Point(16, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 245);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Sala";
            // 
            // buttonApagarSala
            // 
            this.buttonApagarSala.Location = new System.Drawing.Point(435, 519);
            this.buttonApagarSala.Name = "buttonApagarSala";
            this.buttonApagarSala.Size = new System.Drawing.Size(153, 62);
            this.buttonApagarSala.TabIndex = 9;
            this.buttonApagarSala.Text = "Apagar Sala";
            this.buttonApagarSala.UseVisualStyleBackColor = true;
            // 
            // buttonEditarFilasColunas
            // 
            this.buttonEditarFilasColunas.Location = new System.Drawing.Point(115, 167);
            this.buttonEditarFilasColunas.Name = "buttonEditarFilasColunas";
            this.buttonEditarFilasColunas.Size = new System.Drawing.Size(153, 62);
            this.buttonEditarFilasColunas.TabIndex = 8;
            this.buttonEditarFilasColunas.Text = "Editar Sala";
            this.buttonEditarFilasColunas.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "N.º Filas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "N.º Colunas";
            // 
            // numericUpDownNumeroColunas
            // 
            this.numericUpDownNumeroColunas.Location = new System.Drawing.Point(229, 103);
            this.numericUpDownNumeroColunas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownNumeroColunas.Name = "numericUpDownNumeroColunas";
            this.numericUpDownNumeroColunas.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownNumeroColunas.TabIndex = 6;
            // 
            // numericUpDownNumeroFilas
            // 
            this.numericUpDownNumeroFilas.Location = new System.Drawing.Point(229, 48);
            this.numericUpDownNumeroFilas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownNumeroFilas.Name = "numericUpDownNumeroFilas";
            this.numericUpDownNumeroFilas.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownNumeroFilas.TabIndex = 5;
            // 
            // groupBoxListaSalas
            // 
            this.groupBoxListaSalas.Controls.Add(this.listBoxSalas);
            this.groupBoxListaSalas.Location = new System.Drawing.Point(604, 28);
            this.groupBoxListaSalas.Name = "groupBoxListaSalas";
            this.groupBoxListaSalas.Size = new System.Drawing.Size(572, 569);
            this.groupBoxListaSalas.TabIndex = 11;
            this.groupBoxListaSalas.TabStop = false;
            this.groupBoxListaSalas.Text = "Lista de Salas";
            // 
            // listBoxSalas
            // 
            this.listBoxSalas.FormattingEnabled = true;
            this.listBoxSalas.ItemHeight = 25;
            this.listBoxSalas.Location = new System.Drawing.Point(6, 49);
            this.listBoxSalas.Name = "listBoxSalas";
            this.listBoxSalas.Size = new System.Drawing.Size(548, 504);
            this.listBoxSalas.TabIndex = 0;
            // 
            // groupBoxInserirSalas
            // 
            this.groupBoxInserirSalas.Controls.Add(this.textBox1);
            this.groupBoxInserirSalas.Controls.Add(this.buttonAdicionarSala);
            this.groupBoxInserirSalas.Controls.Add(this.label7);
            this.groupBoxInserirSalas.Location = new System.Drawing.Point(6, 121);
            this.groupBoxInserirSalas.Name = "groupBoxInserirSalas";
            this.groupBoxInserirSalas.Size = new System.Drawing.Size(572, 208);
            this.groupBoxInserirSalas.TabIndex = 10;
            this.groupBoxInserirSalas.TabStop = false;
            this.groupBoxInserirSalas.Text = "Inserir Sala";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 31);
            this.textBox1.TabIndex = 7;
            // 
            // buttonAdicionarSala
            // 
            this.buttonAdicionarSala.Location = new System.Drawing.Point(196, 109);
            this.buttonAdicionarSala.Name = "buttonAdicionarSala";
            this.buttonAdicionarSala.Size = new System.Drawing.Size(153, 62);
            this.buttonAdicionarSala.TabIndex = 7;
            this.buttonAdicionarSala.Text = "Adicionar";
            this.buttonAdicionarSala.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nome da Sala:";
            // 
            // buttonMenuPrincipal
            // 
            this.buttonMenuPrincipal.Location = new System.Drawing.Point(3, 3);
            this.buttonMenuPrincipal.Name = "buttonMenuPrincipal";
            this.buttonMenuPrincipal.Size = new System.Drawing.Size(181, 112);
            this.buttonMenuPrincipal.TabIndex = 15;
            this.buttonMenuPrincipal.Text = "Menu Principal";
            this.buttonMenuPrincipal.UseVisualStyleBackColor = true;
            // 
            // buttonEditarFuncionarios
            // 
            this.buttonEditarFuncionarios.Location = new System.Drawing.Point(376, 3);
            this.buttonEditarFuncionarios.Name = "buttonEditarFuncionarios";
            this.buttonEditarFuncionarios.Size = new System.Drawing.Size(181, 112);
            this.buttonEditarFuncionarios.TabIndex = 14;
            this.buttonEditarFuncionarios.Text = "Editar Funcionarios";
            this.buttonEditarFuncionarios.UseVisualStyleBackColor = true;
            // 
            // buttonEditarCinema
            // 
            this.buttonEditarCinema.Location = new System.Drawing.Point(189, 3);
            this.buttonEditarCinema.Name = "buttonEditarCinema";
            this.buttonEditarCinema.Size = new System.Drawing.Size(181, 112);
            this.buttonEditarCinema.TabIndex = 13;
            this.buttonEditarCinema.Text = "Editar Cinema";
            this.buttonEditarCinema.UseVisualStyleBackColor = true;
            // 
            // FormSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 693);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSala";
            this.Text = "FormSala";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroColunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroFilas)).EndInit();
            this.groupBoxListaSalas.ResumeLayout(false);
            this.groupBoxInserirSalas.ResumeLayout(false);
            this.groupBoxInserirSalas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonApagarSala;
        private System.Windows.Forms.Button buttonEditarFilasColunas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownNumeroColunas;
        private System.Windows.Forms.NumericUpDown numericUpDownNumeroFilas;
        private System.Windows.Forms.GroupBox groupBoxListaSalas;
        private System.Windows.Forms.ListBox listBoxSalas;
        private System.Windows.Forms.GroupBox groupBoxInserirSalas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAdicionarSala;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonMenuPrincipal;
        private System.Windows.Forms.Button buttonEditarFuncionarios;
        private System.Windows.Forms.Button buttonEditarCinema;
    }
}