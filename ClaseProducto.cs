using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase
{
    class Producto
    {
        string nombre;

        public string Nombre { get { return nombre; } set { nombre = value; } }

        string description;
        public string Description { get { return description; } set { description = value; } }

        string marca;
        public string Marca { get { return marca; } set { marca = value; } }

        float precio;
        public float Precio { get { return precio; } set { precio = value; } }

        int stock;
        public int Stock { get { return stock; } set { stock = value; } }

        


    }
}
