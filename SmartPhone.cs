using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class Class1
{
        static void Main(string[] args)
        {
           
            SmartPhone cc = new SmartPhone();

            cc.setMarca("Nokia");
            cc.setModelo("Nokia 9 PureView");
            cc.setColor("Negro");
            cc.setPixelesCamara(64);
            cc.setMemoInterna(4);
            cc.setMemoExterna(64);

            cc.llamar("JuanPerez");
            cc.cortarLlamada();
            Console.WriteLine(" ");
            cc.informarCaracteristicas();


        }
}
}
