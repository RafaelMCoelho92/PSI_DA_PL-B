﻿namespace Projeto_DA_PL_B_2223
{
    partial class FormFilmes
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
            this.comboBoxEstadoFilme = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoriaFilme = new System.Windows.Forms.ComboBox();
            this.listBoxFilmes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGuardarFilme = new System.Windows.Forms.Button();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelFilme = new System.Windows.Forms.Label();
            this.textBoxNomeFilme = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePickerDuracao = new System.Windows.Forms.DateTimePicker();
            this.labelDuracao = new System.Windows.Forms.Label();
            this.buttonApagarFilme = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxEstadoFilme
            // 
            this.comboBoxEstadoFilme.FormattingEnabled = true;
            this.comboBoxEstadoFilme.Items.AddRange(new object[] {
            "Desativado",
            "Ativado"});
            this.comboBoxEstadoFilme.Location = new System.Drawing.Point(112, 92);
            this.comboBoxEstadoFilme.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxEstadoFilme.Name = "comboBoxEstadoFilme";
            this.comboBoxEstadoFilme.Size = new System.Drawing.Size(89, 21);
            this.comboBoxEstadoFilme.TabIndex = 2;
            this.comboBoxEstadoFilme.Text = "Desativado";
            // 
            // comboBoxCategoriaFilme
            // 
            this.comboBoxCategoriaFilme.FormattingEnabled = true;
            this.comboBoxCategoriaFilme.Location = new System.Drawing.Point(112, 55);
            this.comboBoxCategoriaFilme.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxCategoriaFilme.Name = "comboBoxCategoriaFilme";
            this.comboBoxCategoriaFilme.Size = new System.Drawing.Size(89, 21);
            this.comboBoxCategoriaFilme.TabIndex = 1;
            // 
            // listBoxFilmes
            // 
            this.listBoxFilmes.FormattingEnabled = true;
            this.listBoxFilmes.Location = new System.Drawing.Point(220, 4);
            this.listBoxFilmes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxFilmes.Name = "listBoxFilmes";
            this.listBoxFilmes.Size = new System.Drawing.Size(449, 290);
            this.listBoxFilmes.TabIndex = 6;
            this.listBoxFilmes.SelectedIndexChanged += new System.EventHandler(this.listBoxFilmes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ESTADO";
            // 
            // buttonGuardarFilme
            // 
            this.buttonGuardarFilme.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonGuardarFilme.Location = new System.Drawing.Point(42, 205);
            this.buttonGuardarFilme.Name = "buttonGuardarFilme";
            this.buttonGuardarFilme.Size = new System.Drawing.Size(166, 34);
            this.buttonGuardarFilme.TabIndex = 4;
            this.buttonGuardarFilme.Text = "GUARDAR";
            this.buttonGuardarFilme.UseVisualStyleBackColor = false;
            this.buttonGuardarFilme.Click += new System.EventHandler(this.buttonGuardarFilme_Click);
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(9, 57);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(69, 13);
            this.labelCategoria.TabIndex = 14;
            this.labelCategoria.Text = "CATEGORIA";
            // 
            // labelFilme
            // 
            this.labelFilme.AutoSize = true;
            this.labelFilme.Location = new System.Drawing.Point(9, 19);
            this.labelFilme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilme.Name = "labelFilme";
            this.labelFilme.Size = new System.Drawing.Size(38, 13);
            this.labelFilme.TabIndex = 13;
            this.labelFilme.Text = "FILME";
            // 
            // textBoxNomeFilme
            // 
            this.textBoxNomeFilme.Location = new System.Drawing.Point(96, 17);
            this.textBoxNomeFilme.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxNomeFilme.Name = "textBoxNomeFilme";
            this.textBoxNomeFilme.Size = new System.Drawing.Size(105, 20);
            this.textBoxNomeFilme.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(6, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 327);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePickerDuracao);
            this.tabPage1.Controls.Add(this.labelDuracao);
            this.tabPage1.Controls.Add(this.buttonApagarFilme);
            this.tabPage1.Controls.Add(this.labelFilme);
            this.tabPage1.Controls.Add(this.listBoxFilmes);
            this.tabPage1.Controls.Add(this.buttonGuardarFilme);
            this.tabPage1.Controls.Add(this.textBoxNomeFilme);
            this.tabPage1.Controls.Add(this.comboBoxEstadoFilme);
            this.tabPage1.Controls.Add(this.labelCategoria);
            this.tabPage1.Controls.Add(this.comboBoxCategoriaFilme);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(673, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filmes";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dateTimePickerDuracao
            // 
            this.dateTimePickerDuracao.CustomFormat = "HH:mm";
            this.dateTimePickerDuracao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDuracao.Location = new System.Drawing.Point(112, 127);
            this.dateTimePickerDuracao.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDuracao.MaxDate = new System.DateTime(2023, 6, 4, 4, 0, 0, 0);
            this.dateTimePickerDuracao.MinDate = new System.DateTime(2023, 6, 4, 0, 0, 0, 0);
            this.dateTimePickerDuracao.Name = "dateTimePickerDuracao";
            this.dateTimePickerDuracao.ShowUpDown = true;
            this.dateTimePickerDuracao.Size = new System.Drawing.Size(89, 20);
            this.dateTimePickerDuracao.TabIndex = 3;
            this.dateTimePickerDuracao.Value = new System.DateTime(2023, 6, 4, 0, 0, 0, 0);
            // 
            // labelDuracao
            // 
            this.labelDuracao.AutoSize = true;
            this.labelDuracao.Location = new System.Drawing.Point(9, 130);
            this.labelDuracao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDuracao.Name = "labelDuracao";
            this.labelDuracao.Size = new System.Drawing.Size(60, 13);
            this.labelDuracao.TabIndex = 18;
            this.labelDuracao.Text = "DURAÇÃO";
            // 
            // buttonApagarFilme
            // 
            this.buttonApagarFilme.Location = new System.Drawing.Point(132, 253);
            this.buttonApagarFilme.Margin = new System.Windows.Forms.Padding(2);
            this.buttonApagarFilme.Name = "buttonApagarFilme";
            this.buttonApagarFilme.Size = new System.Drawing.Size(76, 32);
            this.buttonApagarFilme.TabIndex = 5;
            this.buttonApagarFilme.Text = "Apagar";
            this.buttonApagarFilme.UseVisualStyleBackColor = true;
            this.buttonApagarFilme.Click += new System.EventHandler(this.buttonApagarFilme_Click);
            // 
            // FormFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormFilmes";
            this.Text = "FormFilmes";
            this.Load += new System.EventHandler(this.FormFilmes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEstadoFilme;
        private System.Windows.Forms.ComboBox comboBoxCategoriaFilme;
        private System.Windows.Forms.ListBox listBoxFilmes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGuardarFilme;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelFilme;
        private System.Windows.Forms.TextBox textBoxNomeFilme;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonApagarFilme;
        private System.Windows.Forms.Label labelDuracao;
        private System.Windows.Forms.DateTimePicker dateTimePickerDuracao;
    }
}