namespace Projeto_DA_PL_B_2223
{
    partial class FormFuncionarios
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
            this.groupBoxFuncionario = new System.Windows.Forms.GroupBox();
            this.textBoxSalarioFuncionario = new System.Windows.Forms.TextBox();
            this.buttonGuardarFuncionario = new System.Windows.Forms.Button();
            this.comboBoxFuncaoFuncionario = new System.Windows.Forms.ComboBox();
            this.textBoxMoradaFuncionario = new System.Windows.Forms.TextBox();
            this.textBoxNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_entrar = new System.Windows.Forms.Button();
            this.buttonApagarFuncionario = new System.Windows.Forms.Button();
            this.groupBoxListaFuncionarios = new System.Windows.Forms.GroupBox();
            this.listBoxFuncionarios = new System.Windows.Forms.ListBox();
            this.groupBoxFuncionario.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxListaFuncionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFuncionario
            // 
            this.groupBoxFuncionario.Controls.Add(this.textBoxSalarioFuncionario);
            this.groupBoxFuncionario.Controls.Add(this.buttonGuardarFuncionario);
            this.groupBoxFuncionario.Controls.Add(this.comboBoxFuncaoFuncionario);
            this.groupBoxFuncionario.Controls.Add(this.textBoxMoradaFuncionario);
            this.groupBoxFuncionario.Controls.Add(this.textBoxNomeFuncionario);
            this.groupBoxFuncionario.Controls.Add(this.label8);
            this.groupBoxFuncionario.Controls.Add(this.label9);
            this.groupBoxFuncionario.Controls.Add(this.label10);
            this.groupBoxFuncionario.Controls.Add(this.label11);
            this.groupBoxFuncionario.Location = new System.Drawing.Point(4, 4);
            this.groupBoxFuncionario.Name = "groupBoxFuncionario";
            this.groupBoxFuncionario.Size = new System.Drawing.Size(303, 212);
            this.groupBoxFuncionario.TabIndex = 4;
            this.groupBoxFuncionario.TabStop = false;
            this.groupBoxFuncionario.Text = "Funcionarios";
            // 
            // textBoxSalarioFuncionario
            // 
            this.textBoxSalarioFuncionario.Location = new System.Drawing.Point(71, 125);
            this.textBoxSalarioFuncionario.Name = "textBoxSalarioFuncionario";
            this.textBoxSalarioFuncionario.Size = new System.Drawing.Size(225, 22);
            this.textBoxSalarioFuncionario.TabIndex = 3;
            // 
            // buttonGuardarFuncionario
            // 
            this.buttonGuardarFuncionario.Location = new System.Drawing.Point(94, 166);
            this.buttonGuardarFuncionario.Name = "buttonGuardarFuncionario";
            this.buttonGuardarFuncionario.Size = new System.Drawing.Size(101, 40);
            this.buttonGuardarFuncionario.TabIndex = 4;
            this.buttonGuardarFuncionario.Text = "Guardar";
            this.buttonGuardarFuncionario.UseVisualStyleBackColor = true;
            this.buttonGuardarFuncionario.Click += new System.EventHandler(this.buttonGuardarFuncionario_Click);
            // 
            // comboBoxFuncaoFuncionario
            // 
            this.comboBoxFuncaoFuncionario.FormattingEnabled = true;
            this.comboBoxFuncaoFuncionario.Items.AddRange(new object[] {
            "Admin",
            "Funcionario"});
            this.comboBoxFuncaoFuncionario.Location = new System.Drawing.Point(71, 90);
            this.comboBoxFuncaoFuncionario.Name = "comboBoxFuncaoFuncionario";
            this.comboBoxFuncaoFuncionario.Size = new System.Drawing.Size(225, 24);
            this.comboBoxFuncaoFuncionario.TabIndex = 2;
            this.comboBoxFuncaoFuncionario.Text = "Funcionario";
            // 
            // textBoxMoradaFuncionario
            // 
            this.textBoxMoradaFuncionario.Location = new System.Drawing.Point(71, 60);
            this.textBoxMoradaFuncionario.Name = "textBoxMoradaFuncionario";
            this.textBoxMoradaFuncionario.Size = new System.Drawing.Size(225, 22);
            this.textBoxMoradaFuncionario.TabIndex = 1;
            // 
            // textBoxNomeFuncionario
            // 
            this.textBoxNomeFuncionario.Location = new System.Drawing.Point(71, 31);
            this.textBoxNomeFuncionario.Name = "textBoxNomeFuncionario";
            this.textBoxNomeFuncionario.Size = new System.Drawing.Size(225, 22);
            this.textBoxNomeFuncionario.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Salário";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Função";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Morada:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nome:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1020, 411);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_entrar);
            this.tabPage1.Controls.Add(this.buttonApagarFuncionario);
            this.tabPage1.Controls.Add(this.groupBoxListaFuncionarios);
            this.tabPage1.Controls.Add(this.groupBoxFuncionario);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1012, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Funcionarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button_entrar
            // 
            this.button_entrar.Location = new System.Drawing.Point(1015, 420);
            this.button_entrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_entrar.Name = "button_entrar";
            this.button_entrar.Size = new System.Drawing.Size(213, 36);
            this.button_entrar.TabIndex = 20;
            this.button_entrar.Text = "ENTRAR";
            this.button_entrar.UseVisualStyleBackColor = true;
            // 
            // buttonApagarFuncionario
            // 
            this.buttonApagarFuncionario.Location = new System.Drawing.Point(241, 285);
            this.buttonApagarFuncionario.Name = "buttonApagarFuncionario";
            this.buttonApagarFuncionario.Size = new System.Drawing.Size(101, 40);
            this.buttonApagarFuncionario.TabIndex = 5;
            this.buttonApagarFuncionario.Text = "Apagar";
            this.buttonApagarFuncionario.UseVisualStyleBackColor = true;
            this.buttonApagarFuncionario.Click += new System.EventHandler(this.buttonApagarFuncionario_Click);
            // 
            // groupBoxListaFuncionarios
            // 
            this.groupBoxListaFuncionarios.Controls.Add(this.listBoxFuncionarios);
            this.groupBoxListaFuncionarios.Location = new System.Drawing.Point(355, 4);
            this.groupBoxListaFuncionarios.Name = "groupBoxListaFuncionarios";
            this.groupBoxListaFuncionarios.Size = new System.Drawing.Size(624, 331);
            this.groupBoxListaFuncionarios.TabIndex = 19;
            this.groupBoxListaFuncionarios.TabStop = false;
            this.groupBoxListaFuncionarios.Text = "Lista de Funcionarios";
            // 
            // listBoxFuncionarios
            // 
            this.listBoxFuncionarios.FormattingEnabled = true;
            this.listBoxFuncionarios.ItemHeight = 16;
            this.listBoxFuncionarios.Location = new System.Drawing.Point(4, 31);
            this.listBoxFuncionarios.Name = "listBoxFuncionarios";
            this.listBoxFuncionarios.Size = new System.Drawing.Size(595, 292);
            this.listBoxFuncionarios.TabIndex = 0;
            this.listBoxFuncionarios.SelectedIndexChanged += new System.EventHandler(this.listBoxFuncionarios_SelectedIndexChanged);
            this.listBoxFuncionarios.DoubleClick += new System.EventHandler(this.listBoxFuncionarios_DoubleClick);
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 479);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormFuncionarios";
            this.Text = "FormFuncionarios";
            this.Load += new System.EventHandler(this.FormFuncionarios_Load);
            this.groupBoxFuncionario.ResumeLayout(false);
            this.groupBoxFuncionario.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxListaFuncionarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFuncionario;
        private System.Windows.Forms.Button buttonGuardarFuncionario;
        private System.Windows.Forms.ComboBox comboBoxFuncaoFuncionario;
        private System.Windows.Forms.TextBox textBoxMoradaFuncionario;
        private System.Windows.Forms.TextBox textBoxNomeFuncionario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxListaFuncionarios;
        private System.Windows.Forms.ListBox listBoxFuncionarios;
        private System.Windows.Forms.Button buttonApagarFuncionario;
        private System.Windows.Forms.TextBox textBoxSalarioFuncionario;
        private System.Windows.Forms.Button button_entrar;
    }
}