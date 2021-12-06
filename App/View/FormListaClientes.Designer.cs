
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
            this.GridClientes = new System.Windows.Forms.DataGridView();
            this.ColunaNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaCpfCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // GridClientes
            // 
            this.GridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaNomeCliente,
            this.ColunaCpfCliente});
            this.GridClientes.Location = new System.Drawing.Point(130, 34);
            this.GridClientes.Name = "GridClientes";
            this.GridClientes.Size = new System.Drawing.Size(540, 383);
            this.GridClientes.TabIndex = 2;
            this.GridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVeiculos_CellContentClick);
            // 
            // ColunaNomeCliente
            // 
            this.ColunaNomeCliente.FillWeight = 200F;
            this.ColunaNomeCliente.HeaderText = "Nome";
            this.ColunaNomeCliente.Name = "ColunaNomeCliente";
            this.ColunaNomeCliente.Width = 200;
            // 
            // ColunaCpfCliente
            // 
            this.ColunaCpfCliente.HeaderText = "CPF";
            this.ColunaCpfCliente.Name = "ColunaCpfCliente";
            this.ColunaCpfCliente.Width = 150;
            // 
            // FormListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridClientes);
            this.Name = "FormListaClientes";
            this.Text = "FormListaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaCpfCliente;
    }
}