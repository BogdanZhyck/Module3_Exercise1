using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_2
{
	class CustomContactCollection
	{
		private Dictionary<char, List<Contact>> _contactsByAlphabet = new Dictionary<char, List<Contact>>();
		private CultureInfo _currentCulture;

		public CustomContactCollection(CultureInfo culture = null)
		{
			_currentCulture = culture ?? CultureInfo.GetCultureInfo("en-US");
		}

		public void AddContact(Contact contact)
		{
			char firstChar = GetFirstChar(contact.Name);
			if (!_contactsByAlphabet.ContainsKey(firstChar))
			{
				_contactsByAlphabet[firstChar] = new List<Contact>();
			}
			_contactsByAlphabet[firstChar].Add(contact);
		}

		public List<Contact> GetContactsByAlphabet()
		{
			var sortedContacts = _contactsByAlphabet
				 .OrderBy(pair => pair.Key)
				 .ToDictionary(pair => pair.Key, pair => pair.Value);

			return sortedContacts.SelectMany(pair => pair.Value).ToList();
		}

		private char GetFirstChar(string text)
		{
			var collator = StringInfo.GetTextElementEnumerator(text);
			if (collator.MoveNext())
			{
				string firstElement = collator.GetTextElement();
				return char.ToUpper(firstElement[0], _currentCulture);
			}
			return '#'; 
		}
	}
}
