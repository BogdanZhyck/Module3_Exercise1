namespace HomeWork3_3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Class1 class1 = new Class1();
			Class2 class2 = new Class2();

			Class1.ShowDelegate showDelegate = new Class1.ShowDelegate(class1.Show);
			Func<int, int, int> multiplyDelegate = class1.Multiply;

			Func<int, bool> resultDelegate = class2.Calc(multiplyDelegate, 10, 2);

			int inputNumber = 2; 
			bool result = resultDelegate(inputNumber);

			class1.Show(result);
		}
	}
}