using System;

namespace DigitosDeCedula
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numC = 1,
                numP = 0,
                numIP = 0,
                sumIMP = 0;

            while ( numC >= 0 )
            {
                Console.WriteLine("Escriba los digitos de su cedula:");
                numC = int.Parse(Console.ReadLine());

                if ((numC % 2) == 0)
                {
                    numP++;
                    
                }
                else
                {
                    numIP++;
                    sumIMP += numIP;
                    
                }

            }
            Console.WriteLine($"Los num pares de la cedula son: {numP}");
            Console.WriteLine($"Los num impares de la cedula son: {numP}");
            Console.WriteLine($"La suma de los numeros impares es: {sumIMP}");
        }
    }
}
