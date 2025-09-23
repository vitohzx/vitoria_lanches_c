using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace lanches_vitoria
{
    internal class Conexao
    {
        private readonly string _connectionString;
        public Conexao()
        {
            // Idealmente, a string de conexão deve ser armazenada em um arquivo de configuração.
            _connectionString = "Server=localhost;Database=vitoria_lanches;Uid=root;Pwd=root;";
        }
        public MySqlConnection Conectar()
        {
            try
            {
                var conexao = new MySqlConnection(_connectionString);
                conexao.Open(); // Abre a conexão para verificar se está funcional
                return conexao;
            }
            catch (MySqlException ex)
            {
                // Log de erro ou tratamento apropriado
                throw new Exception("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }

        public void FecharConexao(MySqlConnection conexao)
        {
            if (conexao != null && conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        public DataTable ExecutarConsulta(string query)
        {
            using (var conexao = Conectar()) // Reutiliza o método Conectar
            {
                using (var cmd = new MySqlCommand(query, conexao))
                {
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable tabela = new DataTable();
                        adapter.Fill(tabela);
                        return tabela;
                    }
                }
            }
        }
    }
}
