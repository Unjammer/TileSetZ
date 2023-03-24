using System;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;
using TileSetZ.Properties;

namespace TileSetZ
{
    public partial class Form1 : Form
    {

        Bitmap tile_left = new Bitmap(128, 256);
        Bitmap tile_right = new Bitmap(128, 256);
        Bitmap tile_corner = new Bitmap(128, 256);
        Bitmap tile_floor = new Bitmap(128, 64);

        Bitmap tileLeftMask = new Bitmap(1024, 2048);
        Bitmap tileRightMask = new Bitmap(1024, 2048);
        Bitmap tileCornerMask = new Bitmap(1024, 2048);
        Bitmap tileFloorMask = new Bitmap(1024, 512);

        Bitmap tileTrimMask = new Bitmap(1024, 2048);
        public Form1()
        {
            InitializeComponent();
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
                string filePath = "";

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp, *.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp; *.gif";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;
                        pbx_original.Image = Image.FromFile(filePath);
                        btn_Generate.Enabled = true;

                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btn_Generate.Enabled = false;
            }
        }

        private bool generateTileset()
        {
            try {
            var image1 = new Bitmap(tileLeftMask);
            var image2 = new Bitmap(tileRightMask);
            var image3 = new Bitmap(tileCornerMask);

            var image4 = new Bitmap(tileTrimMask);
            var result = new Bitmap(image1.Width, image1.Height);
            using (var g = Graphics.FromImage(result))
            {
                g.DrawImage(image1, 0, 0);
            }
            using (var g = Graphics.FromImage(result))
            {
                var alphaBrush = new SolidBrush(Color.FromArgb(0, 255, 255, 255));
                g.FillRectangle(alphaBrush, new Rectangle(0, 0, image1.Width, image1.Height));
                g.DrawImage(image2, 0, 0);
            }


                if (!rdb_Roof.Checked)
                {
                    using (var g = Graphics.FromImage(result))
                    {
                        var alphaBrush = new SolidBrush(Color.FromArgb(0, 255, 255, 255));
                        g.FillRectangle(alphaBrush, new Rectangle(0, 0, image1.Width, image1.Height));
                        g.DrawImage(image3, 0, 0);
                    }
                }

            using (var g = Graphics.FromImage(result))
            {
               var alphaBrush = new SolidBrush(Color.FromArgb(0, 255, 255, 255));
               g.FillRectangle(alphaBrush, new Rectangle(0, 0, image1.Width, image1.Height));
               g.DrawImage(image4, 0, 0);
            }


                pbx_main.Image = result;
            return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        private bool tileMasked(Image tileImage, Image maskImage, string side)
        {
            try { 
            var original = new Bitmap(tileImage);
            var mask = new Bitmap(maskImage);
            var result = new Bitmap(mask.Width, mask.Height);
            using (var g = Graphics.FromImage(result))
            {
                g.DrawImage(mask, 0, 0);
            }
            int tileWidth = original.Width;
            int tileHeight = original.Height;
            var final = new Bitmap(mask.Width, mask.Height);
            for (int x = 0; x < mask.Width; x += tileWidth)
            {
                for (int y = 0; y < mask.Height; y += tileHeight)
                {
                    bool tileOverlapsMask = false;
                    for (int tx = 0; tx < tileWidth; tx++)
                    {
                        for (int ty = 0; ty < tileHeight; ty++)
                        {
                            int maskX = x + tx;
                            int maskY = y + ty;

                            if (maskX < mask.Width && maskY < mask.Height && mask.GetPixel(maskX, maskY).A > 0 && mask.GetPixel(maskX, maskY) == System.Drawing.ColorTranslator.FromHtml("#ff0069"))
                            {
                                tileOverlapsMask = true;
                                break;
                            }
                        }
                        if (tileOverlapsMask) break;
                    }
                    if (tileOverlapsMask)
                    {
                        var tile = new Bitmap(tileWidth, tileHeight);
                        for (int tx = 0; tx < tileWidth; tx++)
                        {
                            for (int ty = 0; ty < tileHeight; ty++)
                            {
                                int maskX = x + tx;
                                int maskY = y + ty;

                                if (maskX < mask.Width && maskY < mask.Height && mask.GetPixel(maskX, maskY).A > 0 && mask.GetPixel(maskX, maskY) == System.Drawing.ColorTranslator.FromHtml("#ff0069"))
                                {
                                    tile.SetPixel(tx, ty, original.GetPixel(tx, ty));
                                }
                                else
                                {
                                    tile.SetPixel(tx, ty, Color.Transparent);
                                }
                            }
                        }
                        using (var g = Graphics.FromImage(final))
                        {
                            g.DrawImage(tile, new Rectangle(x, y, tileWidth, tileHeight), new Rectangle(0, 0, tileWidth, tileHeight), GraphicsUnit.Pixel);
                        }
                    }
                }
            }

            if (side == "left")
            {
                tileLeftMask = final;
            } else if (side == "right")
            {
                tileRightMask = final;
            }
            else if (side == "corner")
            {
                tileCornerMask = final;
            } else
            {
                tileFloorMask= final;
            }
            return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool tileThumbnailWall(Image tile)
        {
            try { 
            Image originalImage = tile;
            Bitmap resizedImage = new Bitmap(64, 193);
            using (Graphics resizedGraphics = Graphics.FromImage(resizedImage))
            {
                resizedGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                resizedGraphics.DrawImage(originalImage, new Rectangle(0, 0, 64, 193));
            }
            Bitmap isometricImage = new Bitmap(64, 226);
            for (int y = 0; y < resizedImage.Height; y++)
            {
                for (int x = 0; x < resizedImage.Width; x++)
                {
                    int isoX = x;
                    int isoY = (y - (int)Math.Floor((double)x / 2.0)) + 31;

                    if (isoX >= 0 && isoX < isometricImage.Width && isoY >= 0 && isoY < isometricImage.Height)
                    {
                        Color pixelColor = resizedImage.GetPixel(x, y);
                        int red = Math.Max(Math.Min(pixelColor.R - 31, 255), 0);
                        int green = Math.Max(Math.Min(pixelColor.G - 31, 255), 0);
                        int blue = Math.Max(Math.Min(pixelColor.B - 31, 255), 0);
                        Color newColor = Color.FromArgb(pixelColor.A, red, green, blue);
                        isometricImage.SetPixel(isoX, isoY, newColor);
                    }
                }
            }
            Bitmap resultingImage = new Bitmap(128, 256);
            using (Graphics resultingGraphics = Graphics.FromImage(resultingImage))
            {
                resultingGraphics.DrawImage(isometricImage, new Rectangle(2, 2, 64, 226), new Rectangle(0, 0, 64, 226), GraphicsUnit.Pixel);
            }

            tile_left = resultingImage;
            return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool tileThumbnailWallRight(Image tile)
        {
            try { 
            Image originalImage = tile;
            Bitmap resizedImage = new Bitmap(64, 193);
            using (Graphics resizedGraphics = Graphics.FromImage(resizedImage))
            {
                resizedGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                resizedGraphics.DrawImage(originalImage, new Rectangle(0, 0, 64, 193));
            }
            Bitmap isometricImage = new Bitmap(64, 226);
            for (int y = 0; y < resizedImage.Height; y++)
            {
                for (int x = 0; x < resizedImage.Width; x++)
                {
                    int isoX = x;
                    int isoY = y + (int)Math.Floor((double)x / 2.0);

                    if (isoX >= 0 && isoX < isometricImage.Width && isoY >= 0 && isoY < isometricImage.Height)
                    {
                        Color pixelColor = resizedImage.GetPixel(x, y);
                        isometricImage.SetPixel(isoX, isoY, pixelColor);
                    }
                }
            }
            Bitmap resultingImage = new Bitmap(128, 256);
            using (Graphics resultingGraphics = Graphics.FromImage(resultingImage))
            {
                resultingGraphics.DrawImage(isometricImage, new Rectangle(60, 2, 64, 226), new Rectangle(0, 0, 64, 226), GraphicsUnit.Pixel);
            }

            tile_right = resultingImage;
            return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
        private bool tileThumbnailCorner(Image tileLeft, Image tileRight)
        {
            try { 
            var image1 = new Bitmap(tileRight);
            var image2 = new Bitmap(tileLeft);
            var result = new Bitmap(image1.Width, image1.Height);
            using (var g = Graphics.FromImage(result))
            {
                g.DrawImage(image1, 0, 0);
            }
            using (var g = Graphics.FromImage(result))
            {
                var alphaBrush = new SolidBrush(Color.FromArgb(0, 255, 255, 255));
                g.FillRectangle(alphaBrush, new Rectangle(0, 0, image1.Width, image1.Height));
                g.DrawImage(image2, 0, 0);
            }


            tile_corner = result;
            return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool tileThumbnailFloor(Image tile)
        {
            try
            {
                Bitmap original = (Bitmap)tile;

                Bitmap resized_tile;

                    int newHeight = 128;
                    int newWidth = 128;
                    resized_tile = new Bitmap(original, newWidth, newHeight);
                    original = resized_tile;

                Bitmap isometric = new Bitmap(256, 128);
                Color transparentColor = Color.FromArgb(0, 0, 0, 0);
                using (Graphics g = Graphics.FromImage(isometric))
                {
                    g.Clear(transparentColor);
                }
                for (int y = 0; y < original.Height; y++)
                {
                    for (int x = 0; x < original.Width; x++)
                    {
                        int isoX = x - y + (original.Width);
                        int isoY = (x + y) / 2;
                        if (isoX >= 0 && isoX < isometric.Width && isoY >= 0 && isoY < isometric.Height)
                        {
                            Color pixelColor = original.GetPixel(x, y);
                            isometric.SetPixel(isoX, isoY, pixelColor);
                        }
                    }
                }
                Bitmap resized = new Bitmap(isometric, new Size(128, 64));

                Bitmap resultingImage = new Bitmap(128, 256);
                using (Graphics resultingGraphics = Graphics.FromImage(resultingImage))
                {
                    resultingGraphics.DrawImage(resized, new Rectangle(0, 192, 128, 64), new Rectangle(0, 0, 128, 64), GraphicsUnit.Pixel);
                }


                tile_floor = resultingImage;
                return true;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#505050");
            tileTrimMask = Resources.mask_trim;
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            if (rdb_wall.Checked)
            {
                pbx_main.Visible = false;
                if (tileThumbnailWall(pbx_original.Image))
                {

                    Bitmap mask = Resources.mask_left;
                    tileMasked(tile_left, mask, "left");

                    if (tileThumbnailWallRight(pbx_original.Image))
                    {
                        mask = Resources.mask_right;
                        tileMasked(tile_right, mask, "right");
                        if (tileThumbnailCorner(tile_left, tile_right))
                        {
                            mask = Resources.mask_corner;
                            tileMasked(tile_corner, mask, "corner");
                            if (generateTileset())
                            {
                                pbx_main.Visible = true;
                                saveTilesetToolStripMenuItem.Enabled = true;
                            }
                        }
                    }
                }
            }
            else if (rdb_floor.Checked)
            {
                pbx_main.Visible = false;
                if (tileThumbnailFloor(pbx_original.Image))
                {
                    Bitmap mask = Resources.mask_floor;
                    if (tileMasked(tile_floor, mask, "floor"))
                    {
                        pbx_main.Image = tileFloorMask;
                        pbx_main.Visible = true;
                        saveTilesetToolStripMenuItem.Enabled = true;
                    }
                }
            }
            else if(rdb_Roof.Checked)
            {
                pbx_main.Visible = false;
                if (tileThumbnailWall(pbx_original.Image))
                {

                    Bitmap mask = Resources.mask_left_roof;
                    tileMasked(tile_left, mask, "left");

                    if (tileThumbnailWallRight(pbx_original.Image))
                    {
                        mask = Resources.mask_right_roof;
                        tileMasked(tile_right, mask, "right");
                            if (generateTileset())
                            {
                                pbx_main.Visible = true;
                                saveTilesetToolStripMenuItem.Enabled = true;
                            }
                    }
                }
            }
        }

        private void saveTilesetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbx_main.Image.Save(saveFileDialog.FileName);
                }
            }
        }

        private void btn_Color1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = btn_Color1.BackColor;
        }

        private void btn_Color2_Click(object sender, EventArgs e)
        {
            panel1.BackColor = btn_Color2.BackColor;
        }

        private void btn_Color3_Click(object sender, EventArgs e)
        {
            panel1.BackColor = btn_Color3.BackColor;
        }

        private void btn_Color4_Click(object sender, EventArgs e)
        {
            panel1.BackColor = btn_Color4.BackColor;
        }

        private void btn_TrimColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color newColor = colorDialog.Color;
                ReplaceColor(newColor);
                btn_TrimColor.BackColor = newColor;
            }
        }

        void ReplaceColor( Color newColor)
        {
            Color oldColor = Color.FromArgb(99, 99, 99);

            Bitmap bmp = new Bitmap(Resources.mask_trim);
            if (rdb_Roof.Checked) bmp = new Bitmap(Resources.mask_trim_roof);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    if (pixelColor == oldColor)
                    {
                        bmp.SetPixel(x, y, newColor);
                    }
                }
            }
            tileTrimMask = bmp;
        }

        private void rdb_Roof_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Roof.Checked)
            {
                tileTrimMask = Resources.mask_trim_roof;
            } else
            {
                tileTrimMask = Resources.mask_trim;
            }
        }

        private void btn_Color5_Click(object sender, EventArgs e)
        {
            panel1.BackColor = btn_Color5.BackColor;
        }
    }
}