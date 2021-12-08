
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
            this.GridVagas = new System.Windows.Forms.DataGridView();
            this.numerovaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomevaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patiovaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusvaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeletarVaga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridVagas)).BeginInit();
            this.SuspendLayout();
            // 
            // GridVagas
            // 
            this.GridVagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVagas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numerovaga,
            this.nomevaga,
            this.patiovaga,
            this.statusvaga});
            this.GridVagas.Location = new System.Drawing.Point(57, 34);
            this.GridVagas.Name = "GridVagas";
            this.GridVagas.Size = new System.Drawing.Size(643, 377);
            this.GridVagas.TabIndex = 2;
            this.GridVagas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVeiculos_CellContentClick);
            this.GridVagas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVagas_CellContentDoubleClick);
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
            // btnDeletarVaga
            // 
            this.btnDeletarVaga.Location = new System.Drawing.Point(557, 417);
            this.btnDeletarVaga.Name = "btnDeletarVaga";
            this.btnDeletarVaga.Size = new System.Drawing.Size(143, 37);
            this.btnDeletarVaga.TabIndex = 3;
            this.btnDeletarVaga.Text = "Liberar vaga";
            this.btnDeletarVaga.UseVisualStyleBackColor = true;
            this.btnDeletarVaga.Click += new System.EventHandler(this.btnDeletarVaga_Click);
            // 
            // FormListaVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 458);
            this.Controls.Add(this.btnDeletarVaga);
            this.Controls.Add(this.GridVagas);
            this.Name = "FormListaVagas";
            this.Text = "FormListaVagas";
            this.Load += new System.EventHandler(this.FormListaVagas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridVagas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridVagas;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerovaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomevaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn patiovaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusvaga;
        private System.Windows.Forms.Button btnDeletarVaga;
    }
}