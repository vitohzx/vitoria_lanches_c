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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private string textoParaConexao = "server=127.0.0.1;database=vitoria_lanches;user=root;password=root;";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(textoParaConexao))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO tb_usuarios (TB_USUARIOS_USERNAME, TB_USUARIOS_PASSWORD, TB_USUARIOS_TIPO) " +
                        "VALUES (@user, @password, @tipo)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@user", txtUsername.Text);
                    command.Parameters.AddWithValue("@password", txtPassword.Text);
                    command.Parameters.AddWithValue("@tipo", "cliente");
                    command.ExecuteNonQuery();
                    MessageBox.Show("Usuario cadastrado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
               connection.Close();
            }
        }
    }
}
