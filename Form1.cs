using System;
using System.Drawing;
using System.Windows.Forms;
using Accord.Imaging.Filters;

namespace dotnet_lab_12
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        private Bitmap currentImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.bmp;*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(ofd.FileName);
                currentImage = (Bitmap)originalImage.Clone();
                pictureBox.Image = currentImage;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                currentImage.Save(sfd.FileName);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (currentImage == null) return;

            Bitmap temp = (Bitmap)originalImage.Clone();

            if (int.TryParse(txtBrightness.Text, out int brightness))
            {
                var filter = new BrightnessCorrection(brightness);
                temp = filter.Apply(temp);
            }

            if (int.TryParse(txtContrast.Text, out int contrast))
            {
                var filter = new ContrastCorrection(contrast);
                temp = filter.Apply(temp);
            }

            if (int.TryParse(txtWidth.Text, out int width) && int.TryParse(txtHeight.Text, out int height))
            {
                var resize = new ResizeBicubic(width, height);
                temp = resize.Apply(temp);
            }

            if (chkSharpen.Checked)
            {
                //var sharpen = new Sharpen();
                //temp = sharpen.Apply(temp);
                int[,] kernel = {
                    { -1,   -1,   -1 },
                    { -1,   9,  -1 },
                    {  -1,  -1,   -1 } 
                };
                IFilter filter = new Convolution(kernel);
                temp = filter.Apply(temp);
            }

            if (chkSmooth.Checked)
            {
                var smooth = new GaussianBlur(5, 7);
                temp = smooth.Apply(temp);
            }

            if (int.TryParse(txtThreshold.Text, out int threshold))
            {
                temp = EnsureGrayscale(temp);
                var th = new Threshold(threshold);
                temp = th.Apply(temp);
            }

            currentImage = temp;
            pictureBox.Image = currentImage;
        }
        private Bitmap EnsureGrayscale(Bitmap bitmap)
        {
            Grayscale grayscaleFilter = new Grayscale(0.3, 0.59, 0.11);
            return grayscaleFilter.Apply(bitmap);
        }
    }
}
