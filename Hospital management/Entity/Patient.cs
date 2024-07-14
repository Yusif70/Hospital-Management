using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management.Entity
{
	public class Patient(string name, string password) : Account(name, password)
	{
		public static List<Patient> patients = [];
		public static List<Analysis> results = [];
	}
}
