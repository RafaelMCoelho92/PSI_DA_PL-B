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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxFilmesSessoes = new System.Windows.Forms.ListBox();
            this.listBoxSalasSessoes = new System.Windows.Forms.ListBox();
            this.dateTimePickerSessao = new System.Windows.Forms.DateTimePicker();
            this.buttonCriarSessoes = new System.Windows.Forms.Button();
            this.listBoxSessoes = new System.Windows.Forms.ListBox();
            this.buttonVerificarDispSessoes = new System.Windows.Forms.Button();
            this.labelDataHoraSessoes = new System.Windows.Forms.Label();
            this.labelEscolherSalaSessoes = new System.Windows.Forms.Label();
            this.labelEscolherFilmesSessoes = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(849, 443);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listBoxFilmesSessoes);
            this.tabPage1.Controls.Add(this.listBoxSalasSessoes);
            this.tabPage1.Controls.Add(this.dateTimePickerSessao);
            this.tabPage1.Controls.Add(this.buttonCriarSessoes);
            this.tabPage1.Controls.Add(this.listBoxSessoes);
            this.tabPage1.Controls.Add(this.buttonVerificarDispSessoes);
            this.tabPage1.Controls.Add(this.labelDataHoraSessoes);
            this.tabPage1.Controls.Add(this.labelEscolherSalaSessoes);
            this.tabPage1.Controls.Add(this.labelEscolherFilmesSessoes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(841, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sessões";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabPage1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sessões Criadas:";
            // 
            // listBoxFilmesSessoes
            // 
            this.listBoxFilmesSessoes.FormattingEnabled = true;
            this.listBoxFilmesSessoes.Location = new System.Drawing.Point(6, 31);
            this.listBoxFilmesSessoes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxFilmesSessoes.Name = "listBoxFilmesSessoes";
            this.listBoxFilmesSessoes.Size = new System.Drawing.Size(330, 173);
            this.listBoxFilmesSessoes.TabIndex = 12;
            // 
            // listBoxSalasSessoes
            // 
            this.listBoxSalasSessoes.FormattingEnabled = true;
            this.listBoxSalasSessoes.Location = new System.Drawing.Point(6, 234);
            this.listBoxSalasSessoes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxSalasSessoes.Name = "listBoxSalasSessoes";
            this.listBoxSalasSessoes.Size = new System.Drawing.Size(330, 173);
            this.listBoxSalasSessoes.TabIndex = 11;
            // 
            // dateTimePickerSessao
            // 
            this.dateTimePickerSessao.Location = new System.Drawing.Point(383, 31);
            this.dateTimePickerSessao.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePickerSessao.Name = "dateTimePickerSessao";
            this.dateTimePickerSessao.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerSessao.TabIndex = 10;
            // 
            // buttonCriarSessoes
            // 
            this.buttonCriarSessoes.Location = new System.Drawing.Point(694, 379);
            this.buttonCriarSessoes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCriarSessoes.Name = "buttonCriarSessoes";
            this.buttonCriarSessoes.Size = new System.Drawing.Size(143, 29);
            this.buttonCriarSessoes.TabIndex = 7;
            this.buttonCriarSessoes.Text = "Criar Sessão";
            this.buttonCriarSessoes.UseVisualStyleBackColor = true;
            this.buttonCriarSessoes.Click += new System.EventHandler(this.buttonCriarSessoes_Click);
            // 
            // listBoxSessoes
            // 
            this.listBoxSessoes.FormattingEnabled = true;
            this.listBoxSessoes.Location = new System.Drawing.Point(585, 31);
            this.listBoxSessoes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxSessoes.Name = "listBoxSessoes";
            this.listBoxSessoes.Size = new System.Drawing.Size(252, 342);
            this.listBoxSessoes.TabIndex = 6;
            // 
            // buttonVerificarDispSessoes
            // 
            this.buttonVerificarDispSessoes.Location = new System.Drawing.Point(194, 204);
            this.buttonVerificarDispSessoes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonVerificarDispSessoes.Name = "buttonVerificarDispSessoes";
            this.buttonVerificarDispSessoes.Size = new System.Drawing.Size(143, 29);
            this.buttonVerificarDispSessoes.TabIndex = 5;
            this.buttonVerificarDispSessoes.Text = "Verificar Disponibilidade";
            this.buttonVerificarDispSessoes.UseVisualStyleBackColor = true;
            // 
            // labelDataHoraSessoes
            // 
            this.labelDataHoraSessoes.AutoSize = true;
            this.labelDataHoraSessoes.Location = new System.Drawing.Point(388, 15);
            this.labelDataHoraSessoes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDataHoraSessoes.Name = "labelDataHoraSessoes";
            this.labelDataHoraSessoes.Size = new System.Drawing.Size(61, 13);
            this.labelDataHoraSessoes.TabIndex = 2;
            this.labelDataHoraSessoes.Text = "Data/Hora:";
            // 
            // labelEscolherSalaSessoes
            // 
            this.labelEscolherSalaSessoes.AutoSize = true;
            this.labelEscolherSalaSessoes.Location = new System.Drawing.Point(12, 218);
            this.labelEscolherSalaSessoes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEscolherSalaSessoes.Name = "labelEscolherSalaSessoes";
            this.labelEscolherSalaSessoes.Size = new System.Drawing.Size(75, 13);
            this.labelEscolherSalaSessoes.TabIndex = 1;
            this.labelEscolherSalaSessoes.Text = "Escolher Sala:";
            // 
            // labelEscolherFilmesSessoes
            // 
            this.labelEscolherFilmesSessoes.AutoSize = true;
            this.labelEscolherFilmesSessoes.Location = new System.Drawing.Point(11, 15);
            this.labelEscolherFilmesSessoes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEscolherFilmesSessoes.Name = "labelEscolherFilmesSessoes";
            this.labelEscolherFilmesSessoes.Size = new System.Drawing.Size(78, 13);
            this.labelEscolherFilmesSessoes.TabIndex = 0;
            this.labelEscolherFilmesSessoes.Text = "Escolher Filme:";
            // 
            // FormSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 457);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button buttonVerificarDispSessoes;
        private System.Windows.Forms.ListBox listBoxFilmesSessoes;
        private System.Windows.Forms.ListBox listBoxSalasSessoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerSessao;
        private System.Windows.Forms.Label labelDataHoraSessoes;
    }
}