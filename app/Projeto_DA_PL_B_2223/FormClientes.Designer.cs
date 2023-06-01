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
            this.groupBoxFuncionario = new System.Windows.Forms.GroupBox();
            this.buttonPesquisarClientes = new System.Windows.Forms.Button();
            this.buttonApagarClientes = new System.Windows.Forms.Button();
            this.buttonGuardarClientes = new System.Windows.Forms.Button();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.textBoxNumFiscClientes = new System.Windows.Forms.TextBox();
            this.textBoxMoradaClientes = new System.Windows.Forms.TextBox();
            this.textBoxNomeClientes = new System.Windows.Forms.TextBox();
            this.labelNumeroFiscalClientes = new System.Windows.Forms.Label();
            this.labelMoradaClientes = new System.Windows.Forms.Label();
            this.labelNomesClientes = new System.Windows.Forms.Label();
            this.tabControlClientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClientes
            // 
            this.tabControlClientes.Controls.Add(this.tabPage1);
            this.tabControlClientes.Location = new System.Drawing.Point(13, 13);
            this.tabControlClientes.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlClientes.Name = "tabControlClientes";
            this.tabControlClientes.SelectedIndex = 0;
            this.tabControlClientes.Size = new System.Drawing.Size(1209, 495);
            this.tabControlClientes.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonPesquisarClientes);
            this.tabPage1.Controls.Add(this.groupBoxFuncionario);
            this.tabPage1.Controls.Add(this.listBoxClientes);
            this.tabPage1.Controls.Add(this.buttonApagarClientes);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1193, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            this.groupBoxFuncionario.Location = new System.Drawing.Point(4, 8);
            this.groupBoxFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFuncionario.Name = "groupBoxFuncionario";
            this.groupBoxFuncionario.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFuncionario.Size = new System.Drawing.Size(469, 267);
            this.groupBoxFuncionario.TabIndex = 4;
            this.groupBoxFuncionario.TabStop = false;
            this.groupBoxFuncionario.Text = "Clientes";
            // 
            // buttonPesquisarClientes
            // 
            this.buttonPesquisarClientes.Location = new System.Drawing.Point(958, 8);
            this.buttonPesquisarClientes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonPesquisarClientes.Name = "buttonPesquisarClientes";
            this.buttonPesquisarClientes.Size = new System.Drawing.Size(220, 38);
            this.buttonPesquisarClientes.TabIndex = 25;
            this.buttonPesquisarClientes.Text = "PESQUISAR";
            this.buttonPesquisarClientes.UseVisualStyleBackColor = true;
            // 
            // buttonApagarClientes
            // 
            this.buttonApagarClientes.Location = new System.Drawing.Point(304, 361);
            this.buttonApagarClientes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonApagarClientes.Name = "buttonApagarClientes";
            this.buttonApagarClientes.Size = new System.Drawing.Size(160, 38);
            this.buttonApagarClientes.TabIndex = 24;
            this.buttonApagarClientes.Text = "APAGAR";
            this.buttonApagarClientes.UseVisualStyleBackColor = true;
            this.buttonApagarClientes.Click += new System.EventHandler(this.buttonApagarClientes_Click);
            // 
            // buttonGuardarClientes
            // 
            this.buttonGuardarClientes.Location = new System.Drawing.Point(308, 191);
            this.buttonGuardarClientes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonGuardarClientes.Name = "buttonGuardarClientes";
            this.buttonGuardarClientes.Size = new System.Drawing.Size(152, 41);
            this.buttonGuardarClientes.TabIndex = 23;
            this.buttonGuardarClientes.Text = "Guardar";
            this.buttonGuardarClientes.UseVisualStyleBackColor = true;
            this.buttonGuardarClientes.Click += new System.EventHandler(this.buttonGuardarClientes_Click);
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.ItemHeight = 25;
            this.listBoxClientes.Location = new System.Drawing.Point(520, 56);
            this.listBoxClientes.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(658, 354);
            this.listBoxClientes.TabIndex = 0;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // textBoxNumFiscClientes
            // 
            this.textBoxNumFiscClientes.Location = new System.Drawing.Point(164, 144);
            this.textBoxNumFiscClientes.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumFiscClientes.Name = "textBoxNumFiscClientes";
            this.textBoxNumFiscClientes.Size = new System.Drawing.Size(296, 31);
            this.textBoxNumFiscClientes.TabIndex = 9;
            // 
            // textBoxMoradaClientes
            // 
            this.textBoxMoradaClientes.Location = new System.Drawing.Point(124, 94);
            this.textBoxMoradaClientes.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoradaClientes.Name = "textBoxMoradaClientes";
            this.textBoxMoradaClientes.Size = new System.Drawing.Size(336, 31);
            this.textBoxMoradaClientes.TabIndex = 5;
            // 
            // textBoxNomeClientes
            // 
            this.textBoxNomeClientes.Location = new System.Drawing.Point(124, 48);
            this.textBoxNomeClientes.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNomeClientes.Name = "textBoxNomeClientes";
            this.textBoxNomeClientes.Size = new System.Drawing.Size(336, 31);
            this.textBoxNomeClientes.TabIndex = 4;
            // 
            // labelNumeroFiscalClientes
            // 
            this.labelNumeroFiscalClientes.AutoSize = true;
            this.labelNumeroFiscalClientes.Location = new System.Drawing.Point(20, 148);
            this.labelNumeroFiscalClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumeroFiscalClientes.Name = "labelNumeroFiscalClientes";
            this.labelNumeroFiscalClientes.Size = new System.Drawing.Size(150, 25);
            this.labelNumeroFiscalClientes.TabIndex = 2;
            this.labelNumeroFiscalClientes.Text = "Numero Fiscal";
            // 
            // labelMoradaClientes
            // 
            this.labelMoradaClientes.AutoSize = true;
            this.labelMoradaClientes.Location = new System.Drawing.Point(20, 98);
            this.labelMoradaClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMoradaClientes.Name = "labelMoradaClientes";
            this.labelMoradaClientes.Size = new System.Drawing.Size(91, 25);
            this.labelMoradaClientes.TabIndex = 1;
            this.labelMoradaClientes.Text = "Morada:";
            // 
            // labelNomesClientes
            // 
            this.labelNomesClientes.AutoSize = true;
            this.labelNomesClientes.Location = new System.Drawing.Point(20, 48);
            this.labelNomesClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomesClientes.Name = "labelNomesClientes";
            this.labelNomesClientes.Size = new System.Drawing.Size(74, 25);
            this.labelNomesClientes.TabIndex = 0;
            this.labelNomesClientes.Text = "Nome:";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 549);
            this.Controls.Add(this.tabControlClientes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.tabControlClientes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
    }
}