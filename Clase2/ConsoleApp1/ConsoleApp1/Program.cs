using System;
using Clase;


namespace ConsoleApp1
{
	class Program
	{

		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Persona persona = new Persona();
			persona.FechaNacimiento = new DateTime(1997, 11, 1);
			Console.WriteLine(persona.ObtenerEdad().Days/365);
		}

	}
}