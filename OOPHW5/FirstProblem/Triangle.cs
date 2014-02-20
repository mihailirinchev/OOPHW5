﻿using System;
using System.Linq;

namespace Shape
{
	internal class Triangle : Shape
	{
		public Triangle(double width, double height) : base(width, height)
		{
		}

		public override double CalculateSurface()
		{
			return this.Height * this.Width / 2;
		}
	}
}