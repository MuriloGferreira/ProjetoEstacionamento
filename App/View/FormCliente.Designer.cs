
namespace View
{
    partial class FormCliente
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
            this.txtBoxClienteCpf = new System.Windows.Forms.TextBox();
            this.txtBoxClienteNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            this.labelProgressCliente = new System.Windows.Forms.Label();
            this.progressBarCliente = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtBoxClienteCpf
            // 
            this.txtBoxClienteCpf.Location = new System.Drawing.Point(76, 58);
            this.txtBoxClienteCpf.Name = "txtBoxClienteCpf";
            this.txtBoxClienteCpf.Size = new System.Drawing.Size(120, 20);
            this.txtBoxClienteCpf.TabIndex = 0;
            this.txtBoxClienteCpf.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBoxClienteNome
            // 
            this.txtBoxClienteNome.Location = new System.Drawing.Point(76, 87);
            this.txtBoxClienteNome.Name = "txtBoxClienteNome";
            this.txtBoxClienteNome.Size = new System.Drawing.Size(120, 20);
            this.txtBoxClienteNome.TabIndex = 1;
            this.txtBoxClienteNome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPF: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(86, 127);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(96, 23);
            this.btnCadastrarCliente.TabIndex = 19;
            this.btnCadastrarCliente.Text = "CADASTRAR";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(71, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "DADOS DO CLIENTE";
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Location = new System.Drawing.Point(86, 156);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(96, 23);
            this.btnAlterarCliente.TabIndex = 29;
            this.btnAlterarCliente.Text = "ALTERAR";
            this.btnAlterarCliente.UseVisualStyleBackColor = true;
            this.btnAlterarCliente.Visible = false;
            this.btnAlterarCliente.Click += new System.EventHandler(this.btnAlterarCliente_Click);
            // 
            // labelProgressCliente
            // 
            this.labelProgressCliente.AutoSize = true;
            this.labelProgressCliente.Location = new System.Drawing.Point(83, 210);
            this.labelProgressCliente.Name = "labelProgressCliente";
            this.labelProgressCliente.Size = new System.Drawing.Size(89, 13);
            this.labelProgressCliente.TabIndex = 38;
            this.labelProgressCliente.Text = "Processando..0%";
            this.labelProgressCliente.Visible = false;
            // 
            // progressBarCliente
            // 
            this.progressBarCliente.Location = new System.Drawing.Point(12, 226);
            this.progressBarCliente.Name = "progressBarCliente";
            this.progressBarCliente.Size = new System.Drawing.Size(237, 18);
            this.progressBarCliente.TabIndex = 37;
            this.progressBarCliente.Visible = false;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 256);
            this.Controls.Add(this.labelProgressCliente);
            this.Controls.Add(this.progressBarCliente);
            this.Controls.Add(this.btnAlterarCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxClienteNome);
            this.Controls.Add(this.txtBoxClienteCpf);
            this.Name = "FormCliente";
            this.Text = "Formulário do cliente: ";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxClienteCpf;
        private System.Windows.Forms.TextBox txtBoxClienteNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlterarCliente;
        private System.Windows.Forms.Label labelProgressCliente;
        private System.Windows.Forms.ProgressBar progressBarCliente;
    }
}