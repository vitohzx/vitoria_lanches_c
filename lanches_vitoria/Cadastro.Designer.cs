namespace lanches_vitoria
{
    partial class Cadastro
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
            label2 = new Label();
            label1 = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 109);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 9;
            label2.Text = "senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 51);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 8;
            label1.Text = "usuario";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(76, 251);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "cadastrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(76, 127);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(386, 23);
            txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(76, 69);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(386, 23);
            txtUsername.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 173);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 11;
            label3.Text = "confirma senha";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 191);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(386, 23);
            textBox1.TabIndex = 10;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(193, 254);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "admin";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(269, 254);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(61, 19);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "cliente";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}