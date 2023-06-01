namespace Projeto_DA_PL_B_2223
{
    partial class FormClientes
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
            this.tabControlClientes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox_pesquisa = new System.Windows.Forms.TextBox();
            this.buttonPesquisarClientes = new System.Windows.Forms.Button();
            this.groupBoxFuncionario = new System.Windows.Forms.GroupBox();
            this.buttonGuardarClientes = new System.Windows.Forms.Button();
            this.textBoxNumFiscClientes = new System.Windows.Forms.TextBox();
            this.textBoxMoradaClientes = new System.Windows.Forms.TextBox();
            this.textBoxNomeClientes = new System.Windows.Forms.TextBox();
            this.labelNumeroFiscalClientes = new System.Windows.Forms.Label();
            this.labelMoradaClientes = new System.Windows.Forms.Label();
            this.labelNomesClientes = new System.Windows.Forms.Label();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.buttonApagarClientes = new System.Windows.Forms.Button();
            this.tabControlClientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClientes
            // 
            this.tabControlClientes.Controls.Add(this.tabPage1);
            this.tabControlClientes.Location = new System.Drawing.Point(9, 8);
            this.tabControlClientes.Name = "tabControlClientes";
            this.tabControlClientes.SelectedIndex = 0;
            this.tabControlClientes.Size = new System.Drawing.Size(1129, 335);
            this.tabControlClientes.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_pesquisa);
            this.tabPage1.Controls.Add(this.buttonPesquisarClientes);
            this.tabPage1.Controls.Add(this.groupBoxFuncionario);
            this.tabPage1.Controls.Add(this.listBoxClientes);
            this.tabPage1.Controls.Add(this.buttonApagarClientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1121, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBox_pesquisa
            // 
            this.textBox_pesquisa.Location = new System.Drawing.Point(794, 7);
            this.textBox_pesquisa.Name = "textBox_pesquisa";
            this.textBox_pesquisa.Size = new System.Drawing.Size(225, 22);
            this.textBox_pesquisa.TabIndex = 24;
            // 
            // buttonPesquisarClientes
            // 
            this.buttonPesquisarClientes.Location = new System.Drawing.Point(641, 5);
            this.buttonPesquisarClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPesquisarClientes.Name = "buttonPesquisarClientes";
            this.buttonPesquisarClientes.Size = new System.Drawing.Size(147, 24);
            this.buttonPesquisarClientes.TabIndex = 25;
            this.buttonPesquisarClientes.Text = "PESQUISAR";
            this.buttonPesquisarClientes.UseVisualStyleBackColor = true;
            this.buttonPesquisarClientes.Click += new System.EventHandler(this.buttonPesquisarClientes_Click_1);
            // 
            // groupBoxFuncionario
            // 
            this.groupBoxFuncionario.Controls.Add(this.buttonGuardarClientes);
            this.groupBoxFuncionario.Controls.Add(this.textBoxNumFiscClientes);
            this.groupBoxFuncionario.Controls.Add(this.textBoxMoradaClientes);
            this.groupBoxFuncionario.Controls.Add(this.textBoxNomeClientes);
            this.groupBoxFuncionario.Controls.Add(this.labelNumeroFiscalClientes);
            this.groupBoxFuncionario.Controls.Add(this.labelMoradaClientes);
            this.groupBoxFuncionario.Controls.Add(this.labelNomesClientes);
            this.groupBoxFuncionario.Location = new System.Drawing.Point(3, 5);
            this.groupBoxFuncionario.Name = "groupBoxFuncionario";
            this.groupBoxFuncionario.Size = new System.Drawing.Size(313, 171);
            this.groupBoxFuncionario.TabIndex = 4;
            this.groupBoxFuncionario.TabStop = false;
            this.groupBoxFuncionario.Text = "Clientes";
            // 
            // buttonGuardarClientes
            // 
            this.buttonGuardarClientes.Location = new System.Drawing.Point(211, 118);
            this.buttonGuardarClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGuardarClientes.Name = "buttonGuardarClientes";
            this.buttonGuardarClientes.Size = new System.Drawing.Size(101, 26);
            this.buttonGuardarClientes.TabIndex = 23;
            this.buttonGuardarClientes.Text = "Guardar";
            this.buttonGuardarClientes.UseVisualStyleBackColor = true;
            this.buttonGuardarClientes.Click += new System.EventHandler(this.buttonGuardarClientes_Click);
            // 
            // textBoxNumFiscClientes
            // 
            this.textBoxNumFiscClientes.Location = new System.Drawing.Point(109, 92);
            this.textBoxNumFiscClientes.Name = "textBoxNumFiscClientes";
            this.textBoxNumFiscClientes.Size = new System.Drawing.Size(199, 22);
            this.textBoxNumFiscClientes.TabIndex = 9;
            // 
            // textBoxMoradaClientes
            // 
            this.textBoxMoradaClientes.Location = new System.Drawing.Point(83, 60);
            this.textBoxMoradaClientes.Name = "textBoxMoradaClientes";
            this.textBoxMoradaClientes.Size = new System.Drawing.Size(225, 22);
            this.textBoxMoradaClientes.TabIndex = 5;
            // 
            // textBoxNomeClientes
            // 
            this.textBoxNomeClientes.Location = new System.Drawing.Point(83, 31);
            this.textBoxNomeClientes.Name = "textBoxNomeClientes";
            this.textBoxNomeClientes.Size = new System.Drawing.Size(225, 22);
            this.textBoxNomeClientes.TabIndex = 4;
            // 
            // labelNumeroFiscalClientes
            // 
            this.labelNumeroFiscalClientes.AutoSize = true;
            this.labelNumeroFiscalClientes.Location = new System.Drawing.Point(13, 95);
            this.labelNumeroFiscalClientes.Name = "labelNumeroFiscalClientes";
            this.labelNumeroFiscalClientes.Size = new System.Drawing.Size(94, 16);
            this.labelNumeroFiscalClientes.TabIndex = 2;
            this.labelNumeroFiscalClientes.Text = "Numero Fiscal";
            // 
            // labelMoradaClientes
            // 
            this.labelMoradaClientes.AutoSize = true;
            this.labelMoradaClientes.Location = new System.Drawing.Point(13, 63);
            this.labelMoradaClientes.Name = "labelMoradaClientes";
            this.labelMoradaClientes.Size = new System.Drawing.Size(57, 16);
            this.labelMoradaClientes.TabIndex = 1;
            this.labelMoradaClientes.Text = "Morada:";
            // 
            // labelNomesClientes
            // 
            this.labelNomesClientes.AutoSize = true;
            this.labelNomesClientes.Location = new System.Drawing.Point(13, 31);
            this.labelNomesClientes.Name = "labelNomesClientes";
            this.labelNomesClientes.Size = new System.Drawing.Size(47, 16);
            this.labelNomesClientes.TabIndex = 0;
            this.labelNomesClientes.Text = "Nome:";
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.ItemHeight = 16;
            this.listBoxClientes.Location = new System.Drawing.Point(347, 36);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(768, 228);
            this.listBoxClientes.TabIndex = 0;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // buttonApagarClientes
            // 
            this.buttonApagarClientes.Location = new System.Drawing.Point(347, 274);
            this.buttonApagarClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonApagarClientes.Name = "buttonApagarClientes";
            this.buttonApagarClientes.Size = new System.Drawing.Size(107, 24);
            this.buttonApagarClientes.TabIndex = 24;
            this.buttonApagarClientes.Text = "APAGAR";
            this.buttonApagarClientes.UseVisualStyleBackColor = true;
            this.buttonApagarClientes.Click += new System.EventHandler(this.buttonApagarClientes_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 352);
            this.Controls.Add(this.tabControlClientes);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.tabControlClientes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxFuncionario.ResumeLayout(false);
            this.groupBoxFuncionario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxFuncionario;
        private System.Windows.Forms.Button buttonPesquisarClientes;
        private System.Windows.Forms.Button buttonApagarClientes;
        private System.Windows.Forms.Button buttonGuardarClientes;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.TextBox textBoxNumFiscClientes;
        private System.Windows.Forms.TextBox textBoxMoradaClientes;
        private System.Windows.Forms.TextBox textBoxNomeClientes;
        private System.Windows.Forms.Label labelNumeroFiscalClientes;
        private System.Windows.Forms.Label labelMoradaClientes;
        private System.Windows.Forms.Label labelNomesClientes;
        private System.Windows.Forms.TextBox textBox_pesquisa;
    }
}