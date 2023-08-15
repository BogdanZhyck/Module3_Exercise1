using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_4
{
	class ContactListProcessor
	{
		public void ProcessContacts()
		{
			List<Contact> contactList = new List<Contact>
				{
					 new Contact("Alice", "alice@example.com"),
					 new Contact("Bob", "bob@example.com"),
					 new Contact("Charlie", "charlie@example.com"),
					 new Contact("David", "david@example.com")
				};

			// FirstOrDefault
			Contact firstContact = contactList.FirstOrDefault();
			Console.WriteLine("First contact: " + firstContact.Name);

			// Where
			IEnumerable<Contact> filteredContacts = contactList.Where(contact => contact.Name.Contains("a"));
			Console.WriteLine("Filtered contacts:");
			foreach (var contact in filteredContacts)
			{
				Console.WriteLine(contact.Name);
			}

			// Select
			IEnumerable<string> emailList = contactList.Select(contact => contact.Email);
			Console.WriteLine("Email addresses:");
			foreach (var email in emailList)
			{
				Console.WriteLine(email);
			}
		}
	}
}
