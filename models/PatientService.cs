namespace health_clinic.models
{
    public class PatientService
    {
        private List<Patient> Patients = new List<Patient>();
        private List<Pet> Pets = new List<Pet>();
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
            RegisterPet();
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
            if (!Patients.Any())
            {
                Console.WriteLine("No patients registered.");
                return;
            }

            Console.WriteLine("=== Patients and their pets ===");

            foreach (var patient in Patients)
            {
                Console.WriteLine($"Patient: {patient.Name} (ID: {patient.Id}, Age: {patient.Age})");
                Console.WriteLine($"Symptoms: {patient.Symptoms}");

                if (patient.Pets.Any())
                {
                    Console.WriteLine("Pets:");
                    foreach (var pet in patient.Pets)
                    {
                        Console.WriteLine($" Name : - {pet.Name}");
                        Console.WriteLine($" Type : - {pet.Type}");

                    }
                }
                else
                {
                    Console.WriteLine("   No pets registered.");
                }

                Console.WriteLine("----------------------------------");
            }
        }


        public void RegisterPet()
        {
            Console.WriteLine("-[section of creating pet]-");



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

            Pet newPet = new(name, type, age, idPatient);
            Pets.Add(newPet);
            patient.Pets.Add(newPet);

            // Pet NewPet = new Pet (id, name, age, type);
            // pets.Add(NewPet);
        }



        public void DeletePatient()
        {
            Console.WriteLine("-[section Delete Patient ]-");
            Console.WriteLine("");
            Console.WriteLine("Enter the ID number of the patient you want to delete.");
            int IdDelet = int.Parse(Console.ReadLine() ?? "");

            Patient? patient = Patients.FirstOrDefault(p => p.Id == IdDelet);
            if (patient == null)
            {
                Console.WriteLine("Patient not found!");
                return;
            }

            else
            {
                Patients.Remove(patient);
            }

        }

       public void DeletePet()
{
    Console.WriteLine("-[ Delete pet section ]-");

    Console.WriteLine("Enter the ID of the patient to whom the pet belongs:");
    int idPat = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Write the name of the pet you want to delete:");
    string namePet = Console.ReadLine() ?? "";

    // Buscar al paciente
    Patient? patient = Patients.FirstOrDefault(p => p.Id == idPat);
    if (patient == null)
    {
        Console.WriteLine("❌ Patient not found!");
        return;
    }

    // Buscar la mascota dentro de ese paciente
    Pet? pet = patient.Pets.FirstOrDefault(pe => 
        pe.Name.Equals(namePet));

    if (pet == null)
    {
        Console.WriteLine("❌ Pet not found!");
        return;
    }

    // Eliminar de la lista del paciente
    patient.Pets.Remove(pet);

    // También la eliminamos de la lista global de mascotas
    Pets.Remove(pet);

    Console.WriteLine($"✅ The pet {pet.Name} was successfully removed from patient {patient.Name}.");
}


    }
}
      
