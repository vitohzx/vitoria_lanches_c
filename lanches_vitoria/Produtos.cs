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
    public partial class Produtos : Form
    {
        private string connectionString = "server=localhost;user=root;password=root;database=vitoria_lanches";
        public Produtos()
        {
            InitializeComponent();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TB_PRODUTO_NOME AS PRODUTO, TB_PRODUTO_DESC AS DESCRIÇÃO, TB_PRODUTO_PRECO_UNIT AS PREÇO FROM tb_produto";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable tabela = new DataTable();
                        adapter.Fill(tabela);

                        dataGridView1.DataSource = tabela;
                    }

                }

            }

            // estilo do datagrid
 
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 181, 246);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.LightGray;

        }
    }
}
