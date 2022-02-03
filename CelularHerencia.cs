using System;

namespace ConsoleApp1
{
    class Celular
    {
        private String marca;
        private String modelo;
        private String color;

        public Celular() { } 
        //Constructor con parametros
        public Celular(String marca, String modelo, String color)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
        }

        

        public void llamar(String nombre)
        {
            Console.WriteLine("Llamando a " + nombre);
        }

        public void cortarLlamada ()
        {
            Console.WriteLine("Llamada finalizada");
        }

        public virtual void informarCaracteristicas()
        {
            Console.WriteLine("Celular Marca: "+ marca);
            Console.WriteLine("Celular Modelo: "+ modelo);
            Console.WriteLine("Celular Color: "+ color);
        }

        public String getMarca()
        {
            return marca;
        }

        public  void setMarca(String marca)
        {
            this.marca = marca;
        }

        public String getModelo()
        {
            return modelo;
        }

        public void setModelo(String modelo)
        {
            this.modelo = modelo;
        }
        public String getColor()
        {
            return marca;
        }

        public void setColor(String color)
        {
            this.color = color;
        }

    }
}
