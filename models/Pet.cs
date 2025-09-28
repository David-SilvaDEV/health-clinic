namespace health_clinic.models
{
    public class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }   // Ejemplo: perro, gato, conejo
        public int Age { get; set; }

        public int idPatient { get; set; }

        public Pet(string name, string type, int age, int idPatient)
        {

            Name = name;
            Type = type;
            Age = age;

        }



        public override string ToString()
        {
            return $" Name: {Name} Type: {Type}, Age: {Age} )";
        }
    }
}