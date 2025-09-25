
namespace health_clinic.models;

public class NewBaseType
{
    List<Patient> Patients = new List<Patient>();

     void RegisterPatient()
    {
        Console.Clear();
        Console.WriteLine("-[section of creating patient]-");
        Console.WriteLine("");

        Console.WriteLine("write the ID number");
        int id = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("write the patient's name");
        string name = Console.ReadLine() ?? "";
        Console.WriteLine("write patient age");
        int age = int.Parse(Console.ReadLine() ?? "");
        Console.WriteLine("write the patient's symptoms");
        string symptoms = Console.ReadLine() ?? "";

        Patient newPatient = new Patient(id, name, age, symptoms);
        Patients.Add(newPatient);

        Console.WriteLine($"the patient {newPatient.Name} has been added successfully");
   

    }
    void Showpatient()
    {
     Console.WriteLine("list of patient");
     foreach (Patient patient in Patients)
    {
        Console.WriteLine($"{patient.Name}");
    }

    ExitOrContinue();
    Showpatient();
    }
    
    void ShowPatientsByName()
    {    
        
        Console.WriteLine("type the name of the patient you want to search for:");
        string answer = Console.ReadLine() ?? "";

        foreach (var pat in Patients)
        {
            if (pat.Name == answer)
            {
                Console.WriteLine($"Name :{pat.Name} Id {pat.Id} Age :{pat.Age}");
            }
            

        }

    }
}


