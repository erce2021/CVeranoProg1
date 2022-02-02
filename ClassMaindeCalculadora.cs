using System;
using System.Collections.Generic;
using System.Text;

namespace Operador
{
    class Operador
    {
        static void Main(string[] args)
        {
            operador contador = new operador();
            Console.WriteLine("Escriba dos numeros: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            contador.setSuma(a,b);
            contador.impResultado();
            contador.setResta(a, b);
            contador.impResultado();
            contador.setDivision(a, b);
            contador.impResultado();
            contador.setMulti(a, b);
            contador.impResultado();
        }

    }
}
