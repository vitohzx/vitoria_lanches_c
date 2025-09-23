using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lanches_vitoria
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public void CarregarnoPainel(string nomeFormulario)
        {

            Form formulario = nomeFormulario switch
            {
                "Login" => new Login(this),
                "Cadastrar" => new Cadastro(),
                "Inicio" => new Inicio(),
                "Produtos" => new Produtos(),
                // Adicione outros formulários aqui
                _ => throw new ArgumentException("Formulário não reconhecido.")
            };

            formulario.TopLevel = false;                       // Define que o objeto do Form atualizar não é um formulário de nível superior
            formulario.FormBorderStyle = FormBorderStyle.None; // Remove a borda do objeto do Form atualizar
            formulario.Dock = DockStyle.Fill;                  // Faz com que o objeto do Form atualizar preencha todo o painel
            panel2.Controls.Clear();                       // Apaga todos os elemento anteriores do painel 3 para poder exibir os novos 
            panel2.Controls.Add(formulario);                   // Adiciona o objeto do Form atualizar ao painel 3
            formulario.Show();                                 // Exibe o conteúdo do objeto do Form atualizar
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("Login");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("Cadastrar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("Produtos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("Inicio");
        }
    }
}
