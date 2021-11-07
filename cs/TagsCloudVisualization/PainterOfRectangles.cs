﻿using System.Collections.Generic;
using System.Drawing;

namespace TagsCloudVisualization
{
    public class PainterOfRectangles
    {
        private Size pictSize;
        public PainterOfRectangles(Size sizeOfPicture)
        {
            pictSize = sizeOfPicture;
        }

        public void CreateImageOfRectangles(List<Rectangle> rectangles,string filename = "rectangles")
        {
            Bitmap bmp = new Bitmap(pictSize.Width,pictSize.Height);

            Graphics graphics = Graphics.FromImage(bmp);

            foreach (var rectangle in rectangles)
            {
                graphics.DrawRectangle(new Pen(Color.Blue, .5f), rectangle);
            }

            bmp.Save(filename);

            bmp.Dispose();
            graphics.Dispose();
        }
    }
}
