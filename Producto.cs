using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVirtualDeIndumentaria
{
    public class Producto
    {
        private string _nombre;
        private decimal _precio;
        private string _linkImagen;
        private string _tipo;
        private int _stock;
       

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
            }
        }

        public string Tipo
        {
            get { return _tipo; }
            set
            {
                _tipo = value;
            }
        }

        public decimal Precio
        {
            get { return _precio; }
            set
            {
                _precio = value;
            }
        }

        public string LinkImagen
        {
            get { return _linkImagen; }
            set
            {
                _linkImagen = value;
            }
        }

        public int Stock
        {
            get { return _stock; }
           set
           {
                _stock = value;
            }
        }


        public Producto(string nombre, decimal precio, string linkImagen, string tipo,int stock)
        {
            _nombre = nombre;
            _precio = precio;
            _linkImagen = linkImagen;
            _tipo = tipo;
            _stock = stock;
        }






        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre de producto: {_nombre}");


            return sb.ToString();
        }

       

    }
}
