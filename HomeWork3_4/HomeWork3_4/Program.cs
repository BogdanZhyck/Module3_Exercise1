namespace HomeWork3_4
{
	public delegate int CalculateDelegate(int a, int b);

	class Program
	{
		static void Main(string[] args)
		{
			Calculator calculator = new Calculator();
			calculator.SubscribeToEvent();

			try
			{
				int sum = calculator.CalculateSumOfCalculations(calculator.CalculateMethod1, 5, 3);
				Console.WriteLine("Sum of calculation results: " + sum);
			}
			catch (Exception ex)
			{
				Console.WriteLine("An error occurred: " + ex.Message);
			}

			ContactListProcessor contactListProcessor = new ContactListProcessor();
			contactListProcessor.ProcessContacts();
		}
	}
}