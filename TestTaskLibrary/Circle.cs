using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskLibrary
{
    class Circle : Figure
    {
		public double Radius { get; set; }

		public Circle(string name, double radius) : base(name)
		{
			Radius = radius;
		}

		public override double Square()
		{
			return Math.PI * Math.Pow(Radius, 2);
		}
	}
}
