
namespace appf1
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.VersaoText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CadastreseButton = new Guna.UI2.WinForms.Guna2Button();
            this.esqueceuSenhaText = new System.Windows.Forms.LinkLabel();
            this.LogarButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SenhaTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.senhaText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LoginTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LoginInfText02 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LoginInfText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.OndasPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.arredondamentoCantos = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OndasPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            resources.ApplyResources(this.LoginPanel, "LoginPanel");
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.LoginPanel.BorderRadius = 2;
            this.LoginPanel.Controls.Add(this.guna2ControlBox1);
            this.LoginPanel.Controls.Add(this.VersaoText);
            this.LoginPanel.Controls.Add(this.CadastreseButton);
            this.LoginPanel.Controls.Add(this.esqueceuSenhaText);
            this.LoginPanel.Controls.Add(this.LogarButton);
            this.LoginPanel.Controls.Add(this.SenhaTextBox);
            this.LoginPanel.Controls.Add(this.senhaText);
            this.LoginPanel.Controls.Add(this.LoginTextBox);
            this.LoginPanel.Controls.Add(this.loginText);
            this.LoginPanel.Controls.Add(this.LoginInfText02);
            this.LoginPanel.Controls.Add(this.LoginInfText);
            this.LoginPanel.Controls.Add(this.OndasPictureBox);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.ShadowDecoration.Parent = this.LoginPanel;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPanel_Paint);
            // 
            // VersaoText
            // 
            this.VersaoText.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.VersaoText, "VersaoText");
            this.VersaoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.VersaoText.Name = "VersaoText";
            this.VersaoText.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.VersaoText.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // CadastreseButton
            // 
            this.CadastreseButton.CheckedState.Parent = this.CadastreseButton;
            this.CadastreseButton.CustomImages.Parent = this.CadastreseButton;
            this.CadastreseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            resources.ApplyResources(this.CadastreseButton, "CadastreseButton");
            this.CadastreseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.CadastreseButton.HoverState.Parent = this.CadastreseButton;
            this.CadastreseButton.Image = ((System.Drawing.Image)(resources.GetObject("CadastreseButton.Image")));
            this.CadastreseButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CadastreseButton.ImageSize = new System.Drawing.Size(25, 20);
            this.CadastreseButton.Name = "CadastreseButton";
            this.CadastreseButton.ShadowDecoration.Parent = this.CadastreseButton;
            this.CadastreseButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CadastreseButton.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // esqueceuSenhaText
            // 
            this.esqueceuSenhaText.ActiveLinkColor = System.Drawing.Color.White;
            resources.ApplyResources(this.esqueceuSenhaText, "esqueceuSenhaText");
            this.esqueceuSenhaText.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.esqueceuSenhaText.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(101)))), ((int)(((byte)(134)))));
            this.esqueceuSenhaText.Name = "esqueceuSenhaText";
            this.esqueceuSenhaText.TabStop = true;
            // 
            // LogarButton
            // 
            this.LogarButton.BorderRadius = 5;
            this.LogarButton.CheckedState.Parent = this.LogarButton;
            this.LogarButton.CustomImages.Parent = this.LogarButton;
            this.LogarButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(179)))));
            this.LogarButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(54)))), ((int)(((byte)(190)))));
            resources.ApplyResources(this.LogarButton, "LogarButton");
            this.LogarButton.ForeColor = System.Drawing.Color.White;
            this.LogarButton.HoverState.Parent = this.LogarButton;
            this.LogarButton.Name = "LogarButton";
            this.LogarButton.ShadowDecoration.Parent = this.LogarButton;
            this.LogarButton.Click += new System.EventHandler(this.LogarButton_Click);
            // 
            // SenhaTextBox
            // 
            this.SenhaTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(101)))));
            this.SenhaTextBox.BorderRadius = 5;
            this.SenhaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SenhaTextBox.DefaultText = "";
            this.SenhaTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SenhaTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SenhaTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SenhaTextBox.DisabledState.Parent = this.SenhaTextBox;
            this.SenhaTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SenhaTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.SenhaTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SenhaTextBox.FocusedState.Parent = this.SenhaTextBox;
            resources.ApplyResources(this.SenhaTextBox, "SenhaTextBox");
            this.SenhaTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.SenhaTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SenhaTextBox.HoverState.Parent = this.SenhaTextBox;
            this.SenhaTextBox.Name = "SenhaTextBox";
            this.SenhaTextBox.PasswordChar = '*';
            this.SenhaTextBox.PlaceholderText = "";
            this.SenhaTextBox.SelectedText = "";
            this.SenhaTextBox.ShadowDecoration.Parent = this.SenhaTextBox;
            // 
            // senhaText
            // 
            this.senhaText.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.senhaText, "senhaText");
            this.senhaText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.senhaText.Name = "senhaText";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(101)))));
            this.LoginTextBox.BorderRadius = 5;
            this.LoginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginTextBox.DefaultText = "";
            this.LoginTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoginTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoginTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginTextBox.DisabledState.Parent = this.LoginTextBox;
            this.LoginTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.LoginTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginTextBox.FocusedState.Parent = this.LoginTextBox;
            resources.ApplyResources(this.LoginTextBox, "LoginTextBox");
            this.LoginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.LoginTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginTextBox.HoverState.Parent = this.LoginTextBox;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PasswordChar = '\0';
            this.LoginTextBox.PlaceholderText = "";
            this.LoginTextBox.SelectedText = "";
            this.LoginTextBox.ShadowDecoration.Parent = this.LoginTextBox;
            this.LoginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox_TextChanged);
            // 
            // loginText
            // 
            this.loginText.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.loginText, "loginText");
            this.loginText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.loginText.Name = "loginText";
            // 
            // LoginInfText02
            // 
            this.LoginInfText02.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LoginInfText02, "LoginInfText02");
            this.LoginInfText02.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginInfText02.Name = "LoginInfText02";
            this.LoginInfText02.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // LoginInfText
            // 
            this.LoginInfText.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LoginInfText, "LoginInfText");
            this.LoginInfText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginInfText.Name = "LoginInfText";
            // 
            // OndasPictureBox
            // 
            this.OndasPictureBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.OndasPictureBox, "OndasPictureBox");
            this.OndasPictureBox.Name = "OndasPictureBox";
            this.OndasPictureBox.ShadowDecoration.Parent = this.OndasPictureBox;
            this.OndasPictureBox.TabStop = false;
            this.OndasPictureBox.UseTransparentBackground = true;
            this.OndasPictureBox.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // arredondamentoCantos
            // 
            this.arredondamentoCantos.BorderRadius = 10;
            this.arredondamentoCantos.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            resources.ApplyResources(this.guna2ControlBox1, "guna2ControlBox1");
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OndasPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel LoginPanel;
        private Guna.UI2.WinForms.Guna2PictureBox OndasPictureBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel LoginInfText02;
        private Guna.UI2.WinForms.Guna2HtmlLabel LoginInfText;
        private Guna.UI2.WinForms.Guna2GradientButton LogarButton;
        private Guna.UI2.WinForms.Guna2TextBox SenhaTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel senhaText;
        private Guna.UI2.WinForms.Guna2TextBox LoginTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel loginText;
        private Guna.UI2.WinForms.Guna2Button CadastreseButton;
        private System.Windows.Forms.LinkLabel esqueceuSenhaText;
        private Guna.UI2.WinForms.Guna2Elipse arredondamentoCantos;
        private Guna.UI2.WinForms.Guna2HtmlLabel VersaoText;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}

