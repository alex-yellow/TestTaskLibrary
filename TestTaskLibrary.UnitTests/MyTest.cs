using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestTaskLibrary.UnitTests
{
	[TestClass]
	public class TriangleTests
	{
		[TestMethod]
		public void isStraightTriangle_NotStraight_ReturnFalse()
		{
			var triangle = new Triangle("Треугольник", 2, 3, 4);

			var result = triangle.isStraightTriangle();

			Assert.IsFalse(result);
		}

		[TestMethod]
		public void Square_3and4and5_Return6()
		{
			
			var triangle = new Triangle("Треугольник", 3, 4, 5);
			double expected = 6;

			var result = triangle.Square();

			Assert.AreEqual(expected, result);
		}
	}

	[TestClass]
	public class CircleTest
	{
		[TestMethod]
		public void Square_5_Return78_5()
		{
			var circle = new Circle("Круг", 5);
			double expected = 78.5;

			var result = circle.Square();

			Assert.AreEqual(expected, result);
		}
	}
}
