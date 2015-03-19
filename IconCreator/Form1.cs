using Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IconCreator
{
    public partial class Form1 : Form
    {
        private String selectedFile;
        private SvgDocument orig_svg;

        public Form1()
        {
            InitializeComponent();
        }

        private void onBrowseClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "svg files (*.svg)|*.svg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK) // Test result.
            {
                selectedFile = openFileDialog1.FileName;
                filePathBox.Text = selectedFile;

                orig_svg = SvgDocument.Open(selectedFile);
                Bitmap bmp = orig_svg.Draw();
                if (bmp.Height > svgPreview.MaximumSize.Height || bmp.Width > svgPreview.MaximumSize.Width)
                {
                    double ratio = (double)bmp.Width / (double)bmp.Height;
                    int width, height;
                    if(ratio > 1)
                    {
                        width = svgPreview.MaximumSize.Width;
                        height = (int)((double)svgPreview.MaximumSize.Height / ratio);
                    } else {
                        height = svgPreview.MaximumSize.Height;
                        width = (int)((double)svgPreview.MaximumSize.Width * ratio);
                    }

                    width = (int)((double)width * 0.8);
                    height = (int)((double)height * 0.8);

                    bmp = ResizeImage(bmp, width, height);
                }

                svgPreview.Image = bmp;

            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {


            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void chooseColor(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void scaleValueChanged(object sender, EventArgs e)
        {

        }
    }
}
