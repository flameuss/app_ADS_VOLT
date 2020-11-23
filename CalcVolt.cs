using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appf1
{
    public partial class CalcVolt : Form
    {
        public CalcVolt()
        {
            InitializeComponent();
        }

        private void CalcVolt_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnBody, Color.White, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop);
        }
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void Pn_Usuario_PaddingChanged(object sender, EventArgs e)
        {

        }

        private void calcularButton_CheckedChanged(object sender, EventArgs e)
        {
            if (calcularButton.Checked == true)
            {
                pn_Calcular2.BringToFront();
            }
        }

        private void estatisticasButton_CheckedChanged(object sender, EventArgs e)
        {
            if (estatisticasButton.Checked == true)
            {
                pn_Estatisticas.BringToFront();
            }
        }

        private void userButton_CheckedChanged(object sender, EventArgs e)
        {
            if (userButton.Checked == true)
            {
                Pn_Usuario.BringToFront();
            }
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (userButton.Checked == true)
            {
                Pn_Usuario.BringToFront();
            }
        }

        private void guna2HtmlLabel18_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel19_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel29_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel21_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void p1g_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel26_Click(object sender, EventArgs e)
        {

        }
        public Boolean Verificador(string _a)
        {
            bool seNumeroInteiro = double.TryParse(_a, out double Numero);

            if(seNumeroInteiro == true)
            {
               return true;
            }
               return false;
        }

        private void guna2RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2RadioButton8.Checked)
            {
                pn_Calcular2.BringToFront();

                guna2RadioButton7.Checked = false;
                guna2RadioButton5.Checked = false;
                guna2RadioButton6.Checked = true;

                if (guna2TextBox11.Text != "" && guna2TextBox12.Text != "" && guna2TextBox6.Text != "")
                {
                Eletro eletro = new Eletro(guna2TextBox5.Text, guna2TextBox10.Text, Double.Parse(guna2TextBox6.Text),false);
                guna2TextBox9.Text = eletro.calcularkwh(guna2TextBox11.Text);
                guna2TextBox7.Text = eletro.gasto(guna2TextBox12.Text);
                }

                else
                {
                    guna2TextBox9.Text = "";
                    guna2TextBox7.Text = "";
                }

            }
        }

        private void guna2RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2RadioButton7.Checked)
            {
                pn_Calcular2.BringToFront();

                guna2RadioButton6.Checked = false;
                guna2RadioButton5.Checked = true;
                guna2RadioButton8.Checked = false;


                if (guna2TextBox11.Text != "" && guna2TextBox12.Text != "" && guna2TextBox6.Text != "")
                {
                    Eletro eletro = new Eletro(guna2TextBox5.Text, guna2TextBox10.Text, Double.Parse(guna2TextBox6.Text), true);
                    guna2TextBox9.Text = eletro.calcularkwh(guna2TextBox11.Text);
                    guna2TextBox7.Text = eletro.gasto(guna2TextBox12.Text);
                }

                else
                {
                    guna2TextBox9.Text = "";
                    guna2TextBox7.Text = "";
                }
            }

        }

        private void guna2RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2RadioButton6.Checked)
            {
                pn_Calcular2.BringToFront();

                guna2RadioButton8.Checked = true;
                guna2RadioButton7.Checked = false;
                guna2RadioButton5.Checked = false;
            }

        }

        private void guna2RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2RadioButton5.Checked)
            {
                pn_Calcular2.BringToFront();

                guna2RadioButton6.Checked = false;
                guna2RadioButton7.Checked = true;
                guna2RadioButton8.Checked = false;
            }
        }

        private void guna2HtmlLabel25_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox11_TextChanged(object sender, EventArgs e)
        {
            if (Verificador(guna2TextBox11.Text) == false && guna2TextBox11.Text != "") {
                guna2TextBox11.Text = ""; 
                MessageBox.Show("Erro: Este campo só aceita números");
            }
        }

        private void guna2TextBox12_TextChanged(object sender, EventArgs e)
        {
            if (Verificador(guna2TextBox12.Text) == false && guna2TextBox12.Text != "")
            {
                guna2TextBox12.Text = "";
                MessageBox.Show("Erro: Este campo só aceita números");
            }
        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {
            if (Verificador(guna2TextBox6.Text) == false && guna2TextBox6.Text != "")
            {
                guna2TextBox6.Text = "";
                MessageBox.Show("Erro: Este campo só aceita números");
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void painelPrincipal_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void estatisticasButton_Click(object sender, EventArgs e)
        {

        }
    }
}
