using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FormParkingImages : Form
    {
        public FormParkingImages()
        {
            InitializeComponent();
        }

        int imgNum = 0;

        private void timerParking_Tick(object sender, EventArgs e)
        {
            pictureBoxParking.Image = imageListParking.Images[imgNum];

            if (imgNum == imageListParking.Images.Count - 1)
            {
                imgNum = 0;
            }
            else
            {
                imgNum++;
            }
        }
    }
}
