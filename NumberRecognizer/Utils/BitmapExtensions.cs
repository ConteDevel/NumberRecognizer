using System.Drawing;

namespace NumberRecognizer.Utils
{
    public static class BitmapExtensions
    {
        public static void MakeGrayscale(this Bitmap bmp)
        {
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    var c = bmp.GetPixel(x, y);
                    int rgb = (int)((c.R * .3) + (c.G * .59) + (c.B * .11));
                    bmp.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            }
        }

        public static Bitmap GetTile(this Bitmap img, Rectangle src, int width, int height)
        {
            var bmp = new Bitmap(width, height);
            var dest = new Rectangle(0, 0, width, height);

            using (var g = Graphics.FromImage(bmp))
            {
                g.DrawImage(img, dest, src, GraphicsUnit.Pixel);
            }

            return bmp;
        }
    }
}
