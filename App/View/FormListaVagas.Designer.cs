
namespace View
{
    partial class FormListaVagas
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
            this.GridVeiculos = new System.Windows.Forms.DataGridView();
            this.numerovaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomevaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patiovaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusvaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // GridVeiculos
            // 
            this.GridVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numerovaga,
            this.nomevaga,
            this.patiovaga,
            this.statusvaga});
            this.GridVeiculos.Location = new System.Drawing.Point(57, 34);
            this.GridVeiculos.Name = "GridVeiculos";
            this.GridVeiculos.Size = new System.Drawing.Size(643, 383);
            this.GridVeiculos.TabIndex = 2;
            // 
            // numerovaga
            // 
            this.numerovaga.HeaderText = "Nome do cliente";
            this.numerovaga.Name = "numerovaga";
            this.numerovaga.Width = 150;
            // 
            // nomevaga
            // 
            this.nomevaga.HeaderText = "Numero da vaga";
            this.nomevaga.Name = "nomevaga";
            this.nomevaga.Width = 150;
            // 
            // patiovaga
            // 
            this.patiovaga.HeaderText = "Patio";
            this.patiovaga.Name = "patiovaga";
            this.patiovaga.Width = 150;
            // 
            // statusvaga
            // 
            this.statusvaga.HeaderText = "Status";
            this.statusvaga.Name = "statusvaga";
            this.statusvaga.Width = 150;
            // 
            // FormListaVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.GridVeiculos);
            this.Name = "FormListaVagas";
            this.Text = "FormListaVagas";
            ((System.ComponentModel.ISupportInitialize)(this.GridVeiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridVeiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerovaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomevaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn patiovaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusvaga;
    }
}