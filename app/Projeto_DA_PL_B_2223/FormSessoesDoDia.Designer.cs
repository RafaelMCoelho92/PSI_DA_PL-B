namespace Projeto_DA_PL_B_2223
{
    partial class FormSessoesDoDia
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
            this.tabPageSessoesDoDia = new System.Windows.Forms.TabPage();
            this.dateTimePickerSessoesDoDia = new System.Windows.Forms.DateTimePicker();
            this.listBoxSessoesDoDia = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.buttonCriarBilheteSessDia = new System.Windows.Forms.Button();
            this.tabPageSessoesDoDia.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageSessoesDoDia
            // 
            this.tabPageSessoesDoDia.Controls.Add(this.dateTimePickerSessoesDoDia);
            this.tabPageSessoesDoDia.Controls.Add(this.listBoxSessoesDoDia);
            this.tabPageSessoesDoDia.Location = new System.Drawing.Point(4, 22);
            this.tabPageSessoesDoDia.Name = "tabPageSessoesDoDia";
            this.tabPageSessoesDoDia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSessoesDoDia.Size = new System.Drawing.Size(571, 254);
            this.tabPageSessoesDoDia.TabIndex = 0;
            this.tabPageSessoesDoDia.Text = "Sessões marcadas";
            this.tabPageSessoesDoDia.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerSessoesDoDia
            // 
            this.dateTimePickerSessoesDoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSessoesDoDia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerSessoesDoDia.Location = new System.Drawing.Point(1, 3);
            this.dateTimePickerSessoesDoDia.Name = "dateTimePickerSessoesDoDia";
            this.dateTimePickerSessoesDoDia.Size = new System.Drawing.Size(162, 20);
            this.dateTimePickerSessoesDoDia.TabIndex = 1;
            // 
            // listBoxSessoesDoDia
            // 
            this.listBoxSessoesDoDia.FormattingEnabled = true;
            this.listBoxSessoesDoDia.Location = new System.Drawing.Point(0, 29);
            this.listBoxSessoesDoDia.Name = "listBoxSessoesDoDia";
            this.listBoxSessoesDoDia.Size = new System.Drawing.Size(565, 225);
            this.listBoxSessoesDoDia.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSessoesDoDia);
            this.tabControl1.Location = new System.Drawing.Point(47, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(579, 280);
            this.tabControl1.TabIndex = 0;
            // 
            // buttonCriarBilheteSessDia
            // 
            this.buttonCriarBilheteSessDia.Location = new System.Drawing.Point(494, 328);
            this.buttonCriarBilheteSessDia.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCriarBilheteSessDia.Name = "buttonCriarBilheteSessDia";
            this.buttonCriarBilheteSessDia.Size = new System.Drawing.Size(132, 34);
            this.buttonCriarBilheteSessDia.TabIndex = 10;
            this.buttonCriarBilheteSessDia.Text = "Criar Bilhete";
            this.buttonCriarBilheteSessDia.UseVisualStyleBackColor = true;
            // 
            // FormSessoesDoDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCriarBilheteSessDia);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSessoesDoDia";
            this.Text = "FormSessoesDoDia";
            this.tabPageSessoesDoDia.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageSessoesDoDia;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListBox listBoxSessoesDoDia;
        private System.Windows.Forms.DateTimePicker dateTimePickerSessoesDoDia;
        private System.Windows.Forms.Button buttonCriarBilheteSessDia;
    }
}