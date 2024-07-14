using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management.Entity
{
	public class Analysis(string patientName, int leykosit, int eritrosit, int kreatin)
	{
		public int Leykosit { get; set; } = leykosit;
		public int Eritrosit { get; set; } = eritrosit;
		public int Kreatin { get; set; } = kreatin;
		public string PatientName { get; set; } = patientName;
	}
}
