using Hospital_management.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management.Actions
{
	public class PatientActions
	{
		public static void PatientSignUp()
		{
			string name = Console.ReadLine();
			string password = Console.ReadLine();
			AddPatient(new(name, password));
			Console.WriteLine("Hesab ugurla yaradildi.");
		}
		public static void PatientLogin()
		{
			string name = Console.ReadLine();
			string password = Console.ReadLine();
			if (PatientExists(name, password))
			{
				Console.WriteLine("xos gelmisiniz");
				bool loop = true;
				while (loop)
				{
					Console.WriteLine("\tQan analizi vermek - 3");
					Console.WriteLine("\tCixis - 4");
					int act = Convert.ToInt32(Console.ReadLine());
					switch (act)
					{
						case 3:
							GiveBloodTest(name);
							break;
						case 4:
							loop = false;
							break;
						default:
							Console.WriteLine("emeliyyat tapilmadi.");
							break;
					}
				}
			}
			else
			{
				Console.WriteLine("Bele xeste tapilmadi.");
			}
		}
		public static void AddPatient(Patient patient)
		{
			Patient.patients.Add(patient);
		}
		public static List<Patient> GetPatients()
		{
			return Patient.patients;
		}
		public static bool PatientExists(string name, string password)
		{
			return Patient.patients.Any(patient => patient.Name == name && patient.Password == password);
		}
		public static void GiveBloodTest(string patientName)
		{
			int leykosit = new Random().Next(1, 100);
			int eritrosit = new Random().Next(1, 100);
			int kreatin = new Random().Next(1, 100);
			AddAnalysis(patientName, leykosit, eritrosit, kreatin);
		}
		public static void AddAnalysis(string patientName, int leykosit, int eritrosit, int kreatin)
		{
			Patient.results.Add(new(patientName, leykosit, eritrosit, kreatin));
			Console.WriteLine("qan analizinin cavablari:");
			Console.WriteLine($"leykosit: {leykosit}, eritrosit: {eritrosit}, kreatin: {kreatin}");
			if (leykosit > 70 | eritrosit > 70 | kreatin > 70)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("saglamliginizda problem askar edildi!");
				Console.ResetColor();
                Console.WriteLine();
            }
		}
		public static List<Analysis> GetAnalyses()
		{
			return Patient.results;
		}
	}
}
