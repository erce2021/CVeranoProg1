using System;

namespace App
{
    class EmpleadoBaseMasComision
    {
        private string primerNombre;
        private string apellidoPaterno;
        private string numSegSocial;
        private decimal ventasBrutas;
        private decimal tarifaComision;
        private decimal salarioBase;

        public EmpleadoBaseMasComision(string nombre, string apellido, string nss, decimal ventas, decimal tarifa, decimal salario)
        {
            primerNombre = nombre;
            apellidoPaterno = apellido;
            numSegSocial = nss;
            ventasBrutas = ventas;
            tarifaComision = tarifa;
            salarioBase = salario;

        }
        public string PrimerNombre
        {
            get { return primerNombre; }
            set { PrimerNombre = primerNombre; }
        }
        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
            set { ApellidoPaterno = apellidoPaterno; }
        }
        public string NumSegSocial
        {
            get { return numSegSocial; }
            set { NumSegSocial = numSegSocial; }
        }
        public decimal VentasBrutas
        {
            get { return ventasBrutas; }
            set { VentasBrutas = (value < 0) ? 0 : value; }
        }
        public decimal TarifaComision
        {
            get { return tarifaComision; }
            set { TarifaComision = (value > 0 && value < 1) ? value : 0; }
        }
        public decimal SalarioBase
        {
            get { return salarioBase; }
            set { SalarioBase = (value < 0) ? 0 : value; }
        }

        public decimal Ingresos()
        {
            return SalarioBase + (TarifaComision * VentasBrutas);
        }
        public override string ToString()
        {
            return base.ToString();
        }


    }
}
