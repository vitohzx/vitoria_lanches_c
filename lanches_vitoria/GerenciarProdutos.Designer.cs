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
            button3 = new Button();
            label5 = new Label();
            descEdit = new TextBox();
            label9 = new Label();
            precoEdit = new TextBox();
            label10 = new Label();
            nomeEdit = new TextBox();
            label11 = new Label();
            comboBox2 = new ComboBox();
            editar = new Button();
            selecionarCategoriaEdit = new Button();
            label13 = new Label();
            comboBoxCategoriasEdit = new ComboBox();
            nomeCategoriaEdit = new TextBox();
            editCategoria = new Button();
            label12 = new Label();
            deletar = new Button();
            label14 = new Label();
            comboBoxProdDelete = new ComboBox();
            deleteCat = new Button();
            label15 = new Label();
            comboBoxCatDelete = new ComboBox();
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
            label4.Size = new Size(126, 15);
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
            label3.Size = new Size(100, 15);
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
            label2.Size = new Size(98, 15);
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
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(183, 41);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 8;
            label1.Text = "CADASTRAR PRODUTOS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            panel1.Location = new Point(537, 239);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 1100);
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
            label7.Size = new Size(107, 15);
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
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(183, 353);
            label8.Name = "label8";
            label8.Size = new Size(200, 20);
            label8.TabIndex = 18;
            label8.Text = "CADASTRAR CATEGORIAS";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(100, 181, 246);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(320, 571);
            button3.Name = "button3";
            button3.Size = new Size(136, 23);
            button3.TabIndex = 34;
            button3.Text = "SELECIONAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 748);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 33;
            label5.Text = "DESCRIÇÃO PRODUTO";
            // 
            // descEdit
            // 
            descEdit.Location = new Point(108, 766);
            descEdit.Multiline = true;
            descEdit.Name = "descEdit";
            descEdit.Size = new Size(348, 23);
            descEdit.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(108, 679);
            label9.Name = "label9";
            label9.Size = new Size(100, 15);
            label9.TabIndex = 31;
            label9.Text = "PREÇO PRODUTO";
            // 
            // precoEdit
            // 
            precoEdit.Location = new Point(108, 697);
            precoEdit.Name = "precoEdit";
            precoEdit.Size = new Size(348, 23);
            precoEdit.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(108, 618);
            label10.Name = "label10";
            label10.Size = new Size(98, 15);
            label10.TabIndex = 29;
            label10.Text = "NOME PRODUTO";
            // 
            // nomeEdit
            // 
            nomeEdit.Location = new Point(108, 636);
            nomeEdit.Name = "nomeEdit";
            nomeEdit.Size = new Size(348, 23);
            nomeEdit.TabIndex = 28;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(183, 533);
            label11.Name = "label11";
            label11.Size = new Size(200, 20);
            label11.TabIndex = 27;
            label11.Text = "EDITAR PRODUTOS";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(108, 571);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(189, 23);
            comboBox2.TabIndex = 26;
            // 
            // editar
            // 
            editar.BackColor = Color.FromArgb(100, 181, 246);
            editar.FlatAppearance.BorderSize = 0;
            editar.FlatStyle = FlatStyle.Flat;
            editar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editar.ForeColor = Color.White;
            editar.Location = new Point(108, 815);
            editar.Name = "editar";
            editar.Size = new Size(136, 23);
            editar.TabIndex = 35;
            editar.Text = "EDITAR";
            editar.UseVisualStyleBackColor = false;
            editar.Click += editar_Click;
            // 
            // selecionarCategoriaEdit
            // 
            selecionarCategoriaEdit.BackColor = Color.FromArgb(100, 181, 246);
            selecionarCategoriaEdit.FlatAppearance.BorderSize = 0;
            selecionarCategoriaEdit.FlatStyle = FlatStyle.Flat;
            selecionarCategoriaEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selecionarCategoriaEdit.ForeColor = Color.White;
            selecionarCategoriaEdit.Location = new Point(320, 921);
            selecionarCategoriaEdit.Name = "selecionarCategoriaEdit";
            selecionarCategoriaEdit.Size = new Size(136, 23);
            selecionarCategoriaEdit.TabIndex = 40;
            selecionarCategoriaEdit.Text = "SELECIONAR";
            selecionarCategoriaEdit.UseVisualStyleBackColor = false;
            selecionarCategoriaEdit.Click += selecionarCategoriaEdit_Click;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(183, 883);
            label13.Name = "label13";
            label13.Size = new Size(200, 20);
            label13.TabIndex = 37;
            label13.Text = "EDITAR CATEGORIAS";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            label13.Click += label13_Click;
            // 
            // comboBoxCategoriasEdit
            // 
            comboBoxCategoriasEdit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoriasEdit.FormattingEnabled = true;
            comboBoxCategoriasEdit.Location = new Point(108, 921);
            comboBoxCategoriasEdit.Name = "comboBoxCategoriasEdit";
            comboBoxCategoriasEdit.Size = new Size(189, 23);
            comboBoxCategoriasEdit.TabIndex = 36;
            // 
            // nomeCategoriaEdit
            // 
            nomeCategoriaEdit.Location = new Point(108, 986);
            nomeCategoriaEdit.Name = "nomeCategoriaEdit";
            nomeCategoriaEdit.Size = new Size(348, 23);
            nomeCategoriaEdit.TabIndex = 38;
            // 
            // editCategoria
            // 
            editCategoria.BackColor = Color.FromArgb(100, 181, 246);
            editCategoria.FlatAppearance.BorderSize = 0;
            editCategoria.FlatStyle = FlatStyle.Flat;
            editCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editCategoria.ForeColor = Color.White;
            editCategoria.Location = new Point(108, 1032);
            editCategoria.Name = "editCategoria";
            editCategoria.Size = new Size(136, 23);
            editCategoria.TabIndex = 41;
            editCategoria.Text = "EDITAR";
            editCategoria.UseVisualStyleBackColor = false;
            editCategoria.Click += editCategoria_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(108, 968);
            label12.Name = "label12";
            label12.Size = new Size(107, 15);
            label12.TabIndex = 39;
            label12.Text = "NOME CATEGORIA";
            // 
            // deletar
            // 
            deletar.BackColor = Color.FromArgb(100, 181, 246);
            deletar.FlatAppearance.BorderSize = 0;
            deletar.FlatStyle = FlatStyle.Flat;
            deletar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletar.ForeColor = Color.White;
            deletar.Location = new Point(320, 1137);
            deletar.Name = "deletar";
            deletar.Size = new Size(136, 23);
            deletar.TabIndex = 44;
            deletar.Text = "DELETAR";
            deletar.UseVisualStyleBackColor = false;
            deletar.Click += deletar_Click;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(183, 1099);
            label14.Name = "label14";
            label14.Size = new Size(200, 20);
            label14.TabIndex = 43;
            label14.Text = "DELETAR PRODUTOS";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxProdDelete
            // 
            comboBoxProdDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProdDelete.FormattingEnabled = true;
            comboBoxProdDelete.Location = new Point(108, 1137);
            comboBoxProdDelete.Name = "comboBoxProdDelete";
            comboBoxProdDelete.Size = new Size(189, 23);
            comboBoxProdDelete.TabIndex = 42;
            // 
            // deleteCat
            // 
            deleteCat.BackColor = Color.FromArgb(100, 181, 246);
            deleteCat.FlatAppearance.BorderSize = 0;
            deleteCat.FlatStyle = FlatStyle.Flat;
            deleteCat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteCat.ForeColor = Color.White;
            deleteCat.Location = new Point(320, 1240);
            deleteCat.Name = "deleteCat";
            deleteCat.Size = new Size(136, 23);
            deleteCat.TabIndex = 47;
            deleteCat.Text = "DELETAR";
            deleteCat.UseVisualStyleBackColor = false;
            deleteCat.Click += deleteCat_Click;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(183, 1202);
            label15.Name = "label15";
            label15.Size = new Size(200, 20);
            label15.TabIndex = 46;
            label15.Text = "DELETAR CATEGORIAS";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxCatDelete
            // 
            comboBoxCatDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCatDelete.FormattingEnabled = true;
            comboBoxCatDelete.Location = new Point(108, 1240);
            comboBoxCatDelete.Name = "comboBoxCatDelete";
            comboBoxCatDelete.Size = new Size(189, 23);
            comboBoxCatDelete.TabIndex = 45;
            // 
            // GerenciarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(567, 371);
            Controls.Add(deleteCat);
            Controls.Add(label15);
            Controls.Add(comboBoxCatDelete);
            Controls.Add(deletar);
            Controls.Add(label14);
            Controls.Add(comboBoxProdDelete);
            Controls.Add(editCategoria);
            Controls.Add(selecionarCategoriaEdit);
            Controls.Add(label12);
            Controls.Add(nomeCategoriaEdit);
            Controls.Add(label13);
            Controls.Add(comboBoxCategoriasEdit);
            Controls.Add(editar);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(descEdit);
            Controls.Add(label9);
            Controls.Add(precoEdit);
            Controls.Add(label10);
            Controls.Add(nomeEdit);
            Controls.Add(label11);
            Controls.Add(comboBox2);
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
            Load += GerenciarProdutos_Load;
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
        private Button button3;
        private Label label5;
        private TextBox descEdit;
        private Label label9;
        private TextBox precoEdit;
        private Label label10;
        private TextBox nomeEdit;
        private Label label11;
        private ComboBox comboBox2;
        private Button editar;
        private Button selecionarCategoriaEdit;
        private Label label13;
        private ComboBox comboBoxCategoriasEdit;
        private TextBox nomeCategoriaEdit;
        private Button editCategoria;
        private Label label12;
        private Button deletar;
        private Label label14;
        private ComboBox comboBoxProdDelete;
        private Button deleteCat;
        private Label label15;
        private ComboBox comboBoxCatDelete;
    }
}