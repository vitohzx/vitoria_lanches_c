using MySql.Data.MySqlClient;

namespace lanches_vitoria
{
    public partial class Login : Form
    {
        private Form Home;

        public Login(Form home)
        {
            InitializeComponent();
            this.Home = home;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
             
            string connectionString = "server=localhost;user=root;password=root;database=vitoria_lanches";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();
                string query = "SELECT * FROM tb_usuarios WHERE TB_USUARIOS_USERNAME = @username AND TB_USUARIOS_PASSWORD = @password";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", txtUsername.Text);
                    command.Parameters.AddWithValue("@password", txtPassword.Text);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            MessageBox.Show("Login bem-sucedido!");
                            Program.DadosUser.userName = txtUsername.Text;
                            Program.DadosUser.userTipo = reader["TB_USUARIOS_TIPO"].ToString();
                            Program.DadosUser.userId = int.Parse(reader["TB_USUARIOS_ID"].ToString());

                            if (Program.DadosUser.userTipo == "administrador")
                            {
                                HomeAdmin homeAdmin = new HomeAdmin();
                                homeAdmin.Show();
                                Home.Hide();
                            }
                            else
                            {
                                HomeCliente homeAdmin = new HomeCliente();
                                homeAdmin.Show();
                                Home.Hide();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos.");
                        }

                        
                    }
                }
                connection.Close();
            }
        }
    }
}
