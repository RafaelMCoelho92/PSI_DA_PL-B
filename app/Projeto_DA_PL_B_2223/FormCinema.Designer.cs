﻿namespace Projeto_DA_PL_B_2223
{
    partial class FormCinema
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxMostrarCinema = new System.Windows.Forms.GroupBox();
            this.labelEmailCinema = new System.Windows.Forms.Label();
            this.labelMoradaCinema = new System.Windows.Forms.Label();
            this.labelNomeCinema = new System.Windows.Forms.Label();
            this.groupBoxEditarCinema = new System.Windows.Forms.GroupBox();
            this.buttonGuardarCinema = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMoradaCinema = new System.Windows.Forms.TextBox();
            this.textBoxEmailCinema = new System.Windows.Forms.TextBox();
            this.textBoxNomeCinema = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.labelIdCinema = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.groupBoxMostrarCinema.SuspendLayout();
            this.groupBoxEditarCinema.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxMostrarCinema);
            this.tabPage1.Controls.Add(this.groupBoxEditarCinema);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1100, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cinema";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxMostrarCinema
            // 
            this.groupBoxMostrarCinema.Controls.Add(this.labelIdCinema);
            this.groupBoxMostrarCinema.Controls.Add(this.labelEmailCinema);
            this.groupBoxMostrarCinema.Controls.Add(this.labelMoradaCinema);
            this.groupBoxMostrarCinema.Controls.Add(this.labelNomeCinema);
            this.groupBoxMostrarCinema.Location = new System.Drawing.Point(560, 17);
            this.groupBoxMostrarCinema.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMostrarCinema.Name = "groupBoxMostrarCinema";
            this.groupBoxMostrarCinema.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMostrarCinema.Size = new System.Drawing.Size(528, 313);
            this.groupBoxMostrarCinema.TabIndex = 4;
            this.groupBoxMostrarCinema.TabStop = false;
            this.groupBoxMostrarCinema.Text = "Dados Cinema";
            // 
            // labelEmailCinema
            // 
            this.labelEmailCinema.AutoSize = true;
            this.labelEmailCinema.Location = new System.Drawing.Point(66, 188);
            this.labelEmailCinema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmailCinema.Name = "labelEmailCinema";
            this.labelEmailCinema.Size = new System.Drawing.Size(0, 25);
            this.labelEmailCinema.TabIndex = 2;
            // 
            // labelMoradaCinema
            // 
            this.labelMoradaCinema.AutoSize = true;
            this.labelMoradaCinema.Location = new System.Drawing.Point(66, 117);
            this.labelMoradaCinema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMoradaCinema.Name = "labelMoradaCinema";
            this.labelMoradaCinema.Size = new System.Drawing.Size(0, 25);
            this.labelMoradaCinema.TabIndex = 1;
            // 
            // labelNomeCinema
            // 
            this.labelNomeCinema.AutoSize = true;
            this.labelNomeCinema.Location = new System.Drawing.Point(66, 48);
            this.labelNomeCinema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeCinema.Name = "labelNomeCinema";
            this.labelNomeCinema.Size = new System.Drawing.Size(0, 25);
            this.labelNomeCinema.TabIndex = 0;
            // 
            // groupBoxEditarCinema
            // 
            this.groupBoxEditarCinema.Controls.Add(this.buttonGuardarCinema);
            this.groupBoxEditarCinema.Controls.Add(this.label3);
            this.groupBoxEditarCinema.Controls.Add(this.label2);
            this.groupBoxEditarCinema.Controls.Add(this.label1);
            this.groupBoxEditarCinema.Controls.Add(this.textBoxMoradaCinema);
            this.groupBoxEditarCinema.Controls.Add(this.textBoxEmailCinema);
            this.groupBoxEditarCinema.Controls.Add(this.textBoxNomeCinema);
            this.groupBoxEditarCinema.Location = new System.Drawing.Point(6, 17);
            this.groupBoxEditarCinema.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEditarCinema.Name = "groupBoxEditarCinema";
            this.groupBoxEditarCinema.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEditarCinema.Size = new System.Drawing.Size(504, 313);
            this.groupBoxEditarCinema.TabIndex = 2;
            this.groupBoxEditarCinema.TabStop = false;
            this.groupBoxEditarCinema.Text = "Editar Cinema";
            // 
            // buttonGuardarCinema
            // 
            this.buttonGuardarCinema.Location = new System.Drawing.Point(180, 235);
            this.buttonGuardarCinema.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardarCinema.Name = "buttonGuardarCinema";
            this.buttonGuardarCinema.Size = new System.Drawing.Size(152, 62);
            this.buttonGuardarCinema.TabIndex = 3;
            this.buttonGuardarCinema.Text = "Guardar";
            this.buttonGuardarCinema.UseVisualStyleBackColor = true;
            this.buttonGuardarCinema.Click += new System.EventHandler(this.buttonGuardarCinema_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Morada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // textBoxMoradaCinema
            // 
            this.textBoxMoradaCinema.Location = new System.Drawing.Point(112, 113);
            this.textBoxMoradaCinema.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoradaCinema.Name = "textBoxMoradaCinema";
            this.textBoxMoradaCinema.Size = new System.Drawing.Size(348, 31);
            this.textBoxMoradaCinema.TabIndex = 1;
            // 
            // textBoxEmailCinema
            // 
            this.textBoxEmailCinema.Location = new System.Drawing.Point(112, 171);
            this.textBoxEmailCinema.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmailCinema.Name = "textBoxEmailCinema";
            this.textBoxEmailCinema.Size = new System.Drawing.Size(348, 31);
            this.textBoxEmailCinema.TabIndex = 2;
            // 
            // textBoxNomeCinema
            // 
            this.textBoxNomeCinema.Location = new System.Drawing.Point(112, 56);
            this.textBoxNomeCinema.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNomeCinema.Name = "textBoxNomeCinema";
            this.textBoxNomeCinema.Size = new System.Drawing.Size(348, 31);
            this.textBoxNomeCinema.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(9, 37);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1116, 404);
            this.tabControl1.TabIndex = 3;
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Location = new System.Drawing.Point(954, 13);
            this.buttonEntrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(152, 62);
            this.buttonEntrar.TabIndex = 6;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // labelIdCinema
            // 
            this.labelIdCinema.AutoSize = true;
            this.labelIdCinema.Location = new System.Drawing.Point(264, 144);
            this.labelIdCinema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIdCinema.Name = "labelIdCinema";
            this.labelIdCinema.Size = new System.Drawing.Size(0, 25);
            this.labelIdCinema.TabIndex = 3;
            // 
            // FormCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 461);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCinema";
            this.Text = "FormCinema";
            this.Load += new System.EventHandler(this.FormCinema_Load);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxMostrarCinema.ResumeLayout(false);
            this.groupBoxMostrarCinema.PerformLayout();
            this.groupBoxEditarCinema.ResumeLayout(false);
            this.groupBoxEditarCinema.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxEditarCinema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMoradaCinema;
        private System.Windows.Forms.TextBox textBoxEmailCinema;
        private System.Windows.Forms.TextBox textBoxNomeCinema;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button buttonGuardarCinema;
        private System.Windows.Forms.GroupBox groupBoxMostrarCinema;
        private System.Windows.Forms.Label labelEmailCinema;
        private System.Windows.Forms.Label labelMoradaCinema;
        private System.Windows.Forms.Label labelNomeCinema;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Label labelIdCinema;
    }
}