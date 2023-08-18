using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_6
{
	public enum State
	{
		Ok,
		Cancel
	}
	public class MessageBox
	{
		public event EventHandler<State> WindowClosed;

		public async void Open()
		{
			Console.WriteLine("A window is open");
			await Task.Delay(3000); // Wait for 3 seconds
			Console.WriteLine("The window was closed by the user");

			Random random = new Random();
			State randomState = (State)random.Next(Enum.GetNames(typeof(State)).Length);

			WindowClosed?.Invoke(this, randomState);
		}
	}
}
