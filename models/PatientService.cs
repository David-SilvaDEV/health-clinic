namespace health_clinic.models
{
    public class PatientService
    {
        private List<Patient> Patients = new List<Patient>();
        private List<Patient> PatientsAndPets = new List<Patient>();
        // Método para registrar pacientes
        public void RegisterPatient()
        {
            Console.Clear();
            Console.WriteLine("-[section of creating patient]-");
            Console.WriteLine("");

            Console.WriteLine("Write the ID number:");
            int id = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("Write the patient's name:");
            string name = Console.ReadLine() ?? "";

            int age = -1; // Inicializamos en un valor negativo para entrar en el ciclo

            // Validación de la edad
            while (age < 0)
            {
                try
                {
                    Console.WriteLine("Write patient age:");
                    age = int.Parse(Console.ReadLine() ?? "");

                    if (age < 0)
                    {
                        Console.WriteLine("Age must be a positive number. Please enter a valid age.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
            }

            Console.WriteLine("Write the patient's symptoms:");
            string symptoms = Console.ReadLine() ?? "";

            Patient newPatient = new Patient(id, name, age, symptoms);
            Patients.Add(newPatient);

            Console.WriteLine($"The patient {newPatient.Name} has been added successfully.");
        }

        // Mostrar todos los pacientes
        public void ShowPatients()
        {
            Console.WriteLine("List of patients:");
            foreach (Patient patient in Patients)
            {
                Console.WriteLine($"{patient.Name}");
            }
        }

        // Buscar pacientes por nombre
        public void ShowPatientsByName()
        {
            Console.WriteLine("Type the name of the patient you want to search for:");
            string answer = Console.ReadLine() ?? "";

            foreach (var patient in Patients)
            {
                if (patient.Name.Equals(answer, StringComparison.OrdinalIgnoreCase)) // Comparación insensible a mayúsculas
                {
                    Console.WriteLine($"Name: {patient.Name} | ID: {patient.Id} | Age: {patient.Age} | Symptoms: {patient.Symptoms}");
                }
            }
        }

        public void ShowPatientsAndPets()
        {

        }

        public void RegisterPet()
        {
            Console.WriteLine("-[section of creating pet]-");


            Console.WriteLine("Write the ID number:");
            int id = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("Write the pet name:");
            string name = Console.ReadLine() ?? "";

            Console.WriteLine("write the type of your pet");
            string type = Console.ReadLine() ?? "";

            Console.WriteLine("write your pet's age");
            int age = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("Write the corresponding patient identification number.");
            int idPatient = int.Parse(Console.ReadLine() ?? "");

            // Buscar al paciente
            Patient? patient = Patients.FirstOrDefault(p => p.Id == idPatient);

            if (patient == null)
            {
                Console.WriteLine("Patient not found!");
                return;
            }

            // Guardamos solo el nombre en la lista de strings
            patient.Pets.Add(name);



            // Pet NewPet = new Pet (id, name, age, type);
            // pets.Add(NewPet);
        }


    }





}
