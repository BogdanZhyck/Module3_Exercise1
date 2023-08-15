namespace HomeWork3_6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MessageBox messageBox = new MessageBox();
			messageBox.WindowClosed += MessageBox_WindowClosed;

			messageBox.Open();

			Console.ReadLine();
		}

		private static void MessageBox_WindowClosed(object sender, State state)
		{
			if (state == State.Ok)
			{
				Console.WriteLine("The operation has been confirmed");
			}
			else if (state == State.Cancel)
			{
				Console.WriteLine("The operation was rejected");
			}
		}
	}
}