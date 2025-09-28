namespace health_clinic.models;

public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Symptoms { get; set; }
   
    public List<Pet> Pets { get; set; }

    public Patient(int id, string name, int age, string symptoms)
    {
        this.Id = id;
        this.Name = name;
        this.Age = age;
        this.Symptoms = symptoms;
   
        this.Pets = new List<Pet>();
    }
}

