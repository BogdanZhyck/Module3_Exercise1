using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Globalization;

namespace HomeWork3_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CustomContactCollection contacts = new CustomContactCollection(CultureInfo.GetCultureInfo("uk-UA"));

			Contact contact1 = new Contact { Name = "Анна", PhoneNumber = "+123456789" };
			Contact contact2 = new Contact { Name = "John", PhoneNumber = "+987654321" };
			Contact contact3 = new Contact { Name = "Олег", PhoneNumber = "+555555555" };
			Contact contact4 = new Contact { Name = "Василь", PhoneNumber = "+111111111" };
			Contact contact5 = new Contact { Name = "12345", PhoneNumber = "+999999999" };

			contacts.AddContact(contact1);
			contacts.AddContact(contact2);
			contacts.AddContact(contact3);
			contacts.AddContact(contact4);
			contacts.AddContact(contact5);

			List<Contact> sortedContacts = contacts.GetContactsByAlphabet();

			Console.WriteLine("Contacts:");

			foreach (var contact in sortedContacts)
			{
				Console.WriteLine($"{contact.Name}: {contact.PhoneNumber}");
			}
		}
	}
}