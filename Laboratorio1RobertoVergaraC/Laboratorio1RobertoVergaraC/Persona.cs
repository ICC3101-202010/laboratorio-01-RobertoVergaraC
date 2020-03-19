using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1RobertoVergaraC
{
    public class Persona
    {
        public string Name;
        public string Surname;

        public Persona(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void Lanzar(int a, int b)
        {
            Random rdn = new Random();
            Console.WriteLine(rdn.Next(a, b));
        }
    }
}
