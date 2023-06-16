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
            this.comboBox_estadoBilhete = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_pesquisaIdBilhete
            // 
            this.textBox_pesquisaIdBilhete.Location = new System.Drawing.Point(45, 24);
            this.textBox_pesquisaIdBilhete.Name = "textBox_pesquisaIdBilhete";
            this.textBox_pesquisaIdBilhete.Size = new System.Drawing.Size(186, 20);
            this.textBox_pesquisaIdBilhete.TabIndex = 0;
            // 
            // listBox_pesquisaIdBilhete
            // 
            this.listBox_pesquisaIdBilhete.FormattingEnabled = true;
            this.listBox_pesquisaIdBilhete.Location = new System.Drawing.Point(45, 78);
            this.listBox_pesquisaIdBilhete.Name = "listBox_pesquisaIdBilhete";
            this.listBox_pesquisaIdBilhete.Size = new System.Drawing.Size(690, 303);
            this.listBox_pesquisaIdBilhete.TabIndex = 1;
            // 
            // button_pesquisaIdBilhete
            // 
            this.button_pesquisaIdBilhete.Location = new System.Drawing.Point(237, 23);
            this.button_pesquisaIdBilhete.Name = "button_pesquisaIdBilhete";
            this.button_pesquisaIdBilhete.Size = new System.Drawing.Size(119, 23);
            this.button_pesquisaIdBilhete.TabIndex = 2;
            this.button_pesquisaIdBilhete.Text = "PESQUISAR";
            this.button_pesquisaIdBilhete.UseVisualStyleBackColor = true;
            this.button_pesquisaIdBilhete.Click += new System.EventHandler(this.button_pesquisaIdBilhete_Click);
            // 
            // button_mudarEstadoBilhete
            // 
            this.button_mudarEstadoBilhete.Location = new System.Drawing.Point(616, 22);
            this.button_mudarEstadoBilhete.Name = "button_mudarEstadoBilhete";
            this.button_mudarEstadoBilhete.Size = new System.Drawing.Size(119, 23);
            this.button_mudarEstadoBilhete.TabIndex = 3;
            this.button_mudarEstadoBilhete.Text = "MUDAR ESTADO";
            this.button_mudarEstadoBilhete.UseVisualStyleBackColor = true;
            // 
            // comboBox_estadoBilhete
            // 
            this.comboBox_estadoBilhete.FormattingEnabled = true;
            this.comboBox_estadoBilhete.Location = new System.Drawing.Point(424, 23);
            this.comboBox_estadoBilhete.Name = "comboBox_estadoBilhete";
            this.comboBox_estadoBilhete.Size = new System.Drawing.Size(186, 21);
            this.comboBox_estadoBilhete.TabIndex = 4;
            // 
            // FormEstadoBilhete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_estadoBilhete);
            this.Controls.Add(this.button_mudarEstadoBilhete);
            this.Controls.Add(this.button_pesquisaIdBilhete);
            this.Controls.Add(this.listBox_pesquisaIdBilhete);
            this.Controls.Add(this.textBox_pesquisaIdBilhete);
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
        private System.Windows.Forms.ComboBox comboBox_estadoBilhete;
    }
}