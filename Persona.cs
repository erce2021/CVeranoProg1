using System;

namespace Persona
{
    class Persona
    {
        String nombre;
        int edad = 0;
        //double peso = 0, altura = 0;
        decimal peso = 0.0M, altura = 0.0M;

        static void Main(string[] args)
        {
            Persona cc = new Persona();
            cc.CalcularIMC();
            
        }


       
         void CalcularIMC()
        {
            

            Console.WriteLine("Escriba su peso en kg: ");
            peso = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Escriba su altura en metros: ");
            altura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(peso);
            Console.WriteLine(altura);

            decimal form = (peso / (altura * altura));
            Console.WriteLine(form);
           

            if (form < 20)
            {
                Console.WriteLine("-1");
            }
            else if (form >= 20 && form <= 25)
            {
                Console.WriteLine("0");
            }
            else if (form > 25)
            {
                Console.WriteLine("1");
            }
           
            
        }
    }
}
