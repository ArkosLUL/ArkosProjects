using MyPhotoshop.Data;
using System;

namespace MyPhotoshop
{
	public class Photo
	{
		public readonly int width;
		public readonly int height;
		private Pixel[,] data;

        public Pixel this[int x, int y]
        {
            get { return data[x, y]; }
            set { /* set the specified index to value here */ }
        }

        public Photo(int width, int height)
        {
            this.width = width;
            this.height = height;
            data = new Pixel[width, height];
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
                    data[x, y] = new Pixel();
                }
        }
	}
}
