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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonVoltarFilme = new System.Windows.Forms.Button();
            this.listBoxFilmesFilmes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGuardarSairFilme = new System.Windows.Forms.Button();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelFilme = new System.Windows.Forms.Label();
            this.textBoxFilmeFilme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(188, 183);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(117, 24);
            this.comboBox2.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(117, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // buttonVoltarFilme
            // 
            this.buttonVoltarFilme.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonVoltarFilme.Location = new System.Drawing.Point(54, 379);
            this.buttonVoltarFilme.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVoltarFilme.Name = "buttonVoltarFilme";
            this.buttonVoltarFilme.Size = new System.Drawing.Size(94, 42);
            this.buttonVoltarFilme.TabIndex = 17;
            this.buttonVoltarFilme.Text = "<VOLTAR";
            this.buttonVoltarFilme.UseVisualStyleBackColor = false;
            // 
            // listBoxFilmesFilmes
            // 
            this.listBoxFilmesFilmes.FormattingEnabled = true;
            this.listBoxFilmesFilmes.ItemHeight = 16;
            this.listBoxFilmesFilmes.Location = new System.Drawing.Point(430, 18);
            this.listBoxFilmesFilmes.Name = "listBoxFilmesFilmes";
            this.listBoxFilmesFilmes.Size = new System.Drawing.Size(348, 356);
            this.listBoxFilmesFilmes.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "ESTADO";
            // 
            // buttonGuardarSairFilme
            // 
            this.buttonGuardarSairFilme.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonGuardarSairFilme.Location = new System.Drawing.Point(512, 395);
            this.buttonGuardarSairFilme.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardarSairFilme.Name = "buttonGuardarSairFilme";
            this.buttonGuardarSairFilme.Size = new System.Drawing.Size(222, 42);
            this.buttonGuardarSairFilme.TabIndex = 11;
            this.buttonGuardarSairFilme.Text = "GUARDAR E SAIR";
            this.buttonGuardarSairFilme.UseVisualStyleBackColor = false;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(51, 141);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(85, 16);
            this.labelCategoria.TabIndex = 14;
            this.labelCategoria.Text = "CATEGORIA";
            // 
            // labelFilme
            // 
            this.labelFilme.AutoSize = true;
            this.labelFilme.Location = new System.Drawing.Point(51, 94);
            this.labelFilme.Name = "labelFilme";
            this.labelFilme.Size = new System.Drawing.Size(45, 16);
            this.labelFilme.TabIndex = 13;
            this.labelFilme.Text = "FILME";
            // 
            // textBoxFilmeFilme
            // 
            this.textBoxFilmeFilme.Location = new System.Drawing.Point(166, 91);
            this.textBoxFilmeFilme.Name = "textBoxFilmeFilme";
            this.textBoxFilmeFilme.Size = new System.Drawing.Size(139, 22);
            this.textBoxFilmeFilme.TabIndex = 12;
            // 
            // FormFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonVoltarFilme);
            this.Controls.Add(this.listBoxFilmesFilmes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGuardarSairFilme);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelFilme);
            this.Controls.Add(this.textBoxFilmeFilme);
            this.Name = "FormFilmes";
            this.Text = "FormFilmes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonVoltarFilme;
        private System.Windows.Forms.ListBox listBoxFilmesFilmes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGuardarSairFilme;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelFilme;
        private System.Windows.Forms.TextBox textBoxFilmeFilme;
    }
}