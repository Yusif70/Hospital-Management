using Hospital_management.Actions;

Console.WriteLine("Xestexana idareetme sistemine xos gelmisiniz");
bool loop = true;
while (loop)
{
    Console.WriteLine("Ne olaraq daxil olmaq istediyinizi girin: Hekim, Xeste");
    string? input = Console.ReadLine();
    switch (input.ToLower())
    {
        case "hekim":
            Console.WriteLine("\tHesaba daxil olmaq - 1");
            Console.WriteLine("\tQeydiyyatdan kecmek - 2");
            int doctorAct = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ad ve parolu daxil edin: ");
            if (doctorAct == 1)
            {
                DoctorActions.DoctorLogin();
            }
            else if (doctorAct == 2)
            {
                DoctorActions.DoctorSignUp();
                Console.WriteLine("yeni hesaba daxil olmaq ucun ad ve parolu daxil edin: ");
                DoctorActions.DoctorLogin();
            }
            break;
        case "xeste":
            Console.WriteLine("\tHesaba daxil olmaq - 1");
            Console.WriteLine("\tQeydiyyatdan kecmek - 2");
            int patAct = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ad ve parolu daxil edin: ");
            if (patAct == 1)
            {
                PatientActions.PatientLogin();
            }
            else if (patAct == 2)
            {
                PatientActions.PatientSignUp();
                Console.WriteLine("yeni hesaba daxil olmaq ucun ad ve parolu daxil edin: ");
                PatientActions.PatientLogin();
            }
            break;
        case "":
            Console.WriteLine("Xestexana idareetme sisteminden istifade etdiyiniz ucun tesekkurler");
            loop = false;
            break;
        default:
            Console.WriteLine("emeliyyat tapilmadi.");
            break;
    }
}