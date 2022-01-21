using System;

namespace Ejercicio2Diajueves20
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Participantes = { "1", "2", "3", "4" };
            //int cand1 = 0, cand2 = 0, cand3 = 0, cand4 = 0, ganador = 0;
            double po1 , po2 , po3 , po4 ;
            //double[] porc = new double[4];
            int vot=1,cvot1=0,cvot2=0,cvot3=0,cvot4=0,totalVot;
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
                            cvot1= cvot1 + 1;
                        }
                        break;
                    case 2:
                        if (vot == 2)
                        {
                            cvot2= cvot2 + 1;
                        }
                        break;
                    case 3:
                        if (vot == 3)
                        {
                            cvot3= cvot3 + 1;
                        }
                        break;
                    case 4:
                        if (vot == 4)
                        {
                            cvot4= cvot4 + 1;
                        }
                        break;
                    case 5:
                        if (vot >4)
                        {
                            Console.WriteLine("El participante no existe");
                        }
                        break;

                    default:
                        break;
                }

            }
            Console.WriteLine("");
            //Calcular ganador
            int gan = cvot1;
            if (gan < cvot2)
            {
                gan = cvot2;
                Console.WriteLine("El ganador es el participante 2");
                Console.WriteLine($"Su numero total de votos fue: {cvot2 }");
            }
            else if (gan < cvot3)
            {
                gan = cvot3;
                Console.WriteLine("El ganador es el participante 3");
                Console.WriteLine($"Su numero total de votos fue: {cvot3 }");
            }
            else if (gan < cvot4)
            {
                gan = cvot4;
                Console.WriteLine("El ganador es el participante 4");
                Console.WriteLine($"Su numero total de votos fue: {cvot4 }");
            }
            else
            {
                Console.WriteLine("El ganador es el participante 1");
                Console.WriteLine($"Su numero total de votos fue: {cvot1 }");
            }

            //Porcentajes
            totalVot = (cvot1 + cvot2 + cvot3 + cvot4);
            Console.WriteLine($"La cantidad de votos totales fue: {totalVot}");
            Console.WriteLine(" ");
            po1 = (100 * cvot1) / totalVot;
            po2 = (100 * cvot2) / totalVot;
            po3 = (100 * cvot3) / totalVot;
            po4 = (100 * cvot4) / totalVot;

            Console.WriteLine("");
            Console.WriteLine("Los porcentajes en total fueron: ");
            Console.WriteLine($"Porcentaje del primer participante: {po1} %");
            Console.WriteLine($"Porcentaje del segundo participante: {po2} %");
            Console.WriteLine($"Porcentaje del tercer participante: {po3} %");
            Console.WriteLine($"Porcentaje del cuarto participante: {po4} %");
















        }
    }
}
