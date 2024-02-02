using CSharpIntermedio.Programa_4.Interfaces;

namespace CSharpIntermedio.Programa_4.Entities
{
    public class Persona : IPersona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public void Imprimir()
        {
            Console.WriteLine("------ INFORMACIÓN PERSONA ------");
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }
}
