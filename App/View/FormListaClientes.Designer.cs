
namespace View
{
    partial class FormListaClientes
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
            this.GridViewClientes = new System.Windows.Forms.DataGridView();
            this.btnDeleteCliente = new System.Windows.Forms.Button();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewClientes
            // 
            this.GridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cpf,
            this.nome});
            this.GridViewClientes.Location = new System.Drawing.Point(68, 12);
            this.GridViewClientes.Name = "GridViewClientes";
            this.GridViewClientes.Size = new System.Drawing.Size(243, 361);
            this.GridViewClientes.TabIndex = 0;
            this.GridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewClientes_CellContentClick);
            // 
            // btnDeleteCliente
            // 
            this.btnDeleteCliente.Location = new System.Drawing.Point(128, 331);
            this.btnDeleteCliente.Name = "btnDeleteCliente";
            this.btnDeleteCliente.Size = new System.Drawing.Size(128, 29);
            this.btnDeleteCliente.TabIndex = 2;
            this.btnDeleteCliente.Text = "DELETAR CLIENTE";
            this.btnDeleteCliente.UseVisualStyleBackColor = true;
            this.btnDeleteCliente.Click += new System.EventHandler(this.btnDeleteCliente_Click);
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // FormListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.btnDeleteCliente);
            this.Controls.Add(this.GridViewClientes);
            this.Name = "FormListaClientes";
            this.Text = "FormListaClientes";
            this.Load += new System.EventHandler(this.FormListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewClientes;
        private System.Windows.Forms.Button btnDeleteCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
    }
}