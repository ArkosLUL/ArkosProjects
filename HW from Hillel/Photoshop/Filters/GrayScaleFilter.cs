using MyPhotoshop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop.Filters
{
    class GrayScaleFilter : IFilter
    {
        public ParameterInfo[] GetParameters()
        {
            return new ParameterInfo[0];
        }

        public override string ToString()
        {
            return "серые будни";
        }

        public Photo Process(Photo original, double[] parameters)
        {
            var result = new Photo(original.width, original.height);
            for (int x = 0; x < result.width; x++)
                for (int y = 0; y < result.height; y++)
                {
                    var lightnes = original[x, y].R + original[x, y].G + original[x, y].B;
                    lightnes /= 3;
                    result[x, y].R = lightnes;
                    result[x, y].G = lightnes;
                    result[x, y].B = lightnes;
                }
            return result;
        }
    }
}
