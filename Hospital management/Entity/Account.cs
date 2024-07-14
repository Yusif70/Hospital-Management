using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management.Entity
{
	public class Account(string name, string password)
	{
		public string Name { get; set; } = name;
		public string Password { get; set; } = password;
	}
}
