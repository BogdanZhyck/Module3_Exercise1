using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_3
{
	internal class Class2
	{
		public Func<int, bool> Calc(Func<int, int, int> multiplyDelegate, int num1, int num2)
		{
			int result = multiplyDelegate(num1, num2);

			bool Result(int number)
			{
				int remainder = result % number;
				return remainder == 0;
			}

			return Result;
		}

		public bool Result(int number, Func<int, int, int> multiplyDelegate, int num1, int num2)
		{
			int result = multiplyDelegate(num1, num2);
			int remainder = result % number;
			return remainder == 0;
		}
	}
}
