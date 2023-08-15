using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_4
{
	internal class Contact
	{
		public string Name { get; }
		public string Email { get; }

		public Contact(string name, string email)
		{
			Name = name;
			Email = email;
		}
	}
}
