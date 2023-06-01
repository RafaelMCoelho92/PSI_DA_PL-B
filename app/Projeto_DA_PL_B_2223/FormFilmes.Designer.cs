namespace Projeto_DA_PL_B_2223
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
            this.comboBoxEstadoFilme.Location = new System.Drawing.Point(224, 177);
            this.comboBoxEstadoFilme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comboBoxEstadoFilme.Name = "comboBoxEstadoFilme";
            this.comboBoxEstadoFilme.Size = new System.Drawing.Size(174, 33);
            this.comboBoxEstadoFilme.TabIndex = 2;
            this.comboBoxEstadoFilme.Text = "Desativado";
            // 
            // comboBoxCategoriaFilme
            // 
            this.comboBoxCategoriaFilme.FormattingEnabled = true;
            this.comboBoxCategoriaFilme.Items.AddRange(new object[] {
            "Comédia",
            "Sci-Fi",
            "Terror",
            "Romance",
            "Acção",
            "Thriller",
            "Drama",
            "Mistério",
            "Crime",
            "Aventura",
            "Fantasia",
            "Animação"});
            this.comboBoxCategoriaFilme.Location = new System.Drawing.Point(224, 106);
            this.comboBoxCategoriaFilme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comboBoxCategoriaFilme.Name = "comboBoxCategoriaFilme";
            this.comboBoxCategoriaFilme.Size = new System.Drawing.Size(174, 33);
            this.comboBoxCategoriaFilme.TabIndex = 1;
            // 
            // listBoxFilmes
            // 
            this.listBoxFilmes.FormattingEnabled = true;
            this.listBoxFilmes.ItemHeight = 25;
            this.listBoxFilmes.Location = new System.Drawing.Point(440, 8);
            this.listBoxFilmes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.listBoxFilmes.Name = "listBoxFilmes";
            this.listBoxFilmes.Size = new System.Drawing.Size(894, 554);
            this.listBoxFilmes.TabIndex = 16;
            this.listBoxFilmes.SelectedIndexChanged += new System.EventHandler(this.listBoxFilmes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "ESTADO";
            // 
            // buttonGuardarFilme
            // 
            this.buttonGuardarFilme.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonGuardarFilme.Location = new System.Drawing.Point(64, 277);
            this.buttonGuardarFilme.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonGuardarFilme.Name = "buttonGuardarFilme";
            this.buttonGuardarFilme.Size = new System.Drawing.Size(332, 66);
            this.buttonGuardarFilme.TabIndex = 3;
            this.buttonGuardarFilme.Text = "GUARDAR";
            this.buttonGuardarFilme.UseVisualStyleBackColor = false;
            this.buttonGuardarFilme.Click += new System.EventHandler(this.buttonGuardarFilme_Click);
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(18, 109);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(134, 25);
            this.labelCategoria.TabIndex = 14;
            this.labelCategoria.Text = "CATEGORIA";
            // 
            // labelFilme
            // 
            this.labelFilme.AutoSize = true;
            this.labelFilme.Location = new System.Drawing.Point(18, 36);
            this.labelFilme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilme.Name = "labelFilme";
            this.labelFilme.Size = new System.Drawing.Size(74, 25);
            this.labelFilme.TabIndex = 13;
            this.labelFilme.Text = "FILME";
            // 
            // textBoxNomeFilme
            // 
            this.textBoxNomeFilme.Location = new System.Drawing.Point(192, 33);
            this.textBoxNomeFilme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxNomeFilme.Name = "textBoxNomeFilme";
            this.textBoxNomeFilme.Size = new System.Drawing.Size(206, 31);
            this.textBoxNomeFilme.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1362, 628);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonApagarFilme);
            this.tabPage1.Controls.Add(this.labelFilme);
            this.tabPage1.Controls.Add(this.listBoxFilmes);
            this.tabPage1.Controls.Add(this.buttonGuardarFilme);
            this.tabPage1.Controls.Add(this.textBoxNomeFilme);
            this.tabPage1.Controls.Add(this.comboBoxEstadoFilme);
            this.tabPage1.Controls.Add(this.labelCategoria);
            this.tabPage1.Controls.Add(this.comboBoxCategoriaFilme);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1346, 581);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filmes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonApagarFilme
            // 
            this.buttonApagarFilme.Location = new System.Drawing.Point(264, 487);
            this.buttonApagarFilme.Name = "buttonApagarFilme";
            this.buttonApagarFilme.Size = new System.Drawing.Size(153, 62);
            this.buttonApagarFilme.TabIndex = 17;
            this.buttonApagarFilme.Text = "Apagar";
            this.buttonApagarFilme.UseVisualStyleBackColor = true;
            this.buttonApagarFilme.Click += new System.EventHandler(this.buttonApagarFilme_Click);
            // 
            // FormFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 703);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormFilmes";
            this.Text = "FormFilmes";
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
    }
}