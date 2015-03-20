using Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IconCreator
{
    public partial class Form1 : Form
    {
        private String  selectedFile, 
                        selectedPath;
        private SvgDocument orig_svg;
        private Double icon1ScaleFactor,
                       icon2ScaleFactor;

        public Form1()
        {
            InitializeComponent();
            icon1ScaleFactor = 0.5;
            icon2ScaleFactor = 0.5;
            orig_svg = null;
        }

        private void onBrowseFileClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "svg files (*.svg)|*.svg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFile = openFileDialog1.FileName;
                filePathBox.Text = selectedFile;

                orig_svg = SvgDocument.Open(selectedFile);
                drawPreview(1);
                drawPreview(2);
            }
        }

        private void onBrowseFolderClick(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedPath = folderBrowserDialog1.SelectedPath;
                folderBox.Text = selectedPath;
            }
        }

        private void onCreateClick(object sender, EventArgs e)
        {

        }

        private void chooseBgColor(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                bgColorInd.BackColor = colorPicker.Color;
                svgPreview1.BackColor = bgColorInd.BackColor;
                svgPreview2.BackColor = bgColorInd.BackColor;
            }
        }

        private void chooseTextColor(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                txtColorInd.BackColor = colorPicker.Color;
                drawPreview(2);
            }
        }

        private void scale1ValueChanged(object sender, EventArgs e)
        {
            icon1ScaleFactor = (double)scaleFactor1.Value / 100.0;
            drawPreview(1);
        }

        private void scale2ValueChanged(object sender, EventArgs e)
        {
            icon2ScaleFactor = (double)scaleFactor2.Value / 100.0;
            drawPreview(2);
        }

        /* -----------------------------------------------------------------------------------------------
         * 
         * ----------------------------------------------------------------------------------------------- */
        public void drawPreview(int prevNum)
        {
            if (orig_svg == null)
                return;

            int maxWidth, 
                maxHeight;
            double scaleFactor;

            if(prevNum==1)
            {
                maxHeight = svgPreview1.MaximumSize.Height;
                maxWidth = svgPreview1.MaximumSize.Width;
                scaleFactor = icon1ScaleFactor;
            } else {
                maxHeight = svgPreview2.MaximumSize.Height;
                maxWidth = svgPreview2.MaximumSize.Width;
                scaleFactor = icon2ScaleFactor;
            }

            Bitmap bmp = orig_svg.Draw();
            if ( bmp.Height > maxHeight || bmp.Width > maxWidth )
            {
                double ratio = (double)bmp.Width / (double)bmp.Height;
                int width, height;
                if (ratio > 1)
                {
                    width = maxWidth;
                    height = (int)((double)maxHeight / ratio);
                }
                else
                {
                    height = maxHeight;
                    width = (int)((double)maxWidth * ratio);
                }

                width = (int)((double)width * scaleFactor );
                height = (int)((double)height * scaleFactor );

                bmp = ResizeImage(bmp, width, height);
                if (prevNum == 2)
                    drawText(bmp);
            }

            //
            if(prevNum==1)  svgPreview1.Image = bmp;
            else            svgPreview2.Image = bmp;
        }

        public void drawText(Bitmap src)
        {
            using (var graphics = Graphics.FromImage(src))
            {
                Font txtFont = new Font("Segoe UI", 16);
                SolidBrush txtColor = new SolidBrush(txtColorInd.BackColor);
                PointF txtPlace = new PointF(10.0F, 10.0F);

                graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
                graphics.DrawString(appName.Text, txtFont, txtColor, txtPlace);
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

    }
}
