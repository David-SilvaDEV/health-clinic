

namespace health_clinic.models;

public class Patient
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public string Symptoms { get; set; }


    public Patient(int id, string name, int age, string symptoms)

    {
        Id = id;
        Name = name;
        Age = age;
        Symptoms = symptoms;

    }
}
