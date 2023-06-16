namespace Projeto_DA_PL_B_2223
{
    partial class FormEstadoBilhete
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
            this.textBox_pesquisaIdBilhete = new System.Windows.Forms.TextBox();
            this.listBox_pesquisaIdBilhete = new System.Windows.Forms.ListBox();
            this.button_pesquisaIdBilhete = new System.Windows.Forms.Button();
            this.button_mudarEstadoBilhete = new System.Windows.Forms.Button();
            this.textBox_estado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_pesquisaIdBilhete
            // 
            this.textBox_pesquisaIdBilhete.Location = new System.Drawing.Point(60, 30);
            this.textBox_pesquisaIdBilhete.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_pesquisaIdBilhete.Name = "textBox_pesquisaIdBilhete";
            this.textBox_pesquisaIdBilhete.Size = new System.Drawing.Size(247, 22);
            this.textBox_pesquisaIdBilhete.TabIndex = 0;
            // 
            // listBox_pesquisaIdBilhete
            // 
            this.listBox_pesquisaIdBilhete.FormattingEnabled = true;
            this.listBox_pesquisaIdBilhete.ItemHeight = 16;
            this.listBox_pesquisaIdBilhete.Location = new System.Drawing.Point(60, 96);
            this.listBox_pesquisaIdBilhete.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_pesquisaIdBilhete.Name = "listBox_pesquisaIdBilhete";
            this.listBox_pesquisaIdBilhete.Size = new System.Drawing.Size(919, 372);
            this.listBox_pesquisaIdBilhete.TabIndex = 1;
            this.listBox_pesquisaIdBilhete.SelectedIndexChanged += new System.EventHandler(this.listBox_pesquisaIdBilhete_SelectedIndexChanged);
            // 
            // button_pesquisaIdBilhete
            // 
            this.button_pesquisaIdBilhete.Location = new System.Drawing.Point(316, 28);
            this.button_pesquisaIdBilhete.Margin = new System.Windows.Forms.Padding(4);
            this.button_pesquisaIdBilhete.Name = "button_pesquisaIdBilhete";
            this.button_pesquisaIdBilhete.Size = new System.Drawing.Size(159, 28);
            this.button_pesquisaIdBilhete.TabIndex = 2;
            this.button_pesquisaIdBilhete.Text = "PESQUISAR";
            this.button_pesquisaIdBilhete.UseVisualStyleBackColor = true;
            this.button_pesquisaIdBilhete.Click += new System.EventHandler(this.button_pesquisaIdBilhete_Click);
            // 
            // button_mudarEstadoBilhete
            // 
            this.button_mudarEstadoBilhete.Location = new System.Drawing.Point(821, 27);
            this.button_mudarEstadoBilhete.Margin = new System.Windows.Forms.Padding(4);
            this.button_mudarEstadoBilhete.Name = "button_mudarEstadoBilhete";
            this.button_mudarEstadoBilhete.Size = new System.Drawing.Size(159, 28);
            this.button_mudarEstadoBilhete.TabIndex = 3;
            this.button_mudarEstadoBilhete.Text = "MUDAR ESTADO";
            this.button_mudarEstadoBilhete.UseVisualStyleBackColor = true;
            this.button_mudarEstadoBilhete.Click += new System.EventHandler(this.button_mudarEstadoBilhete_Click);
            // 
            // textBox_estado
            // 
            this.textBox_estado.Location = new System.Drawing.Point(566, 30);
            this.textBox_estado.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_estado.Name = "textBox_estado";
            this.textBox_estado.Size = new System.Drawing.Size(247, 22);
            this.textBox_estado.TabIndex = 4;
            // 
            // FormEstadoBilhete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox_estado);
            this.Controls.Add(this.button_mudarEstadoBilhete);
            this.Controls.Add(this.button_pesquisaIdBilhete);
            this.Controls.Add(this.listBox_pesquisaIdBilhete);
            this.Controls.Add(this.textBox_pesquisaIdBilhete);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEstadoBilhete";
            this.Text = "FormEstadoBilhete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_pesquisaIdBilhete;
        private System.Windows.Forms.ListBox listBox_pesquisaIdBilhete;
        private System.Windows.Forms.Button button_pesquisaIdBilhete;
        private System.Windows.Forms.Button button_mudarEstadoBilhete;
        private System.Windows.Forms.TextBox textBox_estado;
    }
}