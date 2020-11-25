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
using MySql.Data;
using System.Threading;


namespace appf1
{
    public partial class Login : Form
    {
        Thread nt;

        MySqlConnection conexao = new MySqlConnection("server = localhost; UID = root; pwd ='' ; database = app01; port = 3306; SslMode = none"); //Mudar o nome do DB
        MySqlCommand cmd = new MySqlCommand();

        public Login()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

            Form1 cadastro = new Form1();
            cadastro.Show();
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
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

        private void tPrincipal()
        {
            Application.Run(new CalcVolt());
           
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void esqueceuSenhaText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
        
    

