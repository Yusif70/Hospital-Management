using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management.Entity
{
	public class Doctor(string name, string password) : Account(name, password)
	{
		public static List<Doctor> doctors = [];
	}
}
