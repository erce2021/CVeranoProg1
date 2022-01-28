using System;

namespace ConsoleApp2
{
    public class Cine
    {

        static void Main(string[] args)
        {
            
            Cine cc = new Cine();

            cc.CineRegistro();

        }

       

        String[] ArrNomCine;
        int[] ArrTelCine;
        String[] PG;
        String[] DF;
        
        void CineRegistro()
        {
            ArrNomCine = new string[5];
            ArrTelCine = new int[5];
            PG = new string[5];
            DF = new string[5];

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Introduzca el nombre del cine: "+ i +": ");
                String linea;
                linea = Console.ReadLine();
                ArrNomCine[i] = linea;
                

                Console.WriteLine("Introduzca el telefono del cine: " + i + ": ");
                int n = Convert.ToInt32(Console.ReadLine());
                ArrTelCine[i] = n;
                

                Console.WriteLine("Introduzca la pagina web del cine: " + i + ": ");
                String line = Console.ReadLine();
                PG[i] = line;
                

                Console.WriteLine("Introduzca la direccion de facebook del cine: " + i + ": ");
                String line2 = Console.ReadLine();
                DF[i] = line2;
                

                Console.WriteLine("" + "\nRegistro de los cines: ");

                Console.WriteLine($"El nombre del cine {i} es: {ArrNomCine[i]}");
                Console.WriteLine($"El telefono del cine {i} es: {ArrTelCine[i]}");
                Console.WriteLine($"La pagina web del cine {i} es: {PG[i]}");
                Console.WriteLine($"El facebook del cine {i} es: {DF[i]}");
                Console.WriteLine("");
            }

        }
        
        

    }
}
