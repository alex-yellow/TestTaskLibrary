using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskLibrary
{
    public abstract class Figure
    {
		public string Name { get; set; }

		public Figure(string name)
		{
			Name = name;
		}

		public abstract double Square();

		public override string ToString()
		{
			return $"Текущий тип фигуры: " + Name;
		}
	}
}
