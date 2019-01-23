using MyPhotoshop.Data;
using System;
using System.Drawing;

namespace MyPhotoshop
{
	public static class Convertors
	{
		public static Photo Bitmap2Photo(Bitmap bmp)
		{
			var photo=new Photo(bmp.Width, bmp.Height);
			for (int x=0;x<bmp.Width;x++)
				for (int y=0;y<bmp.Height;y++)
				{
				var pixel=bmp.GetPixel (x,y);
				photo[x,y].R=(double)pixel.R/255;
				photo[x,y].G=(double)pixel.G/255;
				photo[x,y].B=(double)pixel.B/255;
				}
			return photo;
		}
		
		
		
		public static Bitmap Photo2Bitmap(Photo photo)
		{
			var bmp=new Bitmap(photo.width,photo.height);
			for (int x=0;x<bmp.Width;x++)
				for (int y=0;y<bmp.Height;y++)
					bmp.SetPixel(x,y,Color.FromArgb (
						Pixel.ToChannel (photo[x,y].R),
                        Pixel.ToChannel (photo[x,y].G),
                        Pixel.ToChannel (photo[x,y].B) ));
					       		
			return bmp;
		}
	}
}

