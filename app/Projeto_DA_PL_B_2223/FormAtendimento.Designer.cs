namespace Projeto_DA_PL_B_2223
{
    partial class FormAtendimento
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
            this.tableLayoutPanelEscolherLugar = new System.Windows.Forms.TableLayoutPanel();
            this.button_criarBilhete = new System.Windows.Forms.Button();
            this.radioButton_cliente = new System.Windows.Forms.RadioButton();
            this.radioButton_anonimo = new System.Windows.Forms.RadioButton();
            this.radioButton_novoCliente = new System.Windows.Forms.RadioButton();
            this.textBox_nifAtend = new System.Windows.Forms.TextBox();
            this.labelNumeroFiscalClientes = new System.Windows.Forms.Label();
            this.labelMoradaClientes = new System.Windows.Forms.Label();
            this.labelNomesClientes = new System.Windows.Forms.Label();
            this.textBox_nomeAtend = new System.Windows.Forms.TextBox();
            this.textBox_moradaAtend = new System.Windows.Forms.TextBox();
            this.buttonPesquisarNif = new System.Windows.Forms.Button();
            this.textBox_pesquisa = new System.Windows.Forms.TextBox();
            this.listBox_lugaresSelecionados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_valorBilhete = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNomeSala = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableLayoutPanelEscolherLugar
            // 
            this.tableLayoutPanelEscolherLugar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelEscolherLugar.ColumnCount = 1;
            this.tableLayoutPanelEscolherLugar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelEscolherLugar.Location = new System.Drawing.Point(40, 116);
            this.tableLayoutPanelEscolherLugar.Name = "tableLayoutPanelEscolherLugar";
            this.tableLayoutPanelEscolherLugar.RowCount = 1;
            this.tableLayoutPanelEscolherLugar.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelEscolherLugar.Size = new System.Drawing.Size(1094, 800);
            this.tableLayoutPanelEscolherLugar.TabIndex = 0;
            // 
            // button_criarBilhete
            // 
            this.button_criarBilhete.Location = new System.Drawing.Point(1623, 767);
            this.button_criarBilhete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_criarBilhete.Name = "button_criarBilhete";
            this.button_criarBilhete.Size = new System.Drawing.Size(228, 67);
            this.button_criarBilhete.TabIndex = 9;
            this.button_criarBilhete.Text = "CRIAR BILHETE";
            this.button_criarBilhete.UseVisualStyleBackColor = true;
            this.button_criarBilhete.Click += new System.EventHandler(this.button_criarBilhete_Click);
            // 
            // radioButton_cliente
            // 
            this.radioButton_cliente.AutoSize = true;
            this.radioButton_cliente.Location = new System.Drawing.Point(1210, 67);
            this.radioButton_cliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_cliente.Name = "radioButton_cliente";
            this.radioButton_cliente.Size = new System.Drawing.Size(137, 29);
            this.radioButton_cliente.TabIndex = 1;
            this.radioButton_cliente.TabStop = true;
            this.radioButton_cliente.Text = "CLIENTE ";
            this.radioButton_cliente.UseVisualStyleBackColor = true;
            this.radioButton_cliente.CheckedChanged += new System.EventHandler(this.radioButton_cliente_CheckedChanged);
            // 
            // radioButton_anonimo
            // 
            this.radioButton_anonimo.AutoSize = true;
            this.radioButton_anonimo.Location = new System.Drawing.Point(1654, 67);
            this.radioButton_anonimo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_anonimo.Name = "radioButton_anonimo";
            this.radioButton_anonimo.Size = new System.Drawing.Size(142, 29);
            this.radioButton_anonimo.TabIndex = 3;
            this.radioButton_anonimo.TabStop = true;
            this.radioButton_anonimo.Text = "ANÓNIMO";
            this.radioButton_anonimo.UseVisualStyleBackColor = true;
            this.radioButton_anonimo.CheckedChanged += new System.EventHandler(this.radioButton_anonimo_CheckedChanged);
            // 
            // radioButton_novoCliente
            // 
            this.radioButton_novoCliente.AutoSize = true;
            this.radioButton_novoCliente.Location = new System.Drawing.Point(1401, 67);
            this.radioButton_novoCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_novoCliente.Name = "radioButton_novoCliente";
            this.radioButton_novoCliente.Size = new System.Drawing.Size(198, 29);
            this.radioButton_novoCliente.TabIndex = 2;
            this.radioButton_novoCliente.TabStop = true;
            this.radioButton_novoCliente.Text = "NOVO CLIENTE";
            this.radioButton_novoCliente.UseVisualStyleBackColor = true;
            this.radioButton_novoCliente.CheckedChanged += new System.EventHandler(this.radioButton_novoCliente_CheckedChanged);
            // 
            // textBox_nifAtend
            // 
            this.textBox_nifAtend.Location = new System.Drawing.Point(1370, 359);
            this.textBox_nifAtend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_nifAtend.Name = "textBox_nifAtend";
            this.textBox_nifAtend.ReadOnly = true;
            this.textBox_nifAtend.Size = new System.Drawing.Size(478, 31);
            this.textBox_nifAtend.TabIndex = 8;
            // 
            // labelNumeroFiscalClientes
            // 
            this.labelNumeroFiscalClientes.AutoSize = true;
            this.labelNumeroFiscalClientes.Location = new System.Drawing.Point(1206, 364);
            this.labelNumeroFiscalClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumeroFiscalClientes.Name = "labelNumeroFiscalClientes";
            this.labelNumeroFiscalClientes.Size = new System.Drawing.Size(150, 25);
            this.labelNumeroFiscalClientes.TabIndex = 10;
            this.labelNumeroFiscalClientes.Text = "Numero Fiscal";
            // 
            // labelMoradaClientes
            // 
            this.labelMoradaClientes.AutoSize = true;
            this.labelMoradaClientes.Location = new System.Drawing.Point(1262, 289);
            this.labelMoradaClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMoradaClientes.Name = "labelMoradaClientes";
            this.labelMoradaClientes.Size = new System.Drawing.Size(91, 25);
            this.labelMoradaClientes.TabIndex = 9;
            this.labelMoradaClientes.Text = "Morada:";
            // 
            // labelNomesClientes
            // 
            this.labelNomesClientes.AutoSize = true;
            this.labelNomesClientes.Location = new System.Drawing.Point(1276, 216);
            this.labelNomesClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomesClientes.Name = "labelNomesClientes";
            this.labelNomesClientes.Size = new System.Drawing.Size(74, 25);
            this.labelNomesClientes.TabIndex = 8;
            this.labelNomesClientes.Text = "Nome:";
            // 
            // textBox_nomeAtend
            // 
            this.textBox_nomeAtend.Location = new System.Drawing.Point(1371, 206);
            this.textBox_nomeAtend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_nomeAtend.Name = "textBox_nomeAtend";
            this.textBox_nomeAtend.ReadOnly = true;
            this.textBox_nomeAtend.Size = new System.Drawing.Size(478, 31);
            this.textBox_nomeAtend.TabIndex = 6;
            // 
            // textBox_moradaAtend
            // 
            this.textBox_moradaAtend.Location = new System.Drawing.Point(1370, 284);
            this.textBox_moradaAtend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_moradaAtend.Name = "textBox_moradaAtend";
            this.textBox_moradaAtend.ReadOnly = true;
            this.textBox_moradaAtend.Size = new System.Drawing.Size(478, 31);
            this.textBox_moradaAtend.TabIndex = 7;
            // 
            // buttonPesquisarNif
            // 
            this.buttonPesquisarNif.Location = new System.Drawing.Point(1631, 141);
            this.buttonPesquisarNif.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonPesquisarNif.Name = "buttonPesquisarNif";
            this.buttonPesquisarNif.Size = new System.Drawing.Size(220, 38);
            this.buttonPesquisarNif.TabIndex = 5;
            this.buttonPesquisarNif.Text = "PESQUISAR NIF";
            this.buttonPesquisarNif.UseVisualStyleBackColor = true;
            this.buttonPesquisarNif.Visible = false;
            this.buttonPesquisarNif.Click += new System.EventHandler(this.buttonPesquisarNif_Click);
            // 
            // textBox_pesquisa
            // 
            this.textBox_pesquisa.Location = new System.Drawing.Point(1405, 145);
            this.textBox_pesquisa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_pesquisa.MaxLength = 9;
            this.textBox_pesquisa.Name = "textBox_pesquisa";
            this.textBox_pesquisa.Size = new System.Drawing.Size(218, 31);
            this.textBox_pesquisa.TabIndex = 4;
            this.textBox_pesquisa.Visible = false;
            // 
            // listBox_lugaresSelecionados
            // 
            this.listBox_lugaresSelecionados.FormattingEnabled = true;
            this.listBox_lugaresSelecionados.ItemHeight = 25;
            this.listBox_lugaresSelecionados.Location = new System.Drawing.Point(1222, 481);
            this.listBox_lugaresSelecionados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_lugaresSelecionados.Name = "listBox_lugaresSelecionados";
            this.listBox_lugaresSelecionados.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_lugaresSelecionados.Size = new System.Drawing.Size(607, 129);
            this.listBox_lugaresSelecionados.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1420, 634);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Valor Total";
            // 
            // textBox_valorBilhete
            // 
            this.textBox_valorBilhete.Location = new System.Drawing.Point(1539, 631);
            this.textBox_valorBilhete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_valorBilhete.Name = "textBox_valorBilhete";
            this.textBox_valorBilhete.ReadOnly = true;
            this.textBox_valorBilhete.Size = new System.Drawing.Size(104, 31);
            this.textBox_valorBilhete.TabIndex = 30;
            this.textBox_valorBilhete.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1654, 636);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "€";
            // 
            // labelNomeSala
            // 
            this.labelNomeSala.AutoSize = true;
            this.labelNomeSala.Location = new System.Drawing.Point(222, 70);
            this.labelNomeSala.Name = "labelNomeSala";
            this.labelNomeSala.Size = new System.Drawing.Size(0, 25);
            this.labelNomeSala.TabIndex = 32;
            // 
            // FormAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 877);
            this.Controls.Add(this.labelNomeSala);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_valorBilhete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_lugaresSelecionados);
            this.Controls.Add(this.textBox_pesquisa);
            this.Controls.Add(this.buttonPesquisarNif);
            this.Controls.Add(this.textBox_moradaAtend);
            this.Controls.Add(this.textBox_nomeAtend);
            this.Controls.Add(this.labelNumeroFiscalClientes);
            this.Controls.Add(this.labelMoradaClientes);
            this.Controls.Add(this.labelNomesClientes);
            this.Controls.Add(this.textBox_nifAtend);
            this.Controls.Add(this.radioButton_novoCliente);
            this.Controls.Add(this.radioButton_anonimo);
            this.Controls.Add(this.radioButton_cliente);
            this.Controls.Add(this.button_criarBilhete);
            this.Controls.Add(this.tableLayoutPanelEscolherLugar);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormAtendimento";
            this.Text = "FormAtendimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEscolherLugar;
        private System.Windows.Forms.Button button_criarBilhete;
        private System.Windows.Forms.RadioButton radioButton_cliente;
        private System.Windows.Forms.RadioButton radioButton_anonimo;
        private System.Windows.Forms.RadioButton radioButton_novoCliente;
        private System.Windows.Forms.TextBox textBox_nifAtend;
        private System.Windows.Forms.Label labelNumeroFiscalClientes;
        private System.Windows.Forms.Label labelMoradaClientes;
        private System.Windows.Forms.Label labelNomesClientes;
        private System.Windows.Forms.TextBox textBox_nomeAtend;
        private System.Windows.Forms.TextBox textBox_moradaAtend;
        private System.Windows.Forms.Button buttonPesquisarNif;
        private System.Windows.Forms.TextBox textBox_pesquisa;
        private System.Windows.Forms.ListBox listBox_lugaresSelecionados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_valorBilhete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNomeSala;
    }
}