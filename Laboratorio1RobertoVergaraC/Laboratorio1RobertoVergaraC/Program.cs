using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1RobertoVergaraC
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Persona("Bob", "Kunga");

            int a = 0;
            int b = 3;
            person.Lanzar(a, b);
            Console.ReadLine();
        }
    }
}
