
namespace View
{
    partial class FormVaga
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxVagaPatio = new System.Windows.Forms.TextBox();
            this.txtBoxVagaNum = new System.Windows.Forms.TextBox();
            this.txtBoxVagaStatus = new System.Windows.Forms.TextBox();
            this.btnCadastrarVaga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "PÁTIO:";
            this.label5.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "STATUS:";
            this.label3.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "NÚMERO DA VAGA:";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(149, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "VAGA";
            // 
            // txtBoxVagaPatio
            // 
            this.txtBoxVagaPatio.Location = new System.Drawing.Point(119, 84);
            this.txtBoxVagaPatio.Name = "txtBoxVagaPatio";
            this.txtBoxVagaPatio.Size = new System.Drawing.Size(100, 20);
            this.txtBoxVagaPatio.TabIndex = 22;
            // 
            // txtBoxVagaNum
            // 
            this.txtBoxVagaNum.Location = new System.Drawing.Point(119, 117);
            this.txtBoxVagaNum.Name = "txtBoxVagaNum";
            this.txtBoxVagaNum.Size = new System.Drawing.Size(100, 20);
            this.txtBoxVagaNum.TabIndex = 23;
            // 
            // txtBoxVagaStatus
            // 
            this.txtBoxVagaStatus.Location = new System.Drawing.Point(119, 55);
            this.txtBoxVagaStatus.Name = "txtBoxVagaStatus";
            this.txtBoxVagaStatus.Size = new System.Drawing.Size(100, 20);
            this.txtBoxVagaStatus.TabIndex = 21;
            // 
            // btnCadastrarVaga
            // 
            this.btnCadastrarVaga.Location = new System.Drawing.Point(132, 163);
            this.btnCadastrarVaga.Name = "btnCadastrarVaga";
            this.btnCadastrarVaga.Size = new System.Drawing.Size(87, 23);
            this.btnCadastrarVaga.TabIndex = 24;
            this.btnCadastrarVaga.Text = "CADASTRAR";
            this.btnCadastrarVaga.UseVisualStyleBackColor = true;
            this.btnCadastrarVaga.Click += new System.EventHandler(this.btnCadastrarVaga_Click);
            // 
            // FormVaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 198);
            this.Controls.Add(this.btnCadastrarVaga);
            this.Controls.Add(this.txtBoxVagaNum);
            this.Controls.Add(this.txtBoxVagaPatio);
            this.Controls.Add(this.txtBoxVagaStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormVaga";
            this.Text = "FormVaga";
            this.Load += new System.EventHandler(this.FormVaga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxVagaPatio;
        private System.Windows.Forms.TextBox txtBoxVagaNum;
        private System.Windows.Forms.TextBox txtBoxVagaStatus;
        private System.Windows.Forms.Button btnCadastrarVaga;
    }
}