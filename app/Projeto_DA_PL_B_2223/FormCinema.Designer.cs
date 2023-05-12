namespace Projeto_DA_PL_B_2223
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
            this.groupBoxMostrarCinema = new System.Windows.Forms.GroupBox();
            this.labelNomeCinema = new System.Windows.Forms.Label();
            this.labelMoradaCinema = new System.Windows.Forms.Label();
            this.labelEmailCinema = new System.Windows.Forms.Label();
            this.buttonEditarSalas = new System.Windows.Forms.Button();
            this.buttonEditarFuncionarios = new System.Windows.Forms.Button();
            this.buttonMenuPrincipal = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            this.groupBoxEditarCinema.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBoxMostrarCinema.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonMenuPrincipal);
            this.tabPage1.Controls.Add(this.buttonEditarFuncionarios);
            this.tabPage1.Controls.Add(this.groupBoxMostrarCinema);
            this.tabPage1.Controls.Add(this.buttonEditarSalas);
            this.tabPage1.Controls.Add(this.groupBoxEditarCinema);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1099, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.groupBoxEditarCinema.Location = new System.Drawing.Point(11, 119);
            this.groupBoxEditarCinema.Name = "groupBoxEditarCinema";
            this.groupBoxEditarCinema.Size = new System.Drawing.Size(503, 314);
            this.groupBoxEditarCinema.TabIndex = 2;
            this.groupBoxEditarCinema.TabStop = false;
            this.groupBoxEditarCinema.Text = "Editar Cinema";
            // 
            // buttonGuardarCinema
            // 
            this.buttonGuardarCinema.Location = new System.Drawing.Point(180, 234);
            this.buttonGuardarCinema.Name = "buttonGuardarCinema";
            this.buttonGuardarCinema.Size = new System.Drawing.Size(153, 62);
            this.buttonGuardarCinema.TabIndex = 6;
            this.buttonGuardarCinema.Text = "Guardar";
            this.buttonGuardarCinema.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Morada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // textBoxMoradaCinema
            // 
            this.textBoxMoradaCinema.Location = new System.Drawing.Point(111, 113);
            this.textBoxMoradaCinema.Name = "textBoxMoradaCinema";
            this.textBoxMoradaCinema.Size = new System.Drawing.Size(349, 31);
            this.textBoxMoradaCinema.TabIndex = 2;
            // 
            // textBoxEmailCinema
            // 
            this.textBoxEmailCinema.Location = new System.Drawing.Point(111, 171);
            this.textBoxEmailCinema.Name = "textBoxEmailCinema";
            this.textBoxEmailCinema.Size = new System.Drawing.Size(349, 31);
            this.textBoxEmailCinema.TabIndex = 1;
            // 
            // textBoxNomeCinema
            // 
            this.textBoxNomeCinema.Location = new System.Drawing.Point(111, 56);
            this.textBoxNomeCinema.Name = "textBoxNomeCinema";
            this.textBoxNomeCinema.Size = new System.Drawing.Size(349, 31);
            this.textBoxNomeCinema.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(21, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1115, 525);
            this.tabControl1.TabIndex = 3;
            // 
            // groupBoxMostrarCinema
            // 
            this.groupBoxMostrarCinema.Controls.Add(this.labelEmailCinema);
            this.groupBoxMostrarCinema.Controls.Add(this.labelMoradaCinema);
            this.groupBoxMostrarCinema.Controls.Add(this.labelNomeCinema);
            this.groupBoxMostrarCinema.Location = new System.Drawing.Point(566, 119);
            this.groupBoxMostrarCinema.Name = "groupBoxMostrarCinema";
            this.groupBoxMostrarCinema.Size = new System.Drawing.Size(527, 314);
            this.groupBoxMostrarCinema.TabIndex = 4;
            this.groupBoxMostrarCinema.TabStop = false;
            this.groupBoxMostrarCinema.Text = "Dados Cinema";
            // 
            // labelNomeCinema
            // 
            this.labelNomeCinema.AutoSize = true;
            this.labelNomeCinema.Location = new System.Drawing.Point(66, 49);
            this.labelNomeCinema.Name = "labelNomeCinema";
            this.labelNomeCinema.Size = new System.Drawing.Size(187, 25);
            this.labelNomeCinema.TabIndex = 0;
            this.labelNomeCinema.Text = "labelNomeCinema";
            // 
            // labelMoradaCinema
            // 
            this.labelMoradaCinema.AutoSize = true;
            this.labelMoradaCinema.Location = new System.Drawing.Point(66, 117);
            this.labelMoradaCinema.Name = "labelMoradaCinema";
            this.labelMoradaCinema.Size = new System.Drawing.Size(204, 25);
            this.labelMoradaCinema.TabIndex = 1;
            this.labelMoradaCinema.Text = "labelMoradaCinema";
            // 
            // labelEmailCinema
            // 
            this.labelEmailCinema.AutoSize = true;
            this.labelEmailCinema.Location = new System.Drawing.Point(66, 188);
            this.labelEmailCinema.Name = "labelEmailCinema";
            this.labelEmailCinema.Size = new System.Drawing.Size(184, 25);
            this.labelEmailCinema.TabIndex = 2;
            this.labelEmailCinema.Text = "labelEmailCinema";
            // 
            // buttonEditarSalas
            // 
            this.buttonEditarSalas.Location = new System.Drawing.Point(186, 0);
            this.buttonEditarSalas.Name = "buttonEditarSalas";
            this.buttonEditarSalas.Size = new System.Drawing.Size(181, 112);
            this.buttonEditarSalas.TabIndex = 5;
            this.buttonEditarSalas.Text = "Editar Salas";
            this.buttonEditarSalas.UseVisualStyleBackColor = true;
            // 
            // buttonEditarFuncionarios
            // 
            this.buttonEditarFuncionarios.Location = new System.Drawing.Point(373, 0);
            this.buttonEditarFuncionarios.Name = "buttonEditarFuncionarios";
            this.buttonEditarFuncionarios.Size = new System.Drawing.Size(181, 112);
            this.buttonEditarFuncionarios.TabIndex = 6;
            this.buttonEditarFuncionarios.Text = "Editar Funcionarios";
            this.buttonEditarFuncionarios.UseVisualStyleBackColor = true;
            // 
            // buttonMenuPrincipal
            // 
            this.buttonMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.buttonMenuPrincipal.Name = "buttonMenuPrincipal";
            this.buttonMenuPrincipal.Size = new System.Drawing.Size(181, 112);
            this.buttonMenuPrincipal.TabIndex = 7;
            this.buttonMenuPrincipal.Text = "Menu Principal";
            this.buttonMenuPrincipal.UseVisualStyleBackColor = true;
            // 
            // FormCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 585);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCinema";
            this.Text = "FormCinema";
            this.tabPage1.ResumeLayout(false);
            this.groupBoxEditarCinema.ResumeLayout(false);
            this.groupBoxEditarCinema.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBoxMostrarCinema.ResumeLayout(false);
            this.groupBoxMostrarCinema.PerformLayout();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxMostrarCinema;
        private System.Windows.Forms.Label labelEmailCinema;
        private System.Windows.Forms.Label labelMoradaCinema;
        private System.Windows.Forms.Label labelNomeCinema;
        private System.Windows.Forms.Button buttonMenuPrincipal;
        private System.Windows.Forms.Button buttonEditarFuncionarios;
        private System.Windows.Forms.Button buttonEditarSalas;
    }
}