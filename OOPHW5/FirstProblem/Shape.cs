using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
	internal abstract class Shape
	{
		private double width = 1;

		private double height = 1;

		public double Width 
		{
			get
			{
				return this.width;
			}
			set
			{
				if (this.width <= 0)
				{
					throw new ArgumentOutOfRangeException("Width must be positive number");
				}

				this.width = value;
			}
		}

		public double Height
		{
			get
			{
				return this.height;
			}
			set
			{
				if (this.height <= 0)
				{
					throw new ArgumentOutOfRangeException("Height must be positive number");
				}

				this.height = value;
			}
		}

		public Shape(double width, double height)
		{
			this.Width = width;
			this.Height = height;
		}

		public abstract double CalculateSurface();
	}
}
