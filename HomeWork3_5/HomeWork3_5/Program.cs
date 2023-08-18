using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork3_5
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			await CreateHelloAndWorldFilesAsync();

			string result = await ConcatenateTextAsync();
			Console.WriteLine(result);
		}

		static async Task CreateHelloAndWorldFilesAsync()
		{
			await File.WriteAllTextAsync("Hello.txt", "Hello");
			await File.WriteAllTextAsync("World.txt", "World");
		}

		static async Task<string> ReadFromFileAsync(string filename)
		{
			using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
			using (StreamReader reader = new StreamReader(fs))
			{
				return await reader.ReadToEndAsync();
			}
		}

		static async Task<string> ConcatenateTextAsync()
		{
			Task<string> helloTask = ReadFromFileAsync("Hello.txt");
			Task<string> worldTask = ReadFromFileAsync("World.txt");

			string helloText = await helloTask;
			string worldText = await worldTask;

			return helloText + " " + worldText;
		}

	}
}