
namespace View
{
    partial class FormPatio
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
            this.label4 = new System.Windows.Forms.Label();
            this.descPatio = new System.Windows.Forms.Label();
            this.taxaHora = new System.Windows.Forms.Label();
            this.txtBoxPatioTaxaHora = new System.Windows.Forms.TextBox();
            this.txtBoxPatioDesc = new System.Windows.Forms.TextBox();
            this.btnPatioValorTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(125, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "NITERÓI PARKING:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // descPatio
            // 
            this.descPatio.AutoSize = true;
            this.descPatio.Location = new System.Drawing.Point(30, 77);
            this.descPatio.Name = "descPatio";
            this.descPatio.Size = new System.Drawing.Size(72, 13);
            this.descPatio.TabIndex = 25;
            this.descPatio.Text = "DESCRIÇÃO:";
            this.descPatio.UseWaitCursor = true;
            this.descPatio.Click += new System.EventHandler(this.label3_Click);
            // 
            // taxaHora
            // 
            this.taxaHora.AutoSize = true;
            this.taxaHora.Location = new System.Drawing.Point(7, 120);
            this.taxaHora.Name = "taxaHora";
            this.taxaHora.Size = new System.Drawing.Size(98, 13);
            this.taxaHora.TabIndex = 26;
            this.taxaHora.Text = "TAXA POR HORA:";
            this.taxaHora.UseWaitCursor = true;
            this.taxaHora.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtBoxPatioTaxaHora
            // 
            this.txtBoxPatioTaxaHora.Location = new System.Drawing.Point(111, 117);
            this.txtBoxPatioTaxaHora.Name = "txtBoxPatioTaxaHora";
            this.txtBoxPatioTaxaHora.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPatioTaxaHora.TabIndex = 29;
            this.txtBoxPatioTaxaHora.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBoxPatioDesc
            // 
            this.txtBoxPatioDesc.Location = new System.Drawing.Point(111, 74);
            this.txtBoxPatioDesc.Name = "txtBoxPatioDesc";
            this.txtBoxPatioDesc.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPatioDesc.TabIndex = 28;
            this.txtBoxPatioDesc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPatioValorTotal
            // 
            this.btnPatioValorTotal.Location = new System.Drawing.Point(111, 163);
            this.btnPatioValorTotal.Name = "btnPatioValorTotal";
            this.btnPatioValorTotal.Size = new System.Drawing.Size(96, 23);
            this.btnPatioValorTotal.TabIndex = 30;
            this.btnPatioValorTotal.Text = "VALOR TOTAL";
            this.btnPatioValorTotal.UseVisualStyleBackColor = true;
            this.btnPatioValorTotal.Click += new System.EventHandler(this.btnPatioValorTotal_Click);
            // 
            // FormPatio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 198);
            this.Controls.Add(this.btnPatioValorTotal);
            this.Controls.Add(this.txtBoxPatioTaxaHora);
            this.Controls.Add(this.txtBoxPatioDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.taxaHora);
            this.Controls.Add(this.descPatio);
            this.Name = "FormPatio";
            this.Text = "Formulário do Pátio:";
            this.Load += new System.EventHandler(this.FormPatio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label descPatio;
        private System.Windows.Forms.Label taxaHora;
        private System.Windows.Forms.TextBox txtBoxPatioTaxaHora;
        private System.Windows.Forms.TextBox txtBoxPatioDesc;
        private System.Windows.Forms.Button btnPatioValorTotal;
    }
}