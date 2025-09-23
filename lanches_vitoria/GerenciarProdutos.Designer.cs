namespace lanches_vitoria
{
    partial class GerenciarProdutos
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
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            comboBox1 = new ComboBox();
            label4 = new Label();
            desc = new TextBox();
            label3 = new Label();
            preco = new TextBox();
            label2 = new Label();
            nome = new TextBox();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            nomeCategoria = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(267, 287);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(189, 23);
            comboBox1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 221);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 14;
            label4.Text = "DESCRIÇÃO PRODUTO";
            // 
            // desc
            // 
            desc.Location = new Point(108, 239);
            desc.Multiline = true;
            desc.Name = "desc";
            desc.Size = new Size(348, 23);
            desc.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 152);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 12;
            label3.Text = "PREÇO PRODUTO";
            // 
            // preco
            // 
            preco.Location = new Point(108, 170);
            preco.Name = "preco";
            preco.Size = new Size(348, 23);
            preco.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 91);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 10;
            label2.Text = "NOME PRODUTO";
            // 
            // nome
            // 
            nome.Location = new Point(108, 109);
            nome.Name = "nome";
            nome.Size = new Size(348, 23);
            nome.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 39);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 8;
            label1.Text = "CADASTRAR PRODUTO";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(100, 181, 246);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(108, 286);
            button1.Name = "button1";
            button1.Size = new Size(136, 23);
            button1.TabIndex = 15;
            button1.Text = "CADASTRAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(530, 210);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 543);
            panel1.TabIndex = 16;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(100, 181, 246);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(108, 466);
            button2.Name = "button2";
            button2.Size = new Size(136, 23);
            button2.TabIndex = 25;
            button2.Text = "CADASTRAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(108, 466);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(108, 405);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 20;
            label7.Text = "NOME CATEGORIA";
            // 
            // nomeCategoria
            // 
            nomeCategoria.Location = new Point(108, 423);
            nomeCategoria.Name = "nomeCategoria";
            nomeCategoria.Size = new Size(348, 23);
            nomeCategoria.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(187, 353);
            label8.Name = "label8";
            label8.Size = new Size(195, 20);
            label8.TabIndex = 18;
            label8.Text = "CADASTRAR CATEGORIAS";
            // 
            // GerenciarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(567, 371);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(nomeCategoria);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(desc);
            Controls.Add(label3);
            Controls.Add(preco);
            Controls.Add(label2);
            Controls.Add(nome);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GerenciarProdutos";
            Text = "GerenciarProdutos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox desc;
        private Label label3;
        private TextBox preco;
        private Label label2;
        private TextBox nome;
        private Label label1;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private Label label6;
        private Label label7;
        private TextBox nomeCategoria;
        private Label label8;
    }
}