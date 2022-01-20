using System;

namespace Ejercicio2Diajueves20
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Participantes = {"1","2","3","4"};
            int gan;
            int vot=1,cvot1=0,cvot2=0,cvot3=0,cvot4=0;
            //double[] votos = new double[4];

            //Menu para eligir las casillas 
            Console.WriteLine("Casillas de los participantes");

            for (int i = 0; i < Participantes.Length; i++)
            {
                Console.WriteLine("Candidato "+Participantes[i]);

            }
           
            while (vot!=0)
            {
                Console.WriteLine("Ingrese el voto: ");
                vot = int.Parse(Console.ReadLine());
                switch (vot)
                {
                    case 1:
                        if (vot == 1)
                        {
                            cvot1++;
                        }
                        break;
                    case 2:
                        if (vot == 2)
                        {
                            cvot2++;
                        }
                        break;
                    case 3:
                        if (vot == 3)
                        {
                            cvot3++;
                        }
                        break;
                    case 4:
                        if (vot == 4)
                        {
                            cvot4++;
                        }
                        break;

                    default:
                        Console.WriteLine("El participante no existe");
                        break;
                }
                int max = cvot1;
                if(max < cvot2)
                {
                    max = cvot2;
                    Console.WriteLine("El ganador es el participante 2");
                }
                if else()

                
            }
           


            Console.WriteLine("El ganador es: ");
            Console.WriteLine(cvot1);
            Console.WriteLine(cvot2);
            Console.WriteLine(cvot3);
            Console.WriteLine(cvot4);






        }
    }
}
