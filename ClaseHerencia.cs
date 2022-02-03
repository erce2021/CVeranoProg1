using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SmartPhone : Celular
    {
        private float pixelesCamara = 10;
        private float tamañoMemInterna = 0;
        private float tamañoMemExterna = 0;

        public SmartPhone() { }

        public SmartPhone(String marca, String modelo, String color, float pixelesCamara, float tamañoMemRam, float tamañoDisco) : base(marca, modelo, color)
        {

            this.pixelesCamara = pixelesCamara;
            this.tamañoMemInterna = tamañoMemRam;
            this.tamañoMemExterna = tamañoDisco;

        }

        public override void informarCaracteristicas()
        {
            base.informarCaracteristicas();

            Console.WriteLine("SmartPhone calidad camara: " + pixelesCamara);
            Console.WriteLine("SmartPhone  tamaño Memoria interna: " + tamañoMemInterna);
            Console.WriteLine("SmartPhone  tamaño Memoria externa: " + tamañoMemExterna);

        }

        public float getPixelesCamara()
        {
            return pixelesCamara;
        }

        public void setPixelesCamara(float PixelesCamara)
        {
            this.pixelesCamara = PixelesCamara;
        }
        public float getMemoInterna()
        {
            return tamañoMemInterna;
        }

        public void setMemoInterna(float MemoInterna)
        {
            this.tamañoMemInterna = MemoInterna;
        }
        public float getMemoExterna()
        {
            return tamañoMemExterna;
        }

        public void setMemoExterna(float MemoExterna)
        {
            this.tamañoMemExterna = MemoExterna;
        }
    }
}
