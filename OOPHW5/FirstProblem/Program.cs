using System;
using System.Collections.Generic;
using System.Linq;

namespace Shape
{
	class Program
	{
		static void Main()
		{
			var shapes = new Dictionary<Shape, double>
			{
				{ new Circle(2), 12.566370614359172953850573533118 },
				{ new Circle(8), 201.06192982974676726160917652989 },
				{ new Circle(6), 113.09733552923255658465516179806 },
				{ new Circle(7), 153.9380400258998686846695257807 },
				{ new Rectangle(9,4), 36 },
				{ new Rectangle(7,6), 42 },
				{ new Rectangle(3,7), 21 },
				{ new Rectangle(4,2), 8 },
				{ new Triangle(4, 2), 4 },
				{ new Triangle(6, 5), 15 },
				{ new Triangle(3, 1), 1.5 },
				{ new Triangle(1, 1), 0.5 },
			};

			foreach (var shape in shapes)
			{
				var surface = shape.Key.CalculateSurface();
				if (surface - shape.Value > 0.01)
				{
					Console.WriteLine("Calculated surface was wrong for shape: {0}\nExpected {1}; Actual {2}", shape.Key, shape.Value, surface);
				}
			}
		}
	}
}