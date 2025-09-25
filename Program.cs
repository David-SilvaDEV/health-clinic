using System.Data.Common;
using System.Net;
using health_clinic.models;

 List<Patient> Patients = new List<Patient>();







//-------------------------------------------------------------------------------------------

    void ExitOrContinue()
{
    Console.WriteLine("Do you want to continue in section [1]?");
    Console.WriteLine("Do you want to exit to the main menu [2]?");

    string answer = Console.ReadLine() ?? "";
    if (answer == "1")
    {
        return;
    }

    else if (answer == "2")
    {
        MainMenu();
    }

    else
    {
        Console.WriteLine("wrong option");
        ExitOrContinue();
    }
    
}

//-------------------------------------------------------------------------------------------
void MainMenu()
{  
     while (true)

    {
        Console.WriteLine("----Welcome your Manager---");
        Console.WriteLine("Choose the corresponding option");
        Console.WriteLine(" [1] Register patient");
        Console.WriteLine(" [2] Patient List");
        Console.WriteLine(" [3] Search Patient");
        Console.WriteLine(" [4] Exit");

        string answer = Console.ReadLine() ?? "";

       switch (answer)
        {
            case "1":
                RegisterPatient();  
                break;  
            case "2":
                Showpatient();  
                break;  
            case "3":
                Console.WriteLine("aqui se buscan los pacientes ");
                break;
            case "4":
                Console.WriteLine("Exiting...");
                return;
            default:
                Console.WriteLine("opcion erronea");
                break;
        }

       
    }
}

MainMenu();