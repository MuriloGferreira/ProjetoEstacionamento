
namespace View
{
    partial class FormParkingImages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParkingImages));
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.timerParking = new System.Windows.Forms.Timer(this.components);
            this.imageListParking = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(118, 35);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // timerParking
            // 
            this.timerParking.Enabled = true;
            this.timerParking.Interval = 600;
            this.timerParking.Tick += new System.EventHandler(this.timerParking_Tick);
            // 
            // imageListParking
            // 
            this.imageListParking.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListParking.ImageStream")));
            this.imageListParking.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListParking.Images.SetKeyName(0, "estacionamento3.jpg");
            this.imageListParking.Images.SetKeyName(1, "estacionamento2.jpg");
            this.imageListParking.Images.SetKeyName(2, "estacionamento.jpg");
            // 
            // FormParkingImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 336);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParkingImages";
            this.Text = "FormParkingImages";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Timer timerParking;
        private System.Windows.Forms.ImageList imageListParking;
    }
}