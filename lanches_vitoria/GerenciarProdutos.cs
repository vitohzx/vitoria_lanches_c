using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lanches_vitoria
{
    public partial class GerenciarProdutos : Form
    {
        private string connectionString = "server=localhost;user=root;password=root;database=vitoria_lanches";
        private void PrencherComboBoxCategorias(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            string query = "SELECT * FROM tb_tipo_produto";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox.Items.Add(reader.GetString("TB_TIPO_PRODUTO_DESC"));
                        }
                    }

                }
                connection.Close();
            }
        }

        private void PrencherComboBoxProdutos(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            string query = "SELECT * FROM tb_produto";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox.Items.Add(reader.GetString("TB_PRODUTO_NOME"));
                        }
                    }

                }
                connection.Close();
            }
        }

        private int getIdCategoria()
        {
            string query = "SELECT TB_TIPO_PRODUTO_ID FROM tb_tipo_produto WHERE TB_TIPO_PRODUTO_DESC = @nomeProduto";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomeProduto", comboBox1.Text);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int produtoId = reader.GetInt32("TB_TIPO_PRODUTO_ID");
                            return produtoId;
                        }
                    }
                }
            }
            return -1;
        }

        private void carregarDados()
        {
            PrencherComboBoxCategorias(comboBox1);
            PrencherComboBoxCategorias(comboBoxCatDelete);
            PrencherComboBoxCategorias(comboBoxCategoriasEdit);
            PrencherComboBoxProdutos(comboBox2);
            PrencherComboBoxProdutos(comboBoxProdDelete);
        }


        public GerenciarProdutos()
        {
            InitializeComponent();
            carregarDados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Selecione uma categoria antes de criar o produto!");
                return;
            }

            string nomeProduto = nome.Text;
            string descricaoProduto = desc.Text;
            string precoProduto = preco.Text;
            string categoriaProduto = comboBox1.Text;
            decimal precoConvertido = 0;

            try
            {
                precoConvertido = Convert.ToDecimal(precoProduto);
            }
            catch
            {
                return;
            }



            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();
                string query = "INSERT INTO tb_produto (TB_PRODUTO_NOME, TB_PRODUTO_DESC, TB_PRODUTO_PRECO_UNIT, TB_TIPO_PRODUTO_ID) " +
                    "VALUES (@nome, @desc, @preco, @categoria)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", nomeProduto);
                    command.Parameters.AddWithValue("@desc", descricaoProduto);
                    command.Parameters.AddWithValue("@preco", precoConvertido);
                    command.Parameters.AddWithValue("@categoria", getIdCategoria());

                    command.ExecuteNonQuery();
                    MessageBox.Show("Produto cadastrado com sucesso!");

                    nome.Text = "";
                    desc.Text = "";
                    preco.Text = "";
                    comboBox1.Text = "";
                }
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string categoriaNome = nomeCategoria.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();
                string query = "INSERT INTO tb_tipo_produto (TB_TIPO_PRODUTO_DESC) " +
                    "VALUES (@nome)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", categoriaNome);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Categoria cadastrada com sucesso!");

                    nomeCategoria.Text = "";

                    carregarDados();
                }
                connection.Close();
            }
        }

        private void GerenciarProdutos_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string produtoNome = comboBox2.Text;


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM tb_produto WHERE TB_PRODUTO_NOME = @nome";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", produtoNome);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nomeEdit.Text = reader.GetString("TB_PRODUTO_NOME");
                            descEdit.Text = reader.GetString("TB_PRODUTO_DESC");
                            precoEdit.Text = reader.GetDecimal("TB_PRODUTO_PRECO_UNIT").ToString();
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado");
                        }

                    }
                }
                connection.Close();
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Selecione um produto para edição!");
                return;
            }


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE tb_produto SET TB_PRODUTO_NOME = @nome, TB_PRODUTO_DESC = @desc, TB_PRODUTO_PRECO_UNIT = @preco WHERE TB_PRODUTO_NOME = @nomeAntigo";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", nomeEdit.Text);
                    command.Parameters.AddWithValue("@desc", descEdit.Text);
                    command.Parameters.AddWithValue("@preco", Convert.ToDecimal(precoEdit.Text));
                    command.Parameters.AddWithValue("@nomeAntigo", comboBox2.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Produto editado com sucesso!");
                    nomeEdit.Text = "";
                    descEdit.Text = "";
                    precoEdit.Text = "";

                    carregarDados();
                }
                connection.Close();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void selecionarCategoriaEdit_Click(object sender, EventArgs e)
        {
            string categoriaNome = comboBoxCategoriasEdit.Text;


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM tb_tipo_produto WHERE TB_TIPO_PRODUTO_DESC = @nome";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", categoriaNome);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nomeCategoriaEdit.Text = reader.GetString("TB_TIPO_PRODUTO_DESC");
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado");
                        }

                    }
                }
                connection.Close();
            }
        }

        private void editCategoria_Click(object sender, EventArgs e)
        {
            if (comboBoxCategoriasEdit.Text == "")
            {
                MessageBox.Show("Selecione uma categoria para edição!");
                return;
            }


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE tb_tipo_produto SET TB_TIPO_PRODUTO_DESC = @nome WHERE TB_TIPO_PRODUTO_DESC = @nomeAntigo";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", nomeCategoriaEdit.Text);
                    command.Parameters.AddWithValue("@nomeAntigo", comboBoxCategoriasEdit.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Categoria editada com sucesso!");
                    nomeCategoriaEdit.Text = "";

                    carregarDados();
                }
                connection.Close();
            }
        }

        private void deletar_Click(object sender, EventArgs e)
        {
            if (comboBoxProdDelete.Text == "")
            {
                MessageBox.Show("Selecione um produto para deletar!");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM tb_produto WHERE TB_PRODUTO_NOME = @nome";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", comboBoxProdDelete.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Produto deletado com sucesso!");
                    carregarDados();
                }
                connection.Close();
            }
        }

        private void deleteCat_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                if (comboBoxCatDelete.Text == "")
                {
                    MessageBox.Show("Selecione uma categoria para deletar!");
                    return;
                }
                connection.Open();
                string query = "DELETE FROM tb_tipo_produto WHERE TB_TIPO_PRODUTO_DESC = @nome";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", comboBoxCatDelete.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Categoria deletada com sucesso!");
                    carregarDados();
                }
                connection.Close();
            }
        }
    }
}
