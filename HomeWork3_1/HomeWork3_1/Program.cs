using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HomeWork3_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CustomCollection<int> collection = new CustomCollection<int>();

			collection.Add(5);
			collection.Add(2);
			collection.Add(8);

			Console.WriteLine("Collection elements:");
			foreach (int item in collection)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine($"Count: {collection.Count}");

			collection.Sort();
			Console.WriteLine("Collection after sorting:");
			foreach (int item in collection)
			{
				Console.WriteLine(item);
			}

			collection.SetDefaultAt(1, 0);
			Console.WriteLine("Collection after setting default at index 1:");
			foreach (int item in collection)
			{
				Console.WriteLine(item);
			}
		}
	}
}