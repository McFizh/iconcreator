using Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
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

        private SvgDocument svg;
        private Bitmap svg_bmp;

        private Color tmp_color;

        private Double icon1ScaleFactor,
                       icon2ScaleFactor;

        /* -----------------------------------------------------------------------------------------------
         * 
         * ----------------------------------------------------------------------------------------------- */
        public Form1()
        {
            InitializeComponent();
            icon1ScaleFactor = 0.5;
            icon2ScaleFactor = 0.5;
            svg = null;
            svg_bmp = null;

            scaleLabel1.Text = "Scale object: " + icon1ScaleFactor.ToString();
            scaleLabel2.Text = "Scale object: " + icon2ScaleFactor.ToString();
        }

        /* -----------------------------------------------------------------------------------------------
         * 
         * ----------------------------------------------------------------------------------------------- */
        private void onBrowseFileClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "svg files (*.svg)|*.svg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFile = openFileDialog1.FileName;
                filePathBox.Text = selectedFile;

                svg = SvgDocument.Open(selectedFile);
                svg_bmp = svg.Draw();

                drawPreview1();
                drawPreview2();
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
            // Basic checks
            if (!wp81_checkbox.Checked && !w81_checkbox.Checked)
            {
                MessageBox.Show("Please select export targets", "Icon Creator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(selectedFile == null || svg == null || svg_bmp == null)
            {
                MessageBox.Show("Invalid SVG file", "Icon Creator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (selectedPath == null || selectedPath.Length == 0)
            {
                MessageBox.Show("Please select export folder", "Icon Creator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //
            if ( !Directory.Exists(selectedPath) )
            {
                MessageBox.Show("Invalid export directory", "Icon Creator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //
            int[,] wp81_icons = new int[4, 2] { { 106, 106 }, { 120, 120 }, { 170, 170 }, {300,300} };
            int[,] wp81_tiles = new int[2,3] { { 1, 360, 360 } , {2, 744, 360 } };

            int[,] w81_icons = new int[4, 2] { {54, 54} , { 90,90 } , { 126, 126 }, {270,270} };
            int[,] w81_tiles = new int[2, 3] { { 1, 558, 558 }, { 2, 558, 270 } };

            //
            if(wp81_checkbox.Checked)
            {
                for (int l1 = 0; l1 < wp81_icons.GetLength(0); l1++)
                {
                    Bitmap icon = createIcon(1, wp81_icons[l1,0], wp81_icons[l1,1], icon1ScaleFactor);
                    icon.Save(selectedPath+"\\wp81-icon-" + wp81_icons[l1, 0].ToString()+"px.png", ImageFormat.Png);
                }

                for (int l1 = 0; l1 < wp81_tiles.GetLength(0); l1++)
                {
                        Bitmap icon = createIcon(2, wp81_tiles[l1, 1], wp81_tiles[l1, 2], icon2ScaleFactor);
                        icon.Save(selectedPath + "\\wp81-tile-" + wp81_tiles[l1, 1].ToString() + "x" + wp81_tiles[l1, 2].ToString() + "px.png", ImageFormat.Png);
                }
            }

            if(w81_checkbox.Checked)
            {
                for (int l1 = 0; l1 < w81_icons.GetLength(0); l1++)
                {
                    Bitmap icon = createIcon(1, w81_icons[l1,0], w81_icons[l1,1], icon1ScaleFactor);
                    icon.Save(selectedPath + "\\w81-icon-" + w81_icons[l1, 0].ToString() + "px.png", ImageFormat.Png);
                }

                for (int l1 = 0; l1 < w81_tiles.GetLength(0); l1++)
                {
                        Bitmap icon = createIcon(2, w81_tiles[l1, 1], w81_tiles[l1, 2], icon2ScaleFactor);
                        icon.Save(selectedPath + "\\w81-tile-" + w81_tiles[l1, 1].ToString() + "x" + w81_tiles[l1, 2].ToString() + "px.png", ImageFormat.Png);
                }
            }

            MessageBox.Show("All done", "Icon Creator", MessageBoxButtons.OK);
        }

        private void changeBgTransparency(object sender, EventArgs e)
        {
            if(transparentBg.Checked)
            {
                selectBgColorBtn.Enabled = false;
                tmp_color = bgColorInd.BackColor;
                bgColorInd.BackColor = Color.FromArgb(0x00, 0xff, 0xff, 0xff);
            } else {
                selectBgColorBtn.Enabled = true;
                bgColorInd.BackColor = tmp_color;
            }
            drawPreview1();
            drawPreview2();
        }

        private void chooseBgColor(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                bgColorInd.BackColor = colorPicker.Color;
                drawPreview1();
                drawPreview2();
            }
        }

        private void chooseTextColor(object sender, EventArgs e)
        {
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                txtColorInd.BackColor = colorPicker.Color;
                drawPreview2();
            }
        }

        private void scale1ValueChanged(object sender, EventArgs e)
        {
            icon1ScaleFactor = (double)scaleFactor1.Value / 100.0;
            drawPreview1();
            scaleLabel1.Text = "Scale object: " + icon1ScaleFactor.ToString();
        }

        private void scale2ValueChanged(object sender, EventArgs e)
        {
            icon2ScaleFactor = (double)scaleFactor2.Value / 100.0;
            drawPreview2();
            scaleLabel2.Text = "Scale object: " + icon2ScaleFactor.ToString();
        }

        private void AppNameChanged(object sender, EventArgs e)
        {
            drawPreview2();
        }

        /* -----------------------------------------------------------------------------------------------
         * 
         * ----------------------------------------------------------------------------------------------- */
        private void quitMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutMenuItemClick(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }

        /* -----------------------------------------------------------------------------------------------
         * 
         * ----------------------------------------------------------------------------------------------- */
        public void drawPreview1()
        {
            svgPreview1.Image = createIcon(1, 360, 360, icon1ScaleFactor);
        }

        public void drawPreview2()
        {
            svgPreview2.Image = createIcon(2, 360, 360, icon2ScaleFactor);
        }

        public Bitmap createIcon(int prevNum, int iconWidth, int iconHeight, double scaleFactor)
        {
            //
            if (svg == null || svg_bmp == null)
                return null;

            //
            Bitmap tmp_bmp = svg_bmp;
            double maxsize = Math.Min(iconHeight, iconWidth);

            //
            if ( tmp_bmp.Height > iconHeight || tmp_bmp.Width > iconWidth )
            {
                double ratio = (double)svg_bmp.Width / (double)svg_bmp.Height;

                double width = ratio <= 1 ? (double)maxsize * ratio : maxsize;
                double height = ratio > 1 ? (double)maxsize / ratio : maxsize;

                tmp_bmp = ResizeImage( svg_bmp, (int)(width * scaleFactor ), (int)(height * scaleFactor ) );
            }

            //
            Bitmap icon = new Bitmap(iconWidth, iconHeight);
            using (var graphics = Graphics.FromImage(icon))
            {
                SolidBrush bgBrush = new SolidBrush(bgColorInd.BackColor);
                Rectangle rect = new Rectangle(0, 0, iconWidth, iconHeight);
                graphics.FillRectangle(bgBrush, rect);

                int xpos = (iconWidth - tmp_bmp.Width) / 2,
                    ypos = (iconHeight - tmp_bmp.Height) / 2;

                graphics.DrawImageUnscaled(tmp_bmp, xpos, ypos);

                if(prevNum == 2)
                {
                    int fontsize= maxsize>360 ? 34 : 22;

                    Font txtFont = new Font("Segoe UI", fontsize);
                    SolidBrush txtColor = new SolidBrush(txtColorInd.BackColor);

                    Size textSize = TextRenderer.MeasureText(appName.Text, txtFont);
                    ypos = iconHeight - textSize.Height-10;

                    PointF txtPlace = new PointF(10.0F, ypos);
                    graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
                    graphics.DrawString(appName.Text, txtFont, txtColor, txtPlace);
                }
            }

            return icon;
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
