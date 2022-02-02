using System;

namespace Operador
{
    class operador
    {
        

        public operador()
        {
           // Console.WriteLine("Constructor de la clase operador");
        }

        int dato1, dato2, resultado = 0;
        public void setSuma(int a, int b)
        {
            this.dato1 = a;
            this.dato2 = b;
            this.resultado = dato1 + dato2;
        }
        public void setResta(int a, int b)
        {
            this.dato1 = a;
            this.dato2 = b;
            this.resultado = dato1 - dato2;
        }
        public void setDivision(int a, int b)
        {
            this.dato1 = a;
            this.dato2 = b;
            this.resultado = dato1 / dato2;
        }
        public void setMulti(int a, int b)
        {
            this.dato1 = a;
            this.dato2 = b;
            this.resultado = dato1 * dato2;
        }
        public void impResultado()
        {
            Console.WriteLine("El resultado es = " + resultado);
        }
    }
}
