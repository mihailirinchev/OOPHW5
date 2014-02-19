using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
	class Program
	{
		static void Main()
		{
			var circles = new[]
			{
				new Circle(2),
				new Circle(8),
				new Circle(6),
				new Circle(7)
			};
			var rectangles = new[]
			{
				new Rectangle(9,4),
				new Rectangle(7,6),
				new Rectangle(3,7),
				new Rectangle(4,2)
			};
			var triangles = new[]
			{
				new Triangle(4, 2),
				new Triangle(6, 5),
				new Triangle(3, 1),
				new Triangle(1, 1)
			};

			Console.WriteLine(string.Format("Area of Circle with radius = {0} is : {1}", circles[1].Height, circles[1].CalculateSurface()));
			Console.WriteLine(string.Format("Area of Rectangle with height = {0} and width = {1} is : {2}", rectangles[2].Height, rectangles[2].Width, rectangles[2].CalculateSurface()));
			Console.WriteLine(string.Format("Area of Triangle with height = {0} and width = {1} is : {2}", triangles[2].Height, triangles[2].Width, triangles[2].CalculateSurface()));
		}
	}
}
