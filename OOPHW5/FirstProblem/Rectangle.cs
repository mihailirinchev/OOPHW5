using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
	internal class Rectangle : Shape
	{
		public Rectangle(double width, double height) : base(width, height) 
		{
		}

		public override double CalculateSurface()
		{
			return this.Height * this.Width;
		}
	}
}
