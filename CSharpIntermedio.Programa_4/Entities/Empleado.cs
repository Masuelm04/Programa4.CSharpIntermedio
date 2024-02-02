using System;
using CSharpIntermedio.Programa_4.Interfaces;

namespace CSharpIntermedio.Programa_4.Entities
{
    public class Empleado : Persona, IPersona
    {
        public double Sueldo { get; set; }

        public Empleado(string nombre, int edad, double sueldo) : base(nombre, edad)
        {
            this.Sueldo = sueldo;
        }

        public new void Imprimir()
        {
            Console.WriteLine("------ INFORMACIÓN EMPLEADO ------");
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Sueldo: {Sueldo}");
        }
    }
}
