using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskLibrary
{
    public class Triangle:Figure
    {
		public double SideA { get; set; }
		public double SideB { get; set; }
		public double SideC { get; set; }

		public Triangle(string name, double a, double b, double c) : base(name)
		{
			if (Exists(a, b, c))
			{
				SideA = a;
				SideB = b;
				SideC = c;
			}
		}

		public override double Square()
		{
			var p = (SideA + SideB + SideC) / 2;
			var square = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
			return square;
		}

		public bool Exists(double a, double b, double c)
		{
			if (a < 0 || b < 0 || c < 0)
			{
				throw new TriangleExcept("Ошибка: одна или несколько сторон меньше 0");
			}

			if (a > (b + c) || b > (a + c) || c > (a + b))
			{
				throw new TriangleExcept("Ошибка: одна сторона больше суммы двух других");
			}

			return true;
		}

		public bool StraightTriangle()
		{
			bool Straight = (SideA == Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideC, 2))
							   || SideB == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2))
							   || SideC == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2)));

			return Straight;
		}
	}
}
