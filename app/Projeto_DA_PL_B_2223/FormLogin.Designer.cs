namespace Projeto_DA_PL_B_2223
{
    partial class FormLogin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLogIn = new System.Windows.Forms.TabPage();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLogIn);
            this.tabControl1.Location = new System.Drawing.Point(24, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(375, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageLogIn
            // 
            this.tabPageLogIn.Controls.Add(this.textBox1);
            this.tabPageLogIn.Controls.Add(this.labelPassword);
            this.tabPageLogIn.Controls.Add(this.buttonEntrar);
            this.tabPageLogIn.Controls.Add(this.textBoxUsername);
            this.tabPageLogIn.Controls.Add(this.labelUsername);
            this.tabPageLogIn.Location = new System.Drawing.Point(8, 39);
            this.tabPageLogIn.Name = "tabPageLogIn";
            this.tabPageLogIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogIn.Size = new System.Drawing.Size(359, 375);
            this.tabPageLogIn.TabIndex = 0;
            this.tabPageLogIn.Text = "Sign In";
            this.tabPageLogIn.UseVisualStyleBackColor = true;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(90, 63);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(116, 25);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(95, 104);
            this.textBoxUsername.MaxLength = 10;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(180, 31);
            this.textBoxUsername.TabIndex = 0;
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Location = new System.Drawing.Point(131, 252);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(93, 42);
            this.buttonEntrar.TabIndex = 2;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 194);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(180, 31);
            this.textBox1.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(90, 154);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(112, 25);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 486);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.tabControl1.ResumeLayout(false);
            this.tabPageLogIn.ResumeLayout(false);
            this.tabPageLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLogIn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
    }
}