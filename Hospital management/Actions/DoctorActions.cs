using Hospital_management.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management.Actions
{
    public class DoctorActions
    {
		public static void DoctorSignUp()
		{
			string name = Console.ReadLine();
			string password = Console.ReadLine();
			AddDoctor(new(name, password));
			Console.WriteLine("Hesab ugurla yaradildi.");
		}
		public static void DoctorLogin()
		{
			string name = Console.ReadLine();
			string password = Console.ReadLine();
			if (DoctorExists(name, password))
			{
				Console.WriteLine("Xos gelmisiniz,");
				bool loop = true;
				while (loop)
				{
					Console.WriteLine("\tXestelerin qan analizinin neticeleri - 3");
					Console.WriteLine("\tCixis - 4");
					int act = Convert.ToInt32(Console.ReadLine());

					switch (act)
					{
						case 3:
							if (PatientActions.GetPatients().Count == 0)
							{
								Console.WriteLine("Hec bir xeste tapilmadi");
							}
							else
							{
								foreach (Patient patient in PatientActions.GetPatients())
								{
									GetPatientResults(PatientActions.GetAnalyses(), patient.Name);
								}
							}
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
				Console.WriteLine("Bele hekim tapilmadi.");
			}
		}
		public static void AddDoctor(Doctor doctor)
        {
			Doctor.doctors.Add(doctor);
        }
		public static List<Doctor> GetDoctors()
        {
            return Doctor.doctors;
        }
        public static bool DoctorExists(string name, string password)
        {
            return Doctor.doctors.Any(doctor => doctor.Name == name && doctor.Password == password);
        }
        public static void GetPatientResults(List<Analysis> results, string patientName)
        {
            foreach (Analysis analysis in results.FindAll(analysis => analysis.PatientName == patientName))
            {
                Console.WriteLine($"{patientName} adli xestenin neticeleri: ");
                Console.WriteLine($"leykosit: {analysis.Leykosit}, eritrosit: {analysis.Eritrosit}, kreatin: {analysis.Kreatin}");
                if (analysis.Leykosit > 70 | analysis.Eritrosit > 70 | analysis.Kreatin > 70)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{patientName} adli xestenin qan tehlilinde problem askar edilib!");
                    Console.ResetColor();
					Console.WriteLine();
                }
            }
		}
	}
}
