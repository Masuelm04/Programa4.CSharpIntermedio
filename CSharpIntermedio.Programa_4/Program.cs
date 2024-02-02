using CSharpIntermedio.Programa_4.Entities;

Persona persona = new Persona("Carmelo", 34);
persona.Imprimir();

Console.WriteLine();

Empleado empleado = new Empleado("Lucero", 22, 35000);
empleado.Imprimir();

Console.ReadKey();