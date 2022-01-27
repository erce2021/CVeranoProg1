using System;

namespace Carro
{
    class Carro
    {
        private String marca;
        private String modelo;
        private String color;
        private int velocidad;
        
        Boolean arrancado;
        static void Main(string[] args)
        {
            int menu=0;
            Carro carro1 = new Carro();
            


            while (menu <= 5)
            {
                Console.WriteLine("Menu:" +
                "\n1.Arrancar" +
                "\n2.Acelerar" +
                "\n3.Frenar" +
                "\n4.Parar" +
                "\n5.Salir");
                menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1)
                {
                    carro1.arrancar();

                }
            else if (carro1.arrancado == true)
                {
                    
                    carro1.acelerar();
                }
                else if (menu == 3)
                {
                    carro1.arrancar();
                    carro1.acelerar();
                    carro1.frenar();
                }
                else if (menu == 4)
                {
                    carro1.arrancar();
                    carro1.frenar();
                    carro1.parar();
                }
                else
                {
                    Console.WriteLine("Salio del menu");
                }
            }

        }

        //Constructor
        public Carro()
        {
            marca = "";
            modelo = "";
            color = "";
            velocidad = 0;
            arrancado = false;
        }

        void acelerar()
        {
            velocidad += 1;
            Console.WriteLine($"La velocidad a la que va es: {velocidad}");
        }
        void frenar()
        {
            velocidad -= 1;
            Console.WriteLine($"La velocidad a la que se detuvo es: {velocidad}");
        }
        Boolean arrancar()
        {
            arrancado = true;
            velocidad = 1;
            Console.WriteLine("Encendido");
            return arrancado;
        }
        void parar()
        {
            arrancado = false;
            velocidad = 0;
            Console.WriteLine("Parqueado");
        }

        


    }

}
