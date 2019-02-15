using System;
using System.Collections;
using System.Collections.Generic;
using Listas;

namespace Listas
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Listas.List hola= new Listas.List();
            Console.WriteLine("Hello World!");
            hola.addNumber(1);
            hola.addNumber(2);
            hola.addNumber(1);
            var lista= hola.ShowOrderList(false);
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
    
        }
    }
}

