using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_3
{
	internal class Class1
	{
		public delegate void ShowDelegate(bool value);

		public void Show(bool value)
		{
			Console.WriteLine("Show method result: " + value);
		}

		public int Multiply(int a, int b)
		{
			return a * b;
		}
	}
}
