
namespace View
{
    partial class FormLogin
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
            this.txtBoxLoginUsuario = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxLoginSenha = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.progressBarLogin = new System.Windows.Forms.ProgressBar();
            this.labelProgressLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxLoginUsuario
            // 
            this.txtBoxLoginUsuario.Location = new System.Drawing.Point(110, 83);
            this.txtBoxLoginUsuario.Name = "txtBoxLoginUsuario";
            this.txtBoxLoginUsuario.Size = new System.Drawing.Size(166, 20);
            this.txtBoxLoginUsuario.TabIndex = 2;
            this.txtBoxLoginUsuario.Text = "Murilo";
            this.txtBoxLoginUsuario.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(156, 135);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBoxLoginSenha
            // 
            this.txtBoxLoginSenha.Location = new System.Drawing.Point(110, 109);
            this.txtBoxLoginSenha.Name = "txtBoxLoginSenha";
            this.txtBoxLoginSenha.Size = new System.Drawing.Size(166, 20);
            this.txtBoxLoginSenha.TabIndex = 5;
            this.txtBoxLoginSenha.Text = "murilo123";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(58, 86);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(46, 13);
            this.labelUsuario.TabIndex = 7;
            this.labelUsuario.Text = "Usuário:";
            this.labelUsuario.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(63, 112);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(41, 13);
            this.labelSenha.TabIndex = 8;
            this.labelSenha.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(139, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "LOGIN DO USUÁRIO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(126, 267);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(143, 13);
            this.lblMsg.TabIndex = 30;
            this.lblMsg.Text = "Usuário ou senha inválidos!!!";
            this.lblMsg.Visible = false;
            // 
            // progressBarLogin
            // 
            this.progressBarLogin.Location = new System.Drawing.Point(22, 208);
            this.progressBarLogin.Name = "progressBarLogin";
            this.progressBarLogin.Size = new System.Drawing.Size(338, 23);
            this.progressBarLogin.TabIndex = 31;
            // 
            // labelProgressLogin
            // 
            this.labelProgressLogin.AutoSize = true;
            this.labelProgressLogin.Location = new System.Drawing.Point(153, 181);
            this.labelProgressLogin.Name = "labelProgressLogin";
            this.labelProgressLogin.Size = new System.Drawing.Size(89, 13);
            this.labelProgressLogin.TabIndex = 32;
            this.labelProgressLogin.Text = "Processando..0%";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 289);
            this.Controls.Add(this.labelProgressLogin);
            this.Controls.Add(this.progressBarLogin);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.txtBoxLoginSenha);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBoxLoginUsuario);
            this.Name = "FormLogin";
            this.Text = "Efetuar login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxLoginUsuario;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBoxLoginSenha;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.ProgressBar progressBarLogin;
        private System.Windows.Forms.Label labelProgressLogin;
    }
}

