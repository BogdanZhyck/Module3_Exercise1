using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_4
{
	internal class Calculator
	{
		public event CalculateDelegate CalculationEvent;

		public void SubscribeToEvent()
		{
			CalculationEvent += CalculateMethod1;
			CalculationEvent += CalculateMethod2;
		}

		public int CalculateMethod1(int a, int b)
		{
			return a + b;
		}

		public int CalculateMethod2(int a, int b)
		{
			return a * b;
		}

		public int CalculateSumOfCalculations(CalculateDelegate calculationMethod, int a, int b)
		{
			int sum = 0;
			try
			{
				sum = ExecuteCalculation(calculationMethod, a, b);
			}
			catch (Exception ex)
			{
				Console.WriteLine("An error occurred during calculation: " + ex.Message);
			}
			return sum;
		}

		private int ExecuteCalculation(CalculateDelegate calculationMethod, int a, int b)
		{
			if (CalculationEvent != null)
			{
				return calculationMethod(a, b);
			}
			return 0;
		}
	}
}

