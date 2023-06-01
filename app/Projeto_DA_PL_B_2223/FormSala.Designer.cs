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
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(606, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonApagarSala);
            this.tabPage1.Controls.Add(this.groupBoxListaSalas);
            this.tabPage1.Controls.Add(this.groupBoxInserirSalas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(598, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sala";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonApagarSala
            // 
            this.buttonApagarSala.Location = new System.Drawing.Point(212, 178);
            this.buttonApagarSala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonApagarSala.Name = "buttonApagarSala";
            this.buttonApagarSala.Size = new System.Drawing.Size(76, 32);
            this.buttonApagarSala.TabIndex = 6;
            this.buttonApagarSala.Text = "Apagar Sala";
            this.buttonApagarSala.UseVisualStyleBackColor = true;
            // 
            // groupBoxListaSalas
            // 
            this.groupBoxListaSalas.Controls.Add(this.listBoxSalas);
            this.groupBoxListaSalas.Location = new System.Drawing.Point(302, 15);
            this.groupBoxListaSalas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxListaSalas.Name = "groupBoxListaSalas";
            this.groupBoxListaSalas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxListaSalas.Size = new System.Drawing.Size(286, 262);
            this.groupBoxListaSalas.TabIndex = 8;
            this.groupBoxListaSalas.TabStop = false;
            this.groupBoxListaSalas.Text = "Lista de Salas";
            // 
            // listBoxSalas
            // 
            this.listBoxSalas.FormattingEnabled = true;
            this.listBoxSalas.Location = new System.Drawing.Point(3, 16);
            this.listBoxSalas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxSalas.Name = "listBoxSalas";
            this.listBoxSalas.Size = new System.Drawing.Size(276, 238);
            this.listBoxSalas.TabIndex = 9;
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
            this.groupBoxInserirSalas.Location = new System.Drawing.Point(3, 15);
            this.groupBoxInserirSalas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInserirSalas.Name = "groupBoxInserirSalas";
            this.groupBoxInserirSalas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInserirSalas.Size = new System.Drawing.Size(286, 152);
            this.groupBoxInserirSalas.TabIndex = 0;
            this.groupBoxInserirSalas.TabStop = false;
            this.groupBoxInserirSalas.Text = "Configurar Sala";
            // 
            // textBoxFilas
            // 
            this.textBoxFilas.Location = new System.Drawing.Point(98, 50);
            this.textBoxFilas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFilas.MaxLength = 2;
            this.textBoxFilas.Name = "textBoxFilas";
            this.textBoxFilas.Size = new System.Drawing.Size(78, 20);
            this.textBoxFilas.TabIndex = 3;
            // 
            // textBoxNomeSala
            // 
            this.textBoxNomeSala.Location = new System.Drawing.Point(98, 22);
            this.textBoxNomeSala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNomeSala.Name = "textBoxNomeSala";
            this.textBoxNomeSala.Size = new System.Drawing.Size(176, 20);
            this.textBoxNomeSala.TabIndex = 1;
            // 
            // textBoxColunas
            // 
            this.textBoxColunas.Location = new System.Drawing.Point(98, 77);
            this.textBoxColunas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxColunas.MaxLength = 2;
            this.textBoxColunas.Name = "textBoxColunas";
            this.textBoxColunas.Size = new System.Drawing.Size(78, 20);
            this.textBoxColunas.TabIndex = 4;
            // 
            // buttonAdicionarSala
            // 
            this.buttonAdicionarSala.Location = new System.Drawing.Point(98, 102);
            this.buttonAdicionarSala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdicionarSala.Name = "buttonAdicionarSala";
            this.buttonAdicionarSala.Size = new System.Drawing.Size(76, 32);
            this.buttonAdicionarSala.TabIndex = 2;
            this.buttonAdicionarSala.Text = "Adicionar";
            this.buttonAdicionarSala.UseVisualStyleBackColor = true;
            this.buttonAdicionarSala.Click += new System.EventHandler(this.buttonAdicionarSala_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nome da Sala:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "N.º Filas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "N.º Colunas";
            // 
            // FormSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 360);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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