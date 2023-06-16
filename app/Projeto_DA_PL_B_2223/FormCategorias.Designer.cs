namespace Projeto_DA_PL_B_2223
{
    partial class FormCategorias
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textBoxNomeCategoria = new System.Windows.Forms.TextBox();
            this.comboBoxEstadoCategoria = new System.Windows.Forms.ComboBox();
            this.listBoxCategorias = new System.Windows.Forms.ListBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonAlterarEstado = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(29, 25);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(80, 25);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome: ";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(29, 118);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(91, 25);
            this.labelEstado.TabIndex = 1;
            this.labelEstado.Text = "Estado: ";
            // 
            // textBoxNomeCategoria
            // 
            this.textBoxNomeCategoria.Location = new System.Drawing.Point(134, 25);
            this.textBoxNomeCategoria.Name = "textBoxNomeCategoria";
            this.textBoxNomeCategoria.Size = new System.Drawing.Size(100, 31);
            this.textBoxNomeCategoria.TabIndex = 2;
            // 
            // comboBoxEstadoCategoria
            // 
            this.comboBoxEstadoCategoria.FormattingEnabled = true;
            this.comboBoxEstadoCategoria.Items.AddRange(new object[] {
            "Ativa",
            "Inativa"});
            this.comboBoxEstadoCategoria.Location = new System.Drawing.Point(127, 109);
            this.comboBoxEstadoCategoria.Name = "comboBoxEstadoCategoria";
            this.comboBoxEstadoCategoria.Size = new System.Drawing.Size(121, 33);
            this.comboBoxEstadoCategoria.TabIndex = 3;
            // 
            // listBoxCategorias
            // 
            this.listBoxCategorias.FormattingEnabled = true;
            this.listBoxCategorias.ItemHeight = 25;
            this.listBoxCategorias.Location = new System.Drawing.Point(334, 71);
            this.listBoxCategorias.Name = "listBoxCategorias";
            this.listBoxCategorias.Size = new System.Drawing.Size(395, 329);
            this.listBoxCategorias.TabIndex = 4;
            this.listBoxCategorias.SelectedIndexChanged += new System.EventHandler(this.listBoxCategorias_SelectedIndexChanged);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(127, 168);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(114, 47);
            this.buttonGuardar.TabIndex = 5;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonAlterarEstado
            // 
            this.buttonAlterarEstado.Location = new System.Drawing.Point(334, 9);
            this.buttonAlterarEstado.Name = "buttonAlterarEstado";
            this.buttonAlterarEstado.Size = new System.Drawing.Size(179, 47);
            this.buttonAlterarEstado.TabIndex = 6;
            this.buttonAlterarEstado.Text = "Alterar Estado";
            this.buttonAlterarEstado.UseVisualStyleBackColor = true;
            this.buttonAlterarEstado.Click += new System.EventHandler(this.buttonAlterarEstado_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(615, 9);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(114, 47);
            this.buttonApagar.TabIndex = 7;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonAlterarEstado);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.listBoxCategorias);
            this.Controls.Add(this.comboBoxEstadoCategoria);
            this.Controls.Add(this.textBoxNomeCategoria);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelNome);
            this.Name = "FormCategorias";
            this.Text = "FormCategorias";
            this.Load += new System.EventHandler(this.FormCategorias_Load);
            this.Click += new System.EventHandler(this.FormCategorias_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox textBoxNomeCategoria;
        private System.Windows.Forms.ComboBox comboBoxEstadoCategoria;
        private System.Windows.Forms.ListBox listBoxCategorias;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonAlterarEstado;
        private System.Windows.Forms.Button buttonApagar;
    }
}