using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace Filters_Andrich
{
    abstract class Filters
    {

        protected abstract Color calculateNewPixelColor(Bitmap sourceImage, int x, int y);
        virtual public Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
                }
            }
            return resultImage;
        }
        public int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }
        
        


    }
    class InvertFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(255 - sourceColor.R,
                                             255 - sourceColor.G,
                                             255 - sourceColor.B);
            return resultColor;
        }

    }
    class GrayScaleFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            
             Color pixelColor = sourceImage.GetPixel(x, y);
            int grayScale = (int)((pixelColor.R * .299) + (pixelColor.G * .587) + (pixelColor.B * .114));
            return Color.FromArgb(pixelColor.A, grayScale, grayScale, grayScale);

        }
    }

    class MatrixFilter : Filters
    {
        protected float[,] kernel = null;
        protected MatrixFilter() { }
        public MatrixFilter(float[,] kernel)
        {
            this.kernel = kernel;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;

            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    resultR += neighborColor.R * kernel[k + radiusX, l + radiusY];
                    resultG += neighborColor.G * kernel[k + radiusX, l + radiusY];
                    resultB += neighborColor.B * kernel[k + radiusX, l + radiusY];
                }
            return Color.FromArgb(
                Clamp((int)resultR, 0, 255),
                Clamp((int)resultG, 0, 255),
                Clamp((int)resultB, 0, 255)
                );
        }
       
    }
    class BlurFilter : MatrixFilter
    {
        public BlurFilter()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            for (int i = 0; i < sizeX; i++)
                for (int j = 0; j < sizeY; j++)
                    kernel[i, j] = 1.0f / (float)(sizeX * sizeY);
        }
    }
    class GaussianFilter : MatrixFilter
    {
        public void createGaussianKernel(int radius, float sigma)
        {
            int size = 2 * radius + 1;
            kernel = new float[size, size];
            float norm = 0;
            for(int i = -radius;i <= radius; i++ )
                for(int j= -radius;j<=radius;j++)
                {
                    kernel[i + radius, j + radius] = (float)(Math.Exp(-(i * i + j * j) / (2 * sigma * sigma)));
                    norm += kernel[i + radius, j + radius];
                }
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    kernel[i, j] /= norm;
        }
        public GaussianFilter()
        {
            createGaussianKernel(3, 2);
        }
    }
    class SharpnessFilter : MatrixFilter
    {
        public SharpnessFilter()
        {
            kernel = new float[3, 3] { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };
        }
    }
    class PruitFilter : MatrixFilter
    {
        public PruitFilter()
        {
            kernel = new float[3, 3] { { -1, -1, -1 }, { 0, 0, 0 }, { 1, 1, 1 } };
        }

    }
    class CorrectingColorFilter : Filters
    {
        private Color click_color;
        public CorrectingColorFilter(Color _color)
        {
            click_color = _color;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y); //src
            int R, G, B;

            if (click_color.R == 0)
                R = sourceColor.R;
            else
                R = sourceColor.R * (255 / click_color.R);

            if (click_color.G == 0)
                G = sourceColor.G;
            else
                G = sourceColor.G * (255 / click_color.G);

            if (click_color.B == 0)
                B = sourceColor.B;
            else
                B = sourceColor.B * (255 / click_color.B);

            Color resultColor = Color.FromArgb(Clamp(R, 0, 255), Clamp(G, 0, 255), Clamp(B, 0, 255));
            return resultColor;
        }
    }

        class StretchFilter : Filters
    {
        int Rmax = 0;
        int Gmax = 0;
        int Bmax = 0;

        int Rmin = 256;
        int Gmin = 256;
        int Bmin = 256;
         public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int i = 0; i < sourceImage.Width; ++i)
                for (int j = 0; j < sourceImage.Height; ++j)
                {
                    Color sourceColor = sourceImage.GetPixel(i, j);
                    if (sourceColor.R > Rmax)
                        Rmax = sourceColor.R;
                    if (sourceColor.G > Gmax)
                        Gmax = sourceColor.G;
                    if (sourceColor.B > Bmax)
                        Bmax = sourceColor.B;

                    if (sourceColor.R < Rmin)
                        Rmin = sourceColor.R;
                    if (sourceColor.G < Gmin)
                        Gmin = sourceColor.G;
                    if (sourceColor.B < Bmin)
                        Bmin = sourceColor.B;
                }
            resultImage = base.processImage(sourceImage, worker);
            return resultImage;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);

            Color resultColor = Color.FromArgb(Clamp((sourceColor.R - Rmin) * 255 / (Rmax - Rmin), 0, 255),
                                               Clamp((sourceColor.G - Gmin) * 255 / (Gmax - Gmin), 0, 255),
                                               Clamp((sourceColor.B - Bmin) * 255 / (Bmax - Bmin), 0, 255));

            return resultColor;
        }
    }
    class WaveFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color resultColor = new Color();

            resultColor = sourceImage.GetPixel(Clamp((int)(x + 20 * Math.Sin(2 * Math.PI * x / 30)), 0, sourceImage.Width - 1), y);

            return resultColor;
        }
    }
    class ShiftFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int k = 50;
            Color resultColor = new Color();
            if (x + k < sourceImage.Width)
                resultColor = sourceImage.GetPixel(x + k, y);
            else
            {
                resultColor = Color.FromArgb(0, 0, 0);
            }

            return resultColor;
        }
    }
}


