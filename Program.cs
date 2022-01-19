using System;

namespace Clasedia2parte2
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string nombre;
            //int edad;

           for(int i=1; i<=5; i++)
            {

                Console.WriteLine("Introduzca el nombre "+i);
                nombre=Console.ReadLine();
                Console.WriteLine("Introduzca la edad de "+nombre);
                Console.ReadLine();

            }//fin del ciclo*/

            string num;
            int nume,suma =0,promedio=0;

            for (int i = 1; i <= 5; i++)
            {
                int[] numeros = new int[5];
                Console.WriteLine("Introduzca el numero " + i);
                num = Console.ReadLine();
                nume = Convert.ToInt32(num);

                suma +=nume;
                promedio = suma / (i-1);
            }//fin del ciclo
            Console.WriteLine("La suma de todos los numeros es: {0}", suma);
            Console.WriteLine("el promedio de los numeros es: {0}", promedio);

        }
    }
}
