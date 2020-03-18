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
            var me = new Persona();
            me.Name = "Roberto";
            me.Surname = "Vergara";
            int a = 0;
            int b = 3;
            me.Lanzar(a, b);
            Console.ReadLine();
        }
    }
}
