namespace Projeto_DA_PL_B_2223
{
    partial class FormSessoes
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
            this.button_apagar_sessoes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPrecoSessoes = new System.Windows.Forms.Label();
            this.textBoxPrecoSessoes = new System.Windows.Forms.TextBox();
            this.dateTimePickerHoraSessao = new System.Windows.Forms.DateTimePicker();
            this.labelHoraSessoes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxFilmesSessoes = new System.Windows.Forms.ListBox();
            this.listBoxSalasSessoes = new System.Windows.Forms.ListBox();
            this.dateTimePickerDataSessao = new System.Windows.Forms.DateTimePicker();
            this.buttonCriarSessoes = new System.Windows.Forms.Button();
            this.listBoxSessoes = new System.Windows.Forms.ListBox();
            this.labelDataSessoes = new System.Windows.Forms.Label();
            this.labelEscolherSalaSessoes = new System.Windows.Forms.Label();
            this.labelEscolherFilmesSessoes = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1132, 545);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_apagar_sessoes);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelPrecoSessoes);
            this.tabPage1.Controls.Add(this.textBoxPrecoSessoes);
            this.tabPage1.Controls.Add(this.dateTimePickerHoraSessao);
            this.tabPage1.Controls.Add(this.labelHoraSessoes);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listBoxFilmesSessoes);
            this.tabPage1.Controls.Add(this.listBoxSalasSessoes);
            this.tabPage1.Controls.Add(this.dateTimePickerDataSessao);
            this.tabPage1.Controls.Add(this.buttonCriarSessoes);
            this.tabPage1.Controls.Add(this.listBoxSessoes);
            this.tabPage1.Controls.Add(this.labelDataSessoes);
            this.tabPage1.Controls.Add(this.labelEscolherSalaSessoes);
            this.tabPage1.Controls.Add(this.labelEscolherFilmesSessoes);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1124, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sessões";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabPage1_MouseClick);
            // 
            // button_apagar_sessoes
            // 
            this.button_apagar_sessoes.Location = new System.Drawing.Point(710, 452);
            this.button_apagar_sessoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_apagar_sessoes.Name = "button_apagar_sessoes";
            this.button_apagar_sessoes.Size = new System.Drawing.Size(157, 36);
            this.button_apagar_sessoes.TabIndex = 19;
            this.button_apagar_sessoes.Text = "APAGAR";
            this.button_apagar_sessoes.UseVisualStyleBackColor = true;
            this.button_apagar_sessoes.Click += new System.EventHandler(this.button_apagar_sessoes_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1091, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "€";
            // 
            // labelPrecoSessoes
            // 
            this.labelPrecoSessoes.AutoSize = true;
            this.labelPrecoSessoes.Location = new System.Drawing.Point(968, 117);
            this.labelPrecoSessoes.Name = "labelPrecoSessoes";
            this.labelPrecoSessoes.Size = new System.Drawing.Size(46, 16);
            this.labelPrecoSessoes.TabIndex = 17;
            this.labelPrecoSessoes.Text = "Preço:";
            // 
            // textBoxPrecoSessoes
            // 
            this.textBoxPrecoSessoes.Location = new System.Drawing.Point(960, 137);
            this.textBoxPrecoSessoes.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrecoSessoes.Name = "textBoxPrecoSessoes";
            this.textBoxPrecoSessoes.Size = new System.Drawing.Size(132, 22);
            this.textBoxPrecoSessoes.TabIndex = 16;
            // 
            // dateTimePickerHoraSessao
            // 
            this.dateTimePickerHoraSessao.CustomFormat = "HH:mm";
            this.dateTimePickerHoraSessao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHoraSessao.Location = new System.Drawing.Point(960, 84);
            this.dateTimePickerHoraSessao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerHoraSessao.Name = "dateTimePickerHoraSessao";
            this.dateTimePickerHoraSessao.ShowUpDown = true;
            this.dateTimePickerHoraSessao.Size = new System.Drawing.Size(144, 22);
            this.dateTimePickerHoraSessao.TabIndex = 15;
            this.dateTimePickerHoraSessao.Value = new System.DateTime(2023, 6, 2, 19, 11, 41, 0);
            // 
            // labelHoraSessoes
            // 
            this.labelHoraSessoes.AutoSize = true;
            this.labelHoraSessoes.Location = new System.Drawing.Point(965, 64);
            this.labelHoraSessoes.Name = "labelHoraSessoes";
            this.labelHoraSessoes.Size = new System.Drawing.Size(40, 16);
            this.labelHoraSessoes.TabIndex = 14;
            this.labelHoraSessoes.Text = "Hora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sessões Criadas:";
            // 
            // listBoxFilmesSessoes
            // 
            this.listBoxFilmesSessoes.FormattingEnabled = true;
            this.listBoxFilmesSessoes.ItemHeight = 16;
            this.listBoxFilmesSessoes.Location = new System.Drawing.Point(8, 38);
            this.listBoxFilmesSessoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxFilmesSessoes.Name = "listBoxFilmesSessoes";
            this.listBoxFilmesSessoes.Size = new System.Drawing.Size(439, 212);
            this.listBoxFilmesSessoes.TabIndex = 12;
            this.listBoxFilmesSessoes.SelectedIndexChanged += new System.EventHandler(this.listBoxFilmesSessoes_SelectedIndexChanged);
            // 
            // listBoxSalasSessoes
            // 
            this.listBoxSalasSessoes.FormattingEnabled = true;
            this.listBoxSalasSessoes.ItemHeight = 16;
            this.listBoxSalasSessoes.Location = new System.Drawing.Point(488, 38);
            this.listBoxSalasSessoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxSalasSessoes.Name = "listBoxSalasSessoes";
            this.listBoxSalasSessoes.Size = new System.Drawing.Size(439, 212);
            this.listBoxSalasSessoes.TabIndex = 11;
            // 
            // dateTimePickerDataSessao
            // 
            this.dateTimePickerDataSessao.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDataSessao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataSessao.Location = new System.Drawing.Point(960, 38);
            this.dateTimePickerDataSessao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerDataSessao.MinDate = new System.DateTime(2023, 6, 2, 0, 0, 0, 0);
            this.dateTimePickerDataSessao.Name = "dateTimePickerDataSessao";
            this.dateTimePickerDataSessao.Size = new System.Drawing.Size(144, 22);
            this.dateTimePickerDataSessao.TabIndex = 10;
            this.dateTimePickerDataSessao.Value = new System.DateTime(2023, 6, 2, 19, 11, 13, 0);
            // 
            // buttonCriarSessoes
            // 
            this.buttonCriarSessoes.Location = new System.Drawing.Point(960, 169);
            this.buttonCriarSessoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCriarSessoes.Name = "buttonCriarSessoes";
            this.buttonCriarSessoes.Size = new System.Drawing.Size(144, 36);
            this.buttonCriarSessoes.TabIndex = 7;
            this.buttonCriarSessoes.Text = "Criar Sessão";
            this.buttonCriarSessoes.UseVisualStyleBackColor = true;
            this.buttonCriarSessoes.Click += new System.EventHandler(this.buttonCriarSessoes_Click);
            // 
            // listBoxSessoes
            // 
            this.listBoxSessoes.FormattingEnabled = true;
            this.listBoxSessoes.ItemHeight = 16;
            this.listBoxSessoes.Location = new System.Drawing.Point(8, 292);
            this.listBoxSessoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxSessoes.Name = "listBoxSessoes";
            this.listBoxSessoes.Size = new System.Drawing.Size(696, 196);
            this.listBoxSessoes.TabIndex = 6;
            // 
            // labelDataSessoes
            // 
            this.labelDataSessoes.AutoSize = true;
            this.labelDataSessoes.Location = new System.Drawing.Point(965, 19);
            this.labelDataSessoes.Name = "labelDataSessoes";
            this.labelDataSessoes.Size = new System.Drawing.Size(39, 16);
            this.labelDataSessoes.TabIndex = 2;
            this.labelDataSessoes.Text = "Data:";
            // 
            // labelEscolherSalaSessoes
            // 
            this.labelEscolherSalaSessoes.AutoSize = true;
            this.labelEscolherSalaSessoes.Location = new System.Drawing.Point(496, 19);
            this.labelEscolherSalaSessoes.Name = "labelEscolherSalaSessoes";
            this.labelEscolherSalaSessoes.Size = new System.Drawing.Size(94, 16);
            this.labelEscolherSalaSessoes.TabIndex = 1;
            this.labelEscolherSalaSessoes.Text = "Escolher Sala:";
            // 
            // labelEscolherFilmesSessoes
            // 
            this.labelEscolherFilmesSessoes.AutoSize = true;
            this.labelEscolherFilmesSessoes.Location = new System.Drawing.Point(15, 19);
            this.labelEscolherFilmesSessoes.Name = "labelEscolherFilmesSessoes";
            this.labelEscolherFilmesSessoes.Size = new System.Drawing.Size(99, 16);
            this.labelEscolherFilmesSessoes.TabIndex = 0;
            this.labelEscolherFilmesSessoes.Text = "Escolher Filme:";
            // 
            // FormSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 563);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSessoes";
            this.Text = "FormSessoes";
            this.Load += new System.EventHandler(this.FormSessoes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelEscolherSalaSessoes;
        private System.Windows.Forms.Label labelEscolherFilmesSessoes;
        private System.Windows.Forms.Button buttonCriarSessoes;
        private System.Windows.Forms.ListBox listBoxSessoes;
        private System.Windows.Forms.ListBox listBoxFilmesSessoes;
        private System.Windows.Forms.ListBox listBoxSalasSessoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataSessao;
        private System.Windows.Forms.Label labelDataSessoes;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraSessao;
        private System.Windows.Forms.Label labelHoraSessoes;
        private System.Windows.Forms.TextBox textBoxPrecoSessoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPrecoSessoes;
        private System.Windows.Forms.Button button_apagar_sessoes;
    }
}