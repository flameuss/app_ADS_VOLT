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
        {
            conexao.Open();
            cmd.Connection = conexao;

            try
            {
                cmd.CommandText = "SELECT * FROM login WHERE login= '" + LoginTextBox.Text + "' and senha = '" + SenhaTextBox.Text + "'"; //inserção dos valores dgitados para realização do login

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

            conexao.Close();
        }
    }
}
