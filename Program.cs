using System;

namespace Prueba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int y =1;
            int NPar=0, NImp=0;
            int SumImp = 0;


            Console.WriteLine("Digite su Cedula (Sin caraceres): ");
            Console.WriteLine("Ingrese -1 al finalizar. ");
            
            while (y>=0){
                y = int.Parse(Console.ReadLine());
            }


            for (int i = 1; i <= 10; i++)
            {
                if (y % 2 == 0)
                {
                    NPar = NPar + 1;
                }
                else
                    SumImp =SumImp + y;
                Console.WriteLine();
            }

            Console.WriteLine("La cantidad de numeros pares es: "+NPar);
            Console.WriteLine("La suma de numeros Impares es: " + SumImp);






        }
    }
}
