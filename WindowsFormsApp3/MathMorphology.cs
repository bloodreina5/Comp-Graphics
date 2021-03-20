using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Filters_Andrich
{
    class MathMorphology : Filters
    {
        protected int[,] mask;

        protected MathMorphology() { }
        public MathMorphology(int[,] mask)
        {
            this.mask = mask;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            throw new NotImplementedException();
        }
    }
    class Dilation : MathMorphology
    {
        public Dilation()
        {
            this.mask = new int[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
        }
        public Dilation(int[,] mask)
        {
            this.mask = mask;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = mask.GetLength(0) / 2;
            int radiusY = mask.GetLength(1) / 2;

            float resultR = 0;
            float resultG = 0;
            float resultB = 0;

            for (int l = -radiusY; l <= radiusY; ++l)
                for (int k = -radiusX; k <= radiusX; ++k)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    if ((mask[k + radiusX, l + radiusY] == 1) && (neighborColor.R > resultR))
                        resultR = neighborColor.R;
                    if ((mask[k + radiusX, l + radiusY] == 1) && (neighborColor.G > resultG))
                        resultG = neighborColor.G;
                    if ((mask[k + radiusX, l + radiusY] == 1) && (neighborColor.B > resultB))
                        resultB = neighborColor.B;
                }
            return Color.FromArgb(Clamp((int)resultR, 0, 255),
                                  Clamp((int)resultG, 0, 255),
                                  Clamp((int)resultB, 0, 255));
        }
    }
    class Erosion : MathMorphology
    {
        public Erosion()
        {
            this.mask = new int[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
        }
        public Erosion(int[,] mask)
        {
            this.mask = mask;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = mask.GetLength(0) / 2;
            int radiusY = mask.GetLength(1) / 2;

            float resultR = 255;
            float resultG = 255;
            float resultB = 255;

            for (int l = -radiusY; l <= radiusY; ++l)
                for (int k = -radiusX; k <= radiusX; ++k)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    if ((mask[k + radiusX, l + radiusY] == 1) && (neighborColor.R < resultR))
                        resultR = neighborColor.R;
                    if ((mask[k + radiusX, l + radiusY] == 1) && (neighborColor.G < resultG))
                        resultG = neighborColor.G;
                    if ((mask[k + radiusX, l + radiusY] == 1) && (neighborColor.B < resultB))
                        resultB = neighborColor.B;
                }
            return Color.FromArgb(Clamp((int)resultR, 0, 255),
                                  Clamp((int)resultG, 0, 255),
                                  Clamp((int)resultB, 0, 255));

        }
    }
    class Opening : MathMorphology
    {
        public Opening()
        {
            this.mask = new int[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
        }

        public Opening(int[,] mask)
        {
            this.mask = mask;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = sourceImage;
            Filters filter = new Erosion();
            resultImage = filter.processImage(resultImage, worker);
            filter = new Dilation();
            resultImage = filter.processImage(resultImage, worker);
            return resultImage;
        }
    }
    class Closing : MathMorphology
    {
        public Closing()
        {
            this.mask = new int[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
        }

        public Closing(int[,] mask)
        {
            this.mask = mask;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = sourceImage;
            Filters filter = new Dilation();
            resultImage = filter.processImage(resultImage, worker);
            filter = new Erosion();
            resultImage = filter.processImage(resultImage, worker);
            return resultImage;
        }
    }
    class Grad : MathMorphology
    {
        public Grad()
        {
            this.mask = new int[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
        }

        public Grad(int[,] mask)
        {
            this.mask = mask;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = sourceImage;
            Bitmap tmp1 = sourceImage;
            Bitmap tmp2 = sourceImage;
            Filters filter = new Dilation();
            tmp1 = filter.processImage(tmp1, worker);
            filter = new Erosion();
            tmp2 = filter.processImage(tmp2, worker);

            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    int r = Clamp(tmp1.GetPixel(i, j).R - tmp2.GetPixel(i, j).R, 0, 255);
                    int g = Clamp(tmp1.GetPixel(i, j).G - tmp2.GetPixel(i, j).G, 0, 255);
                    int b = Clamp(tmp1.GetPixel(i, j).B - tmp2.GetPixel(i, j).B, 0, 255);

                    resultImage.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            return resultImage;
        }
    }
}

