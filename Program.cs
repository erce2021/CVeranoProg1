using System;

namespace Gastosdia3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea un arreglo
            double[] vGastos;
            //Crea las variables
            double gasto, totalGasto, diaMayor, gastoMayor;
            //Un int para los dias 
            int cantDias;

            Console.WriteLine("Coloque los dias que desea introducir");
            cantDias = Convert.ToInt32(Console.ReadLine());
            //Almacena la cantidad de dia en el arreglo , la cantidad de gastos va en dependencia en los dias
            vGastos = new double[cantDias];

            for(int dia = 1; dia <= cantDias; dia++)
            {
                Console.WriteLine("Ingrese el gasto del dia " + dia + " Gastos");
                //Se introducen los gastos
                gasto = Convert.ToDouble(Console.ReadLine());
                //Crea un contador que va almacenando la cantidad de los gastos en el arreglo
                vGastos[dia - 1] = gasto;
            }
            
            //Hacemos una comparacion de cual gasto es mayor 
            //Inicializa las variables con 0
            gastoMayor = 0;
            totalGasto = 0;
            //Inicializa el dia con 1
            diaMayor = 1;

            //
            for(int i = 0; i < cantDias; i++)
            {
                //Evalua el gasto mayor
                if (vGastos[i] > gastoMayor)
                {

                    gastoMayor = vGastos[i];
                    diaMayor = i + 1;
                }
                //Calculamos el total
                totalGasto = totalGasto + vGastos[i];
                //Mostramos los gastos
                Console.WriteLine("Dia " + (i + 1) + " Total: " + vGastos[i]);
            }
            Console.WriteLine($"El gasto mayor es: {gastoMayor}");
            Console.WriteLine($"El total de gasto es: {totalGasto}");
            Console.WriteLine($"El dia de mayor gasto es: {diaMayor}");
        }
    }
}
