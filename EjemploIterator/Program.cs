using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploIterator
{
  class Program
    {
        static void Main (string[]args)

       {
           // Palabra palabra = new Palabra("Soy Nuevo");
            //foreach(var letra in palabra)
            //{
             //   Console.WriteLine(letra);
            //}
            foreach (var item in "Soy Nuevo")
            {
            Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    

    }
}
