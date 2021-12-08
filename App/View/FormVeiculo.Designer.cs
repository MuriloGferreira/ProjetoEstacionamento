
namespace View
{
    partial class FormVeiculo
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
            this.txtBoxVeiculoPlaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxVeiculoModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxVeiculoNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxVeiculoCor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrarVeiculo = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAlterarVeiculo = new System.Windows.Forms.Button();
            this.txtBoxVeiculoCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Placa:";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxVeiculoPlaca
            // 
            this.txtBoxVeiculoPlaca.Location = new System.Drawing.Point(60, 76);
            this.txtBoxVeiculoPlaca.Name = "txtBoxVeiculoPlaca";
            this.txtBoxVeiculoPlaca.Size = new System.Drawing.Size(157, 20);
            this.txtBoxVeiculoPlaca.TabIndex = 6;
            this.txtBoxVeiculoPlaca.UseWaitCursor = true;
            this.txtBoxVeiculoPlaca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Modelo:";
            this.label2.UseWaitCursor = true;
            // 
            // txtBoxVeiculoModelo
            // 
            this.txtBoxVeiculoModelo.Location = new System.Drawing.Point(60, 111);
            this.txtBoxVeiculoModelo.Name = "txtBoxVeiculoModelo";
            this.txtBoxVeiculoModelo.Size = new System.Drawing.Size(157, 20);
            this.txtBoxVeiculoModelo.TabIndex = 10;
            this.txtBoxVeiculoModelo.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cor:";
            this.label3.UseWaitCursor = true;
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // txtBoxVeiculoNome
            // 
            this.txtBoxVeiculoNome.Location = new System.Drawing.Point(60, 45);
            this.txtBoxVeiculoNome.Name = "txtBoxVeiculoNome";
            this.txtBoxVeiculoNome.Size = new System.Drawing.Size(157, 20);
            this.txtBoxVeiculoNome.TabIndex = 12;
            this.txtBoxVeiculoNome.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nome:";
            this.label5.UseWaitCursor = true;
            // 
            // txtBoxVeiculoCor
            // 
            this.txtBoxVeiculoCor.Location = new System.Drawing.Point(60, 146);
            this.txtBoxVeiculoCor.Name = "txtBoxVeiculoCor";
            this.txtBoxVeiculoCor.Size = new System.Drawing.Size(157, 20);
            this.txtBoxVeiculoCor.TabIndex = 14;
            this.txtBoxVeiculoCor.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(74, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "DADOS DO VEÍCULO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCadastrarVeiculo
            // 
            this.btnCadastrarVeiculo.Location = new System.Drawing.Point(77, 236);
            this.btnCadastrarVeiculo.Name = "btnCadastrarVeiculo";
            this.btnCadastrarVeiculo.Size = new System.Drawing.Size(96, 23);
            this.btnCadastrarVeiculo.TabIndex = 18;
            this.btnCadastrarVeiculo.Text = "CADASTRAR";
            this.btnCadastrarVeiculo.UseVisualStyleBackColor = true;
            this.btnCadastrarVeiculo.Click += new System.EventHandler(this.btnCadastrarVeiculo_Click);
            // 
            // btnAlterarVeiculo
            // 
            this.btnAlterarVeiculo.Location = new System.Drawing.Point(77, 265);
            this.btnAlterarVeiculo.Name = "btnAlterarVeiculo";
            this.btnAlterarVeiculo.Size = new System.Drawing.Size(96, 23);
            this.btnAlterarVeiculo.TabIndex = 21;
            this.btnAlterarVeiculo.Text = "ALTERAR";
            this.btnAlterarVeiculo.UseVisualStyleBackColor = true;
            this.btnAlterarVeiculo.Visible = false;
            this.btnAlterarVeiculo.Click += new System.EventHandler(this.btnAlterarVeiculo_Click);
            // 
            // txtBoxVeiculoCliente
            // 
            this.txtBoxVeiculoCliente.Location = new System.Drawing.Point(60, 181);
            this.txtBoxVeiculoCliente.Name = "txtBoxVeiculoCliente";
            this.txtBoxVeiculoCliente.Size = new System.Drawing.Size(157, 20);
            this.txtBoxVeiculoCliente.TabIndex = 23;
            this.txtBoxVeiculoCliente.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cliente:";
            this.label6.UseWaitCursor = true;
            // 
            // FormVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 300);
            this.Controls.Add(this.txtBoxVeiculoCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAlterarVeiculo);
            this.Controls.Add(this.btnCadastrarVeiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxVeiculoCor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxVeiculoNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxVeiculoModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxVeiculoPlaca);
            this.Name = "FormVeiculo";
            this.Text = "Formulário do veiculo:";
            this.Load += new System.EventHandler(this.FormVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxVeiculoPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxVeiculoModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxVeiculoNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxVeiculoCor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrarVeiculo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnAlterarVeiculo;
        private System.Windows.Forms.TextBox txtBoxVeiculoCliente;
        private System.Windows.Forms.Label label6;
    }
}