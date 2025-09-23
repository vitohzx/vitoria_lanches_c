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
        private void PrencherComboBox()
        {
            string connectionString = "server=localhost;user=root;password=root;database=vitoria_lanches";
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
                            comboBox1.Items.Add(reader.GetString("TB_TIPO_PRODUTO_DESC"));
                        }
                    }

                }
            }
        }

        private int getIdCategoria()
        {
            string connectionString = "server=localhost;user=root;password=root;database=vitoria_lanches";
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


        public GerenciarProdutos()
        {
            InitializeComponent();
            PrencherComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            string connectionString = "server=localhost;user=root;password=root;database=vitoria_lanches";

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

            string connectionString = "server=localhost;user=root;password=root;database=vitoria_lanches";

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
                    PrencherComboBox();
                }
                connection.Close();
            }
        }
    }
}
