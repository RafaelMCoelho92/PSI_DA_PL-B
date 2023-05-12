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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonCriarBilheteAtend = new System.Windows.Forms.Button();
            this.listBoxSalaSessãoAtend = new System.Windows.Forms.ListBox();
            this.groupBoxInserirSalas = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_sala_atendimento = new System.Windows.Forms.Label();
            this.listBoxSalaAtendimento_lugares = new System.Windows.Forms.ListBox();
            this.listBoxLugSelecionado = new System.Windows.Forms.ListBox();
            this.buttonVoltarAtend = new System.Windows.Forms.Button();
            this.label_cliente_anónimo = new System.Windows.Forms.Label();
            this.label_numero_fiscal = new System.Windows.Forms.Label();
            this.label_morada_atend = new System.Windows.Forms.Label();
            this.listBoxNomeAnonimo = new System.Windows.Forms.ListBox();
            this.listBoxNumeroFiscal = new System.Windows.Forms.ListBox();
            this.listBoxMorada = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxInserirSalas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-4, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 427);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonVoltarAtend);
            this.tabPage1.Controls.Add(this.buttonCriarBilheteAtend);
            this.tabPage1.Controls.Add(this.groupBoxInserirSalas);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(801, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonCriarBilheteAtend
            // 
            this.buttonCriarBilheteAtend.Location = new System.Drawing.Point(594, 336);
            this.buttonCriarBilheteAtend.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCriarBilheteAtend.Name = "buttonCriarBilheteAtend";
            this.buttonCriarBilheteAtend.Size = new System.Drawing.Size(176, 42);
            this.buttonCriarBilheteAtend.TabIndex = 9;
            this.buttonCriarBilheteAtend.Text = "Criar Bilhete";
            this.buttonCriarBilheteAtend.UseVisualStyleBackColor = true;
            // 
            // listBoxSalaSessãoAtend
            // 
            this.listBoxSalaSessãoAtend.FormattingEnabled = true;
            this.listBoxSalaSessãoAtend.ItemHeight = 16;
            this.listBoxSalaSessãoAtend.Location = new System.Drawing.Point(418, 57);
            this.listBoxSalaSessãoAtend.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSalaSessãoAtend.Name = "listBoxSalaSessãoAtend";
            this.listBoxSalaSessãoAtend.Size = new System.Drawing.Size(322, 148);
            this.listBoxSalaSessãoAtend.TabIndex = 0;
            // 
            // groupBoxInserirSalas
            // 
            this.groupBoxInserirSalas.Controls.Add(this.label_sala_atendimento);
            this.groupBoxInserirSalas.Controls.Add(this.listBoxLugSelecionado);
            this.groupBoxInserirSalas.Controls.Add(this.listBoxSalaAtendimento_lugares);
            this.groupBoxInserirSalas.Controls.Add(this.comboBox2);
            this.groupBoxInserirSalas.Controls.Add(this.label1);
            this.groupBoxInserirSalas.Controls.Add(this.comboBox1);
            this.groupBoxInserirSalas.Controls.Add(this.listBoxSalaSessãoAtend);
            this.groupBoxInserirSalas.Controls.Add(this.listBoxMorada);
            this.groupBoxInserirSalas.Controls.Add(this.listBoxNumeroFiscal);
            this.groupBoxInserirSalas.Controls.Add(this.listBoxNomeAnonimo);
            this.groupBoxInserirSalas.Controls.Add(this.label_morada_atend);
            this.groupBoxInserirSalas.Controls.Add(this.label_numero_fiscal);
            this.groupBoxInserirSalas.Controls.Add(this.label_cliente_anónimo);
            this.groupBoxInserirSalas.Controls.Add(this.label7);
            this.groupBoxInserirSalas.Location = new System.Drawing.Point(4, 18);
            this.groupBoxInserirSalas.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInserirSalas.Name = "groupBoxInserirSalas";
            this.groupBoxInserirSalas.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInserirSalas.Size = new System.Drawing.Size(766, 300);
            this.groupBoxInserirSalas.TabIndex = 10;
            this.groupBoxInserirSalas.TabStop = false;
            this.groupBoxInserirSalas.Text = "Sala de Sessão ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sessão:";
            // 
            // label_sala_atendimento
            // 
            this.label_sala_atendimento.AutoSize = true;
            this.label_sala_atendimento.Location = new System.Drawing.Point(504, 24);
            this.label_sala_atendimento.Name = "label_sala_atendimento";
            this.label_sala_atendimento.Size = new System.Drawing.Size(35, 16);
            this.label_sala_atendimento.TabIndex = 1;
            this.label_sala_atendimento.Text = "Sala";
            // 
            // listBoxSalaAtendimento_lugares
            // 
            this.listBoxSalaAtendimento_lugares.FormattingEnabled = true;
            this.listBoxSalaAtendimento_lugares.ItemHeight = 16;
            this.listBoxSalaAtendimento_lugares.Location = new System.Drawing.Point(545, 24);
            this.listBoxSalaAtendimento_lugares.Name = "listBoxSalaAtendimento_lugares";
            this.listBoxSalaAtendimento_lugares.Size = new System.Drawing.Size(102, 20);
            this.listBoxSalaAtendimento_lugares.TabIndex = 2;
            // 
            // listBoxLugSelecionado
            // 
            this.listBoxLugSelecionado.FormattingEnabled = true;
            this.listBoxLugSelecionado.ItemHeight = 16;
            this.listBoxLugSelecionado.Location = new System.Drawing.Point(418, 221);
            this.listBoxLugSelecionado.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLugSelecionado.Name = "listBoxLugSelecionado";
            this.listBoxLugSelecionado.Size = new System.Drawing.Size(322, 68);
            this.listBoxLugSelecionado.TabIndex = 3;
            // 
            // buttonVoltarAtend
            // 
            this.buttonVoltarAtend.Location = new System.Drawing.Point(31, 353);
            this.buttonVoltarAtend.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVoltarAtend.Name = "buttonVoltarAtend";
            this.buttonVoltarAtend.Size = new System.Drawing.Size(108, 25);
            this.buttonVoltarAtend.TabIndex = 12;
            this.buttonVoltarAtend.Text = "Criar Bilhete";
            this.buttonVoltarAtend.UseVisualStyleBackColor = true;
            // 
            // label_cliente_anónimo
            // 
            this.label_cliente_anónimo.AutoSize = true;
            this.label_cliente_anónimo.Location = new System.Drawing.Point(24, 138);
            this.label_cliente_anónimo.Name = "label_cliente_anónimo";
            this.label_cliente_anónimo.Size = new System.Drawing.Size(144, 16);
            this.label_cliente_anónimo.TabIndex = 9;
            this.label_cliente_anónimo.Text = "Nome Cliente Anónimo";
            // 
            // label_numero_fiscal
            // 
            this.label_numero_fiscal.AutoSize = true;
            this.label_numero_fiscal.Location = new System.Drawing.Point(24, 180);
            this.label_numero_fiscal.Name = "label_numero_fiscal";
            this.label_numero_fiscal.Size = new System.Drawing.Size(94, 16);
            this.label_numero_fiscal.TabIndex = 10;
            this.label_numero_fiscal.Text = "Numero Fiscal";
            // 
            // label_morada_atend
            // 
            this.label_morada_atend.AutoSize = true;
            this.label_morada_atend.Location = new System.Drawing.Point(24, 221);
            this.label_morada_atend.Name = "label_morada_atend";
            this.label_morada_atend.Size = new System.Drawing.Size(54, 16);
            this.label_morada_atend.TabIndex = 11;
            this.label_morada_atend.Text = "Morada";
            // 
            // listBoxNomeAnonimo
            // 
            this.listBoxNomeAnonimo.FormattingEnabled = true;
            this.listBoxNomeAnonimo.ItemHeight = 16;
            this.listBoxNomeAnonimo.Location = new System.Drawing.Point(191, 138);
            this.listBoxNomeAnonimo.Name = "listBoxNomeAnonimo";
            this.listBoxNomeAnonimo.Size = new System.Drawing.Size(159, 36);
            this.listBoxNomeAnonimo.TabIndex = 12;
            // 
            // listBoxNumeroFiscal
            // 
            this.listBoxNumeroFiscal.FormattingEnabled = true;
            this.listBoxNumeroFiscal.ItemHeight = 16;
            this.listBoxNumeroFiscal.Location = new System.Drawing.Point(191, 180);
            this.listBoxNumeroFiscal.Name = "listBoxNumeroFiscal";
            this.listBoxNumeroFiscal.Size = new System.Drawing.Size(159, 36);
            this.listBoxNumeroFiscal.TabIndex = 13;
            // 
            // listBoxMorada
            // 
            this.listBoxMorada.FormattingEnabled = true;
            this.listBoxMorada.ItemHeight = 16;
            this.listBoxMorada.Location = new System.Drawing.Point(191, 222);
            this.listBoxMorada.Name = "listBoxMorada";
            this.listBoxMorada.Size = new System.Drawing.Size(159, 36);
            this.listBoxMorada.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cliente:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(209, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(141, 24);
            this.comboBox2.TabIndex = 17;
            // 
            // FormAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAtendimento";
            this.Text = "FormAtendimento";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxInserirSalas.ResumeLayout(false);
            this.groupBoxInserirSalas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonCriarBilheteAtend;
        private System.Windows.Forms.ListBox listBoxSalaSessãoAtend;
        private System.Windows.Forms.GroupBox groupBoxInserirSalas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxLugSelecionado;
        private System.Windows.Forms.ListBox listBoxSalaAtendimento_lugares;
        private System.Windows.Forms.Label label_sala_atendimento;
        private System.Windows.Forms.Button buttonVoltarAtend;
        private System.Windows.Forms.ListBox listBoxNomeAnonimo;
        private System.Windows.Forms.Label label_morada_atend;
        private System.Windows.Forms.Label label_numero_fiscal;
        private System.Windows.Forms.Label label_cliente_anónimo;
        private System.Windows.Forms.ListBox listBoxMorada;
        private System.Windows.Forms.ListBox listBoxNumeroFiscal;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}