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
            this.labelEscolherFilmesSessoes = new System.Windows.Forms.Label();
            this.labelEscolherSalaSessoes = new System.Windows.Forms.Label();
            this.labelDataHoraSessoes = new System.Windows.Forms.Label();
            this.comboBoxFilmeSessoes = new System.Windows.Forms.ComboBox();
            this.comboBoxSalaSessoes = new System.Windows.Forms.ComboBox();
            this.buttonVerificarDispSessoes = new System.Windows.Forms.Button();
            this.listBoxSessoes = new System.Windows.Forms.ListBox();
            this.buttonGuardarSessoes = new System.Windows.Forms.Button();
            this.buttonVoltarSessoes = new System.Windows.Forms.Button();
            this.dateTimePickerSessaoTopo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSessao = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(825, 361);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePickerSessao);
            this.tabPage1.Controls.Add(this.dateTimePickerSessaoTopo);
            this.tabPage1.Controls.Add(this.buttonVoltarSessoes);
            this.tabPage1.Controls.Add(this.buttonGuardarSessoes);
            this.tabPage1.Controls.Add(this.listBoxSessoes);
            this.tabPage1.Controls.Add(this.buttonVerificarDispSessoes);
            this.tabPage1.Controls.Add(this.comboBoxSalaSessoes);
            this.tabPage1.Controls.Add(this.comboBoxFilmeSessoes);
            this.tabPage1.Controls.Add(this.labelDataHoraSessoes);
            this.tabPage1.Controls.Add(this.labelEscolherSalaSessoes);
            this.tabPage1.Controls.Add(this.labelEscolherFilmesSessoes);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(817, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelEscolherFilmesSessoes
            // 
            this.labelEscolherFilmesSessoes.AutoSize = true;
            this.labelEscolherFilmesSessoes.Location = new System.Drawing.Point(41, 82);
            this.labelEscolherFilmesSessoes.Name = "labelEscolherFilmesSessoes";
            this.labelEscolherFilmesSessoes.Size = new System.Drawing.Size(96, 16);
            this.labelEscolherFilmesSessoes.TabIndex = 0;
            this.labelEscolherFilmesSessoes.Text = "Escolher Filme";
            // 
            // labelEscolherSalaSessoes
            // 
            this.labelEscolherSalaSessoes.AutoSize = true;
            this.labelEscolherSalaSessoes.Location = new System.Drawing.Point(41, 127);
            this.labelEscolherSalaSessoes.Name = "labelEscolherSalaSessoes";
            this.labelEscolherSalaSessoes.Size = new System.Drawing.Size(96, 16);
            this.labelEscolherSalaSessoes.TabIndex = 1;
            this.labelEscolherSalaSessoes.Text = "Escolher Filme";
            // 
            // labelDataHoraSessoes
            // 
            this.labelDataHoraSessoes.AutoSize = true;
            this.labelDataHoraSessoes.Location = new System.Drawing.Point(41, 182);
            this.labelDataHoraSessoes.Name = "labelDataHoraSessoes";
            this.labelDataHoraSessoes.Size = new System.Drawing.Size(70, 16);
            this.labelDataHoraSessoes.TabIndex = 2;
            this.labelDataHoraSessoes.Text = "Data/Hora";
            // 
            // comboBoxFilmeSessoes
            // 
            this.comboBoxFilmeSessoes.FormattingEnabled = true;
            this.comboBoxFilmeSessoes.Location = new System.Drawing.Point(170, 74);
            this.comboBoxFilmeSessoes.Name = "comboBoxFilmeSessoes";
            this.comboBoxFilmeSessoes.Size = new System.Drawing.Size(147, 24);
            this.comboBoxFilmeSessoes.TabIndex = 3;
            // 
            // comboBoxSalaSessoes
            // 
            this.comboBoxSalaSessoes.FormattingEnabled = true;
            this.comboBoxSalaSessoes.Location = new System.Drawing.Point(170, 119);
            this.comboBoxSalaSessoes.Name = "comboBoxSalaSessoes";
            this.comboBoxSalaSessoes.Size = new System.Drawing.Size(147, 24);
            this.comboBoxSalaSessoes.TabIndex = 4;
            // 
            // buttonVerificarDispSessoes
            // 
            this.buttonVerificarDispSessoes.Location = new System.Drawing.Point(99, 219);
            this.buttonVerificarDispSessoes.Name = "buttonVerificarDispSessoes";
            this.buttonVerificarDispSessoes.Size = new System.Drawing.Size(228, 51);
            this.buttonVerificarDispSessoes.TabIndex = 5;
            this.buttonVerificarDispSessoes.Text = "Verificar Disponibilidade";
            this.buttonVerificarDispSessoes.UseVisualStyleBackColor = true;
            // 
            // listBoxSessoes
            // 
            this.listBoxSessoes.FormattingEnabled = true;
            this.listBoxSessoes.ItemHeight = 16;
            this.listBoxSessoes.Location = new System.Drawing.Point(419, 74);
            this.listBoxSessoes.Name = "listBoxSessoes";
            this.listBoxSessoes.Size = new System.Drawing.Size(334, 196);
            this.listBoxSessoes.TabIndex = 6;
            // 
            // buttonGuardarSessoes
            // 
            this.buttonGuardarSessoes.Location = new System.Drawing.Point(518, 283);
            this.buttonGuardarSessoes.Name = "buttonGuardarSessoes";
            this.buttonGuardarSessoes.Size = new System.Drawing.Size(223, 35);
            this.buttonGuardarSessoes.TabIndex = 7;
            this.buttonGuardarSessoes.Text = "Guardar e Sair";
            this.buttonGuardarSessoes.UseVisualStyleBackColor = true;
            // 
            // buttonVoltarSessoes
            // 
            this.buttonVoltarSessoes.Location = new System.Drawing.Point(13, 294);
            this.buttonVoltarSessoes.Name = "buttonVoltarSessoes";
            this.buttonVoltarSessoes.Size = new System.Drawing.Size(98, 24);
            this.buttonVoltarSessoes.TabIndex = 8;
            this.buttonVoltarSessoes.Text = "<VOLTAR";
            this.buttonVoltarSessoes.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerSessaoTopo
            // 
            this.dateTimePickerSessaoTopo.Location = new System.Drawing.Point(505, 25);
            this.dateTimePickerSessaoTopo.Name = "dateTimePickerSessaoTopo";
            this.dateTimePickerSessaoTopo.Size = new System.Drawing.Size(206, 22);
            this.dateTimePickerSessaoTopo.TabIndex = 9;
            // 
            // dateTimePickerSessao
            // 
            this.dateTimePickerSessao.Location = new System.Drawing.Point(134, 177);
            this.dateTimePickerSessao.Name = "dateTimePickerSessao";
            this.dateTimePickerSessao.Size = new System.Drawing.Size(183, 22);
            this.dateTimePickerSessao.TabIndex = 10;
            // 
            // FormSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 456);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSessoes";
            this.Text = "FormSessoes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelDataHoraSessoes;
        private System.Windows.Forms.Label labelEscolherSalaSessoes;
        private System.Windows.Forms.Label labelEscolherFilmesSessoes;
        private System.Windows.Forms.DateTimePicker dateTimePickerSessao;
        private System.Windows.Forms.DateTimePicker dateTimePickerSessaoTopo;
        private System.Windows.Forms.Button buttonVoltarSessoes;
        private System.Windows.Forms.Button buttonGuardarSessoes;
        private System.Windows.Forms.ListBox listBoxSessoes;
        private System.Windows.Forms.Button buttonVerificarDispSessoes;
        private System.Windows.Forms.ComboBox comboBoxSalaSessoes;
        private System.Windows.Forms.ComboBox comboBoxFilmeSessoes;
    }
}