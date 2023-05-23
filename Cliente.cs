using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVirtualDeIndumentaria
{
    [FirestoreData]
    internal class Cliente
    {
        
        private string _idCliente;
        private string _usuario;
        private string _contrasenia;
        private bool _esAdmin;


        [FirestoreDocumentId]
        public string IdCliente
        {
            get { return _idCliente; }
            set
            {
                _idCliente = value;
            }
        }

        public bool EsAdmin
        {
            get { return _esAdmin; }
            set
            {
                _esAdmin = value;
            }
        }

        [FirestoreProperty]
        public string Usuario
        {
            get { return _usuario; }
            set
            {
                _usuario = value;
            }
        }


        [FirestoreProperty]
        public string Contrasenia
        {
            get { return _contrasenia; }
            set
            {
                _contrasenia = value;
            }
        }



        //     public Cliente(string usuario, string contrasenia)
        //   {
        //     _usuario = usuario;
        //   _contrasenia = contrasenia;
        //}

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre de usuario: {_usuario}");
            sb.AppendLine($"Contrasenia: {_contrasenia}");


            return sb.ToString();
        }


    }
}
