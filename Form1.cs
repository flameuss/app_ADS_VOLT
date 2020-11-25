using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace appf1
{
    public partial class Form1 : Form
    {
        Thread nt;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        MySqlConnection conexao = new MySqlConnection("server = localhost; UID = root; pwd ='' ; database = app01; port = 3306; SslMode = none"); //Mudar o nome do DB
        MySqlCommand cmd = new MySqlCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel16_Click(object sender, EventArgs e)
        {

        }

        private void pesquisaCtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel17_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LogarButton_Click(object sender, EventArgs e)
        {/*
            conexao.Open();
            cmd.Connection = conexao;

            try
            {
                cmd.CommandText = "ADD * FROM login WHERE login= '" + cIdBox.Text + "' and senha = '" + cSenhaBox.Text + "'"; //inserção dos valores dgitados para realização do login

                MySqlDataReader ler = cmd.ExecuteReader();

                if (ler.Read())
                {
                    this.Close();
                    nt = new Thread(tPrincipal);
                    nt.SetApartmentState(ApartmentState.STA);
                    nt.Start();
                }
                else
                {
                    MessageBox.Show("Ops, aconteceu algum problema\n\n " +
                        "Usuário ou senha inválido(s)\n ou\n Usuário não cadastrado", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex);
            }
           // Início da Conexão com indicação de qual o servidor, nome de base de dados e utilizar
 
	/* É aconselhável criar um utilizador com password. Para acrescentar a password é somente
	necessário acrescentar o seguinte código a seguir ao uid=root;password=xxxxx*/

            

            // Abre a conexão
            conexao.Open();

            //Query SQL
            
            MySqlCommand command = new MySqlCommand("INSERT INTO login (login ,senha)" +
            "VALUES('" + cIdBox.Text + "','" + cSenhaBox.Text + "')", conexao);

            //Executa a Query SQL
            command.ExecuteNonQuery();

            // Fecha a conexão
           conexao.Close();

            //Mensagem de Sucesso
            MessageBox.Show("Cadastro Realizado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }
    }
}
