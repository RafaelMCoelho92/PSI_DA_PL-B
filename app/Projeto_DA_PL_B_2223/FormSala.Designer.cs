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
            this.textBoxFilas = new System.Windows.Forms.TextBox();
            this.buttonApagarSala = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxColunas = new System.Windows.Forms.TextBox();
            this.buttonEditarFilasColunas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxListaSalas = new System.Windows.Forms.GroupBox();
            this.listBoxSalas = new System.Windows.Forms.ListBox();
            this.groupBoxInserirSalas = new System.Windows.Forms.GroupBox();
            this.textBoxNomeSala = new System.Windows.Forms.TextBox();
            this.buttonAdicionarSala = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.textBoxFilas);
            this.tabPage1.Controls.Add(this.buttonApagarSala);
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
            // textBoxFilas
            // 
            this.textBoxFilas.Location = new System.Drawing.Point(202, 302);
            this.textBoxFilas.MaxLength = 2;
            this.textBoxFilas.Name = "textBoxFilas";
            this.textBoxFilas.Size = new System.Drawing.Size(153, 31);
            this.textBoxFilas.TabIndex = 3;
            // 
            // buttonApagarSala
            // 
            this.buttonApagarSala.Location = new System.Drawing.Point(425, 418);
            this.buttonApagarSala.Name = "buttonApagarSala";
            this.buttonApagarSala.Size = new System.Drawing.Size(153, 62);
            this.buttonApagarSala.TabIndex = 6;
            this.buttonApagarSala.Text = "Apagar Sala";
            this.buttonApagarSala.UseVisualStyleBackColor = true;
            this.buttonApagarSala.Click += new System.EventHandler(this.buttonApagarSala_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxColunas);
            this.groupBox1.Controls.Add(this.buttonEditarFilasColunas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 245);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Sala";
            // 
            // textBoxColunas
            // 
            this.textBoxColunas.Location = new System.Drawing.Point(196, 103);
            this.textBoxColunas.MaxLength = 2;
            this.textBoxColunas.Name = "textBoxColunas";
            this.textBoxColunas.Size = new System.Drawing.Size(153, 31);
            this.textBoxColunas.TabIndex = 4;
            // 
            // buttonEditarFilasColunas
            // 
            this.buttonEditarFilasColunas.Location = new System.Drawing.Point(115, 167);
            this.buttonEditarFilasColunas.Name = "buttonEditarFilasColunas";
            this.buttonEditarFilasColunas.Size = new System.Drawing.Size(153, 62);
            this.buttonEditarFilasColunas.TabIndex = 5;
            this.buttonEditarFilasColunas.Text = "Editar Sala";
            this.buttonEditarFilasColunas.UseVisualStyleBackColor = true;
            this.buttonEditarFilasColunas.Click += new System.EventHandler(this.buttonEditarFilasColunas_Click);
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
            // groupBoxListaSalas
            // 
            this.groupBoxListaSalas.Controls.Add(this.listBoxSalas);
            this.groupBoxListaSalas.Location = new System.Drawing.Point(604, 28);
            this.groupBoxListaSalas.Name = "groupBoxListaSalas";
            this.groupBoxListaSalas.Size = new System.Drawing.Size(572, 504);
            this.groupBoxListaSalas.TabIndex = 8;
            this.groupBoxListaSalas.TabStop = false;
            this.groupBoxListaSalas.Text = "Lista de Salas";
            // 
            // listBoxSalas
            // 
            this.listBoxSalas.FormattingEnabled = true;
            this.listBoxSalas.ItemHeight = 25;
            this.listBoxSalas.Location = new System.Drawing.Point(6, 30);
            this.listBoxSalas.Name = "listBoxSalas";
            this.listBoxSalas.Size = new System.Drawing.Size(548, 454);
            this.listBoxSalas.TabIndex = 9;
            // 
            // groupBoxInserirSalas
            // 
            this.groupBoxInserirSalas.Controls.Add(this.textBoxNomeSala);
            this.groupBoxInserirSalas.Controls.Add(this.buttonAdicionarSala);
            this.groupBoxInserirSalas.Controls.Add(this.label7);
            this.groupBoxInserirSalas.Location = new System.Drawing.Point(6, 28);
            this.groupBoxInserirSalas.Name = "groupBoxInserirSalas";
            this.groupBoxInserirSalas.Size = new System.Drawing.Size(572, 208);
            this.groupBoxInserirSalas.TabIndex = 0;
            this.groupBoxInserirSalas.TabStop = false;
            this.groupBoxInserirSalas.Text = "Inserir Sala";
            // 
            // textBoxNomeSala
            // 
            this.textBoxNomeSala.Location = new System.Drawing.Point(196, 43);
            this.textBoxNomeSala.Name = "textBoxNomeSala";
            this.textBoxNomeSala.Size = new System.Drawing.Size(349, 31);
            this.textBoxNomeSala.TabIndex = 1;
            // 
            // buttonAdicionarSala
            // 
            this.buttonAdicionarSala.Location = new System.Drawing.Point(196, 109);
            this.buttonAdicionarSala.Name = "buttonAdicionarSala";
            this.buttonAdicionarSala.Size = new System.Drawing.Size(153, 62);
            this.buttonAdicionarSala.TabIndex = 2;
            this.buttonAdicionarSala.Text = "Adicionar";
            this.buttonAdicionarSala.UseVisualStyleBackColor = true;
            this.buttonAdicionarSala.Click += new System.EventHandler(this.buttonAdicionarSala_Click);
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
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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