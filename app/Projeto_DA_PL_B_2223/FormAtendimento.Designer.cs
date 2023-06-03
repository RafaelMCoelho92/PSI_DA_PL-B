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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelNumeroFiscalClientes = new System.Windows.Forms.Label();
            this.labelMoradaClientes = new System.Windows.Forms.Label();
            this.labelNomesClientes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonPesquisarNif = new System.Windows.Forms.Button();
            this.textBox_pesquisa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tableLayoutPanelEscolherLugar
            // 
            this.tableLayoutPanelEscolherLugar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelEscolherLugar.ColumnCount = 1;
            this.tableLayoutPanelEscolherLugar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelEscolherLugar.Location = new System.Drawing.Point(24, 22);
            this.tableLayoutPanelEscolherLugar.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelEscolherLugar.Name = "tableLayoutPanelEscolherLugar";
            this.tableLayoutPanelEscolherLugar.RowCount = 1;
            this.tableLayoutPanelEscolherLugar.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelEscolherLugar.Size = new System.Drawing.Size(729, 512);
            this.tableLayoutPanelEscolherLugar.TabIndex = 0;
            // 
            // button_criarBilhete
            // 
            this.button_criarBilhete.Location = new System.Drawing.Point(1082, 491);
            this.button_criarBilhete.Name = "button_criarBilhete";
            this.button_criarBilhete.Size = new System.Drawing.Size(152, 43);
            this.button_criarBilhete.TabIndex = 1;
            this.button_criarBilhete.Text = "CRIAR BILHETE";
            this.button_criarBilhete.UseVisualStyleBackColor = true;
            // 
            // radioButton_cliente
            // 
            this.radioButton_cliente.AutoSize = true;
            this.radioButton_cliente.Location = new System.Drawing.Point(807, 43);
            this.radioButton_cliente.Name = "radioButton_cliente";
            this.radioButton_cliente.Size = new System.Drawing.Size(87, 20);
            this.radioButton_cliente.TabIndex = 2;
            this.radioButton_cliente.TabStop = true;
            this.radioButton_cliente.Text = "CLIENTE ";
            this.radioButton_cliente.UseVisualStyleBackColor = true;
            this.radioButton_cliente.CheckedChanged += new System.EventHandler(this.radioButton_cliente_CheckedChanged);
            // 
            // radioButton_anonimo
            // 
            this.radioButton_anonimo.AutoSize = true;
            this.radioButton_anonimo.Location = new System.Drawing.Point(1103, 43);
            this.radioButton_anonimo.Name = "radioButton_anonimo";
            this.radioButton_anonimo.Size = new System.Drawing.Size(91, 20);
            this.radioButton_anonimo.TabIndex = 3;
            this.radioButton_anonimo.TabStop = true;
            this.radioButton_anonimo.Text = "ANÓNIMO";
            this.radioButton_anonimo.UseVisualStyleBackColor = true;
            // 
            // radioButton_novoCliente
            // 
            this.radioButton_novoCliente.AutoSize = true;
            this.radioButton_novoCliente.Location = new System.Drawing.Point(934, 43);
            this.radioButton_novoCliente.Name = "radioButton_novoCliente";
            this.radioButton_novoCliente.Size = new System.Drawing.Size(126, 20);
            this.radioButton_novoCliente.TabIndex = 4;
            this.radioButton_novoCliente.TabStop = true;
            this.radioButton_novoCliente.Text = "NOVO CLIENTE";
            this.radioButton_novoCliente.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(913, 230);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(320, 22);
            this.textBox2.TabIndex = 6;
            // 
            // labelNumeroFiscalClientes
            // 
            this.labelNumeroFiscalClientes.AutoSize = true;
            this.labelNumeroFiscalClientes.Location = new System.Drawing.Point(804, 233);
            this.labelNumeroFiscalClientes.Name = "labelNumeroFiscalClientes";
            this.labelNumeroFiscalClientes.Size = new System.Drawing.Size(94, 16);
            this.labelNumeroFiscalClientes.TabIndex = 10;
            this.labelNumeroFiscalClientes.Text = "Numero Fiscal";
            // 
            // labelMoradaClientes
            // 
            this.labelMoradaClientes.AutoSize = true;
            this.labelMoradaClientes.Location = new System.Drawing.Point(841, 185);
            this.labelMoradaClientes.Name = "labelMoradaClientes";
            this.labelMoradaClientes.Size = new System.Drawing.Size(57, 16);
            this.labelMoradaClientes.TabIndex = 9;
            this.labelMoradaClientes.Text = "Morada:";
            // 
            // labelNomesClientes
            // 
            this.labelNomesClientes.AutoSize = true;
            this.labelNomesClientes.Location = new System.Drawing.Point(851, 138);
            this.labelNomesClientes.Name = "labelNomesClientes";
            this.labelNomesClientes.Size = new System.Drawing.Size(47, 16);
            this.labelNomesClientes.TabIndex = 8;
            this.labelNomesClientes.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(914, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 22);
            this.textBox1.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(913, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(320, 22);
            this.textBox3.TabIndex = 12;
            // 
            // buttonPesquisarNif
            // 
            this.buttonPesquisarNif.Location = new System.Drawing.Point(950, 89);
            this.buttonPesquisarNif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPesquisarNif.Name = "buttonPesquisarNif";
            this.buttonPesquisarNif.Size = new System.Drawing.Size(147, 24);
            this.buttonPesquisarNif.TabIndex = 26;
            this.buttonPesquisarNif.Text = "PESQUISAR NIF";
            this.buttonPesquisarNif.UseVisualStyleBackColor = true;
            // 
            // textBox_pesquisa
            // 
            this.textBox_pesquisa.Location = new System.Drawing.Point(1103, 89);
            this.textBox_pesquisa.MaxLength = 9;
            this.textBox_pesquisa.Name = "textBox_pesquisa";
            this.textBox_pesquisa.Size = new System.Drawing.Size(147, 22);
            this.textBox_pesquisa.TabIndex = 27;
            // 
            // FormAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 561);
            this.Controls.Add(this.textBox_pesquisa);
            this.Controls.Add(this.buttonPesquisarNif);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNumeroFiscalClientes);
            this.Controls.Add(this.labelMoradaClientes);
            this.Controls.Add(this.labelNomesClientes);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.radioButton_novoCliente);
            this.Controls.Add(this.radioButton_anonimo);
            this.Controls.Add(this.radioButton_cliente);
            this.Controls.Add(this.button_criarBilhete);
            this.Controls.Add(this.tableLayoutPanelEscolherLugar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelNumeroFiscalClientes;
        private System.Windows.Forms.Label labelMoradaClientes;
        private System.Windows.Forms.Label labelNomesClientes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonPesquisarNif;
        private System.Windows.Forms.TextBox textBox_pesquisa;
    }
}