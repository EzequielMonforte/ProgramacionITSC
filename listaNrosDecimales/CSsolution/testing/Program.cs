﻿using System;
using System.Collections;
using System.Collections.Generic;
using Listas;

namespace testing
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List hola= new List();
            Console.WriteLine("Hello World!");
            hola.addNumber(1);
            hola.addNumber(2);
            hola.addNumber(1);
            var lista= hola.ShowOrderList();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
    
        }
    }
}

