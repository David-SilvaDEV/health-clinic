namespace health_clinic.models
{
    public class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }   // Ejemplo: perro, gato, conejo
        public int Age { get; set; }

        public override string ToString()
        {
            return $" Name: {Name} Type: {Type}, Age: {Age} )";
        }
    }
}