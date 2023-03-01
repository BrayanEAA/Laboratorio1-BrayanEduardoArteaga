using lab.Entidades;
using lab.Negocio;

using System;

namespace EjercicioPersona.Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la edad:");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el sexo (H o M):");
            char sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el peso (kg):");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura (m):");
            double altura = double.Parse(Console.ReadLine());

            Persona persona = new Persona(nombre, edad, sexo, peso, altura);

            Console.WriteLine("Datos de la persona:");
            Console.WriteLine("Nombre: " + persona.Nombre);
            Console.WriteLine("Edad: " + persona.Edad);
            Console.WriteLine("Sexo: " + persona.Sexo);
            Console.WriteLine("Peso: " + persona.Peso);
            Console.WriteLine("Altura: " + persona.Altura);

            Console.WriteLine("IMC: " + lab.Negocio.ClsPersona.CalcularIMC(persona));
            Console.WriteLine("Es mayor de edad: " + lab.Negocio.ClsPersona.EsMayorDeEdad(persona));

            Console.ReadKey();
        }
    }
}

