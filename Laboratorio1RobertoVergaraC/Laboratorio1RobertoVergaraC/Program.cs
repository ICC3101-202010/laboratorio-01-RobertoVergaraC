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
            var person = new Persona();
            person.Name = "Roberto Vergara C";
            Console.WriteLine(person);
            Console.ReadLine();

        }
    }
}
