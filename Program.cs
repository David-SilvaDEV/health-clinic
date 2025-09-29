using System;
using health_clinic.models; // Importar el namespace de los modelos

class Program
{
    static void Main(string[] args)
    {
        MainMenu();
    }

    static void MainMenu()
    {
        // Crear una instancia de PatientService
        PatientService patientService = new PatientService();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("---- Welcome to the Health Clinic Manager ----");
            Console.WriteLine("Choose the corresponding option:");
            Console.WriteLine("[1] Register Patient");
            Console.WriteLine("[2] Patient List");
            Console.WriteLine("[3] Search Patient");
            Console.WriteLine("[4] see patients with their pets");
            Console.WriteLine("[5] Delete Patient");
            Console.WriteLine("[6] Delete pet");
            Console.WriteLine("[7] Show types of registered pets");
            Console.WriteLine("[-] Exit");

            string answer = Console.ReadLine() ?? "";

            switch (answer)
            {
                case "1":
                    // Llamar al método para registrar un paciente
                    patientService.RegisterPatient();
                    break;

                case "2":
                    // Mostrar lista de pacientes
                    patientService.ShowPatients();
                    break;

                case "3":
                    // Buscar paciente por nombre
                    patientService.ShowPatientsByName();
                    break;

                case "4":
                    // ver pacientes con sus mascotas
                    patientService.ShowPatientsAndPets();
                    break;

                case "5": 
                    //Eliminar pacientes 
                    patientService.DeletePatient(); 
                    break;

                case "6":
                    //eliminar mascota
                    patientService.DeletePet();
                    break;

                case "7":
                    //mostrar tipos de mascotas registradas
                    patientService.ShowPetTypes();
                    break;
                case "8":
                    // Salir del programa
                    Console.WriteLine("Exiting...");
                    return;
                

                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

   
}
