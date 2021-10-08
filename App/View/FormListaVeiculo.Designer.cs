
namespace View
{
    partial class FormListaVeiculo
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
            this.btnDeletarVeículo = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.GridVeiculos = new System.Windows.Forms.DataGridView();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltarPrincipal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeletarVeículo
            // 
            this.btnDeletarVeículo.Location = new System.Drawing.Point(478, 401);
            this.btnDeletarVeículo.Name = "btnDeletarVeículo";
            this.btnDeletarVeículo.Size = new System.Drawing.Size(143, 37);
            this.btnDeletarVeículo.TabIndex = 0;
            this.btnDeletarVeículo.Text = "Deletar dados do veículo";
            this.btnDeletarVeículo.UseVisualStyleBackColor = true;
            this.btnDeletarVeículo.Click += new System.EventHandler(this.btnDeletarVeículo_Click_1);
            // 
            // GridVeiculos
            // 
            this.GridVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Placa,
            this.Modelo,
            this.Cor});
            this.GridVeiculos.Location = new System.Drawing.Point(81, 12);
            this.GridVeiculos.Name = "GridVeiculos";
            this.GridVeiculos.Size = new System.Drawing.Size(540, 383);
            this.GridVeiculos.TabIndex = 1;
            this.GridVeiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVeiculos_CellContentClick);
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.Width = 200;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.Width = 150;
            // 
            // Cor
            // 
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            this.Cor.Width = 150;
            // 
            // btnVoltarPrincipal
            // 
            this.btnVoltarPrincipal.Location = new System.Drawing.Point(300, 401);
            this.btnVoltarPrincipal.Name = "btnVoltarPrincipal";
            this.btnVoltarPrincipal.Size = new System.Drawing.Size(152, 37);
            this.btnVoltarPrincipal.TabIndex = 3;
            this.btnVoltarPrincipal.Text = "Voltar menu principal";
            this.btnVoltarPrincipal.UseVisualStyleBackColor = true;
            this.btnVoltarPrincipal.Click += new System.EventHandler(this.btnVoltarPrincipal_Click);
            // 
            // FormListaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.btnVoltarPrincipal);
            this.Controls.Add(this.GridVeiculos);
            this.Controls.Add(this.btnDeletarVeículo);
            this.Name = "FormListaVeiculo";
            this.Text = "FormListaVeiculo";
            this.Load += new System.EventHandler(this.FormListaVeiculo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GridVeiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeletarVeículo;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.DataGridView GridVeiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.Button btnVoltarPrincipal;
    }
}