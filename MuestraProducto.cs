using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaVirtualDeIndumentaria
{
    internal static class MuestraProducto
    {
        public static void CargarPrecio(Label[] labels,int index,decimal precio)
        {
            
            labels[index].Text = "$" +precio.ToString();
        }
        public static void CargarNombre(Label[] labels, int index, string nombre)
        {
                
                labels[index].Text = nombre;  

        }
        public static void CargarImagen(PictureBox[] imagen, int index, string pathImagen)
        {
            
                imagen[index].Image = Image.FromFile(pathImagen);
            

        }

    }
}
