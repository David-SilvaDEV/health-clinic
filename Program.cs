using health_clinic.models;

var Patient1 = new Patient
{
    Id = 1,
    Name = "pedro",
    Age = 5,
    Symptoms = "moquillo"

};


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