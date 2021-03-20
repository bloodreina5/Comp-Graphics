using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace Filters_Andrich
{
    class Median : Filters
    {
        protected int r;

        public Median(int _r)
        {
            r = _r;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = r;
            int radiusY = r;

            List<int> RR = new List<int>();
            List<int> GG = new List<int>();
            List<int> BB = new List<int>();

            for (int l = -radiusY; l <= radiusY; ++l)
                for (int k = -radiusX; k <= radiusX; ++k)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    RR.Add(sourceImage.GetPixel(idX, idY).R);
                    GG.Add(sourceImage.GetPixel(idX, idY).G);
                    BB.Add(sourceImage.GetPixel(idX, idY).B);
                }
            RR.Sort();
            GG.Sort();
            BB.Sort();

            return Color.FromArgb(RR[RR.Count / 2], GG[GG.Count / 2], BB[BB.Count / 2]);
        }
    }
}
