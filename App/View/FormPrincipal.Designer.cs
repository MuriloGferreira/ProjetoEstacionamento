
namespace View
{
    partial class FormPrincipal
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
            this.btnLoadCliente = new System.Windows.Forms.Button();
            this.btnVeiculo = new System.Windows.Forms.Button();
            this.btnLoadVaga = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.UsuarioLogado = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnListarVeiculosN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnListarVaga = new System.Windows.Forms.Button();
            this.btnShowPictures = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadCliente
            // 
            this.btnLoadCliente.Location = new System.Drawing.Point(96, 153);
            this.btnLoadCliente.Name = "btnLoadCliente";
            this.btnLoadCliente.Size = new System.Drawing.Size(216, 54);
            this.btnLoadCliente.TabIndex = 0;
            this.btnLoadCliente.Text = "CADASTRAR CLIENTE";
            this.btnLoadCliente.UseVisualStyleBackColor = true;
            this.btnLoadCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnVeiculo
            // 
            this.btnVeiculo.Location = new System.Drawing.Point(96, 273);
            this.btnVeiculo.Name = "btnVeiculo";
            this.btnVeiculo.Size = new System.Drawing.Size(216, 54);
            this.btnVeiculo.TabIndex = 1;
            this.btnVeiculo.Text = "CADASTRAR VEICULO";
            this.btnVeiculo.UseVisualStyleBackColor = true;
            this.btnVeiculo.Click += new System.EventHandler(this.btnCadastrarVeiculo_Click);
            // 
            // btnLoadVaga
            // 
            this.btnLoadVaga.Location = new System.Drawing.Point(96, 393);
            this.btnLoadVaga.Name = "btnLoadVaga";
            this.btnLoadVaga.Size = new System.Drawing.Size(216, 54);
            this.btnLoadVaga.TabIndex = 2;
            this.btnLoadVaga.Text = "REGISTRAR VEICULO NA VAGA";
            this.btnLoadVaga.UseVisualStyleBackColor = true;
            this.btnLoadVaga.Click += new System.EventHandler(this.btnLoadVaga_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(143, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "MENU DE OPÇÕES:";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(93, 22);
            this.toolStripLabel2.Text = "Usuário Logado:";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // UsuarioLogado
            // 
            this.UsuarioLogado.Name = "UsuarioLogado";
            this.UsuarioLogado.Size = new System.Drawing.Size(86, 22);
            this.UsuarioLogado.Text = "usuarioLogado";
            this.UsuarioLogado.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.UsuarioLogado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(389, 25);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnListarVeiculosN
            // 
            this.btnListarVeiculosN.Location = new System.Drawing.Point(96, 333);
            this.btnListarVeiculosN.Name = "btnListarVeiculosN";
            this.btnListarVeiculosN.Size = new System.Drawing.Size(216, 54);
            this.btnListarVeiculosN.TabIndex = 3;
            this.btnListarVeiculosN.Text = "LISTAR VEÍCULOS";
            this.btnListarVeiculosN.UseVisualStyleBackColor = true;
            this.btnListarVeiculosN.Click += new System.EventHandler(this.btnListarVeiculosN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 54);
            this.button1.TabIndex = 32;
            this.button1.Text = "LISTAR CLIENTES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnListarClientes_Click);
            // 
            // btnListarVaga
            // 
            this.btnListarVaga.Location = new System.Drawing.Point(96, 453);
            this.btnListarVaga.Name = "btnListarVaga";
            this.btnListarVaga.Size = new System.Drawing.Size(216, 54);
            this.btnListarVaga.TabIndex = 33;
            this.btnListarVaga.Text = "LISTAR VEICULOS NA VAGA";
            this.btnListarVaga.UseVisualStyleBackColor = true;
            this.btnListarVaga.Click += new System.EventHandler(this.btnListarVaga_Click);
            // 
            // btnShowPictures
            // 
            this.btnShowPictures.Location = new System.Drawing.Point(96, 93);
            this.btnShowPictures.Name = "btnShowPictures";
            this.btnShowPictures.Size = new System.Drawing.Size(216, 54);
            this.btnShowPictures.TabIndex = 34;
            this.btnShowPictures.Text = "MOSTRAR FOTOS DO ESTACIONAMENTO ";
            this.btnShowPictures.UseVisualStyleBackColor = true;
            this.btnShowPictures.Click += new System.EventHandler(this.btnShowPictures_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(406, 439);
            this.Controls.Add(this.btnShowPictures);
            this.Controls.Add(this.btnListarVaga);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnListarVeiculosN);
            this.Controls.Add(this.btnLoadVaga);
            this.Controls.Add(this.btnVeiculo);
            this.Controls.Add(this.btnLoadCliente);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadCliente;
        private System.Windows.Forms.Button btnVeiculo;
        private System.Windows.Forms.Button btnLoadVaga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel UsuarioLogado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnListarVeiculosN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnListarVaga;
        private System.Windows.Forms.Button btnShowPictures;
    }
}