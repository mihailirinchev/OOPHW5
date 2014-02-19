using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
	internal class Circle : Shape
	{
		public Circle(double width)	: base(width, width) 
		{
		}

		public override double CalculateSurface()
		{
			return Math.PI * this.Height * this.Width;
		}
	}
}
