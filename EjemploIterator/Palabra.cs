using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploIterator
{
    public class Palabra : IEnumerable
    {
        String _palabra;
        public Palabra(string palabra)
        {
            _palabra = palabra;
        }

        public IEnumerator GetEnumerator()
        {
            return new PalabraIterator(_palabra);
        }
    }
}