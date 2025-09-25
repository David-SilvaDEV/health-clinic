using System.Data.Common;
using health_clinic.models;

List<Patient> Patients = new List<Patient>();




 void RegisterPatient ()
{
    Console.Clear();
    Console.WriteLine("-[section of creating patient]-");
    Console.WriteLine("");

    Console.WriteLine("write the ID number");
    int id = int.Parse(Console.ReadLine()??"");

    Console.WriteLine("write the patient's name");
    string name = Console.ReadLine() ?? "";
    Console.WriteLine("write the patient's name");
    int age = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("write the patient's symptoms");
    string symptoms = Console.ReadLine() ?? "";

    Patient newPatient = new Patient(id,name, age, symptoms);
    Patients.Add(newPatient);
}


static void MainMenu()
{
    while (true)
    {
        Console.WriteLine("----Welcome your Manager---");
        Console.WriteLine("Choose the corresponding option");
        Console.WriteLine(" [1] Register patient");
        Console.WriteLine(" [2] Patient List");
        Console.WriteLine(" [3] Search Patient");
        Console.WriteLine(" [4] Exit");

        string respuesta = Console.ReadLine() ?? "";

        switch (respuesta)
        {
            case "1":
                Console.WriteLine("aqui se agrega un paciente");
                break;
            case "2":
                Console.WriteLine("aqui se ve la lista de pacientes");
                break;
            case "3":
                Console.WriteLine("aqui se buscan los pacientes ");
                break;
            case "4":
                Console.WriteLine("aqui se sale");
                break;
            default:
                Console.WriteLine("opcion erronea");
                break;
        }
    }


}

MainMenu();