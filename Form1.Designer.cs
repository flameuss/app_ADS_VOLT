
namespace appf1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cIdBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.cSenhaBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LogarButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(225, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(202, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "SENHA:";
            // 
            // cIdBox
            // 
            this.cIdBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(101)))));
            this.cIdBox.BorderRadius = 5;
            this.cIdBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cIdBox.DefaultText = "";
            this.cIdBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cIdBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cIdBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cIdBox.DisabledState.Parent = this.cIdBox;
            this.cIdBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cIdBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.cIdBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cIdBox.FocusedState.Parent = this.cIdBox;
            this.cIdBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cIdBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.cIdBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cIdBox.HoverState.Parent = this.cIdBox;
            this.cIdBox.Location = new System.Drawing.Point(123, 192);
            this.cIdBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cIdBox.Name = "cIdBox";
            this.cIdBox.PasswordChar = '\0';
            this.cIdBox.PlaceholderText = "";
            this.cIdBox.SelectedText = "";
            this.cIdBox.ShadowDecoration.Parent = this.cIdBox;
            this.cIdBox.Size = new System.Drawing.Size(248, 37);
            this.cIdBox.TabIndex = 5;
            // 
            // cSenhaBox
            // 
            this.cSenhaBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(101)))));
            this.cSenhaBox.BorderRadius = 5;
            this.cSenhaBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cSenhaBox.DefaultText = "";
            this.cSenhaBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cSenhaBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cSenhaBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cSenhaBox.DisabledState.Parent = this.cSenhaBox;
            this.cSenhaBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cSenhaBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.cSenhaBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cSenhaBox.FocusedState.Parent = this.cSenhaBox;
            this.cSenhaBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cSenhaBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.cSenhaBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cSenhaBox.HoverState.Parent = this.cSenhaBox;
            this.cSenhaBox.Location = new System.Drawing.Point(123, 280);
            this.cSenhaBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cSenhaBox.Name = "cSenhaBox";
            this.cSenhaBox.PasswordChar = '*';
            this.cSenhaBox.PlaceholderText = "";
            this.cSenhaBox.SelectedText = "";
            this.cSenhaBox.ShadowDecoration.Parent = this.cSenhaBox;
            this.cSenhaBox.Size = new System.Drawing.Size(248, 37);
            this.cSenhaBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(33, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "CRIE SEU CADASTRO PARA ACESSO AO PROGRAMA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(90, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "CRIE SEU CADASTRO PARA ACESSO AO PROGRAMA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // LogarButton
            // 
            this.LogarButton.BorderRadius = 5;
            this.LogarButton.CheckedState.Parent = this.LogarButton;
            this.LogarButton.CustomImages.Parent = this.LogarButton;
            this.LogarButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(179)))));
            this.LogarButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(54)))), ((int)(((byte)(190)))));
            this.LogarButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.LogarButton.ForeColor = System.Drawing.Color.White;
            this.LogarButton.HoverState.Parent = this.LogarButton;
            this.LogarButton.Location = new System.Drawing.Point(123, 351);
            this.LogarButton.Name = "LogarButton";
            this.LogarButton.ShadowDecoration.Parent = this.LogarButton;
            this.LogarButton.Size = new System.Drawing.Size(248, 37);
            this.LogarButton.TabIndex = 9;
            this.LogarButton.Text = "CADASTRAR";
            this.LogarButton.Click += new System.EventHandler(this.LogarButton_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.guna2ControlBox1.CustomIconSize = 12F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(454, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 45);
            this.guna2ControlBox1.TabIndex = 10;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.LogarButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cSenhaBox);
            this.Controls.Add(this.cIdBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox cIdBox;
        private Guna.UI2.WinForms.Guna2TextBox cSenhaBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton LogarButton;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}