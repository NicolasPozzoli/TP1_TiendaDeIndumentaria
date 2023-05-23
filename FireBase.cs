using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using System.Configuration;
using FireSharp.Extensions;
using FireSharp;

namespace TiendaVirtualDeIndumentaria
{
    internal class FireBase
    {
            private static readonly IFirebaseConfig Config = new FirebaseConfig
            {
                AuthSecret = "H2UXuAvVK4nFO1QPEATKCn8Bqog7gwOi67bCEHsg",
                BasePath = "https://tiendadeindumentaria-1c803-default-rtdb.firebaseio.com/"
            };

            public static  FirebaseClient Client;

            public  FireBase()
            {
                Client = new FirebaseClient(Config);
            }

            public  async Task<FirebaseResponse> ObtenerCliente(string path)
            {
                return await Client.GetAsync(path);
            }

            public async Task<FirebaseResponse> IngresarCliente(Cliente client)
            {
                string IdGenerado = Guid.NewGuid().ToString("N");
                return await Client.SetAsync("Usuario/" + IdGenerado, client);
            }

            public  async Task<FirebaseResponse> IngresarProducto(Producto product)
            {
                try
                {
                    string IdGenerado = Guid.NewGuid().ToString("N");
                    return await Client.SetAsync("productos/" + IdGenerado, product);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        public async Task reponerStock(int stock)
        {
            //await Client.UpdateAsync($"productos\\{id}\\Stock", stock);
            await Client.UpdateAsync("Stock", stock);
        }

        public  async Task<FirebaseResponse> BorrarPorId(string pathId)
            {
                return await Client.DeleteAsync(pathId);
            }


    }

        //private static readonly IFirebaseConfig Config = new FirebaseConfig
        //{
        //    AuthSecret = "snuLFpLpLUZwfO9H0hNjiTxLTkLnAA44fIMHKIz8",
        //    BasePath = "https://tp1utn-default-rtdb.firebaseio.com/"
        //};

        //public static readonly FirebaseClient client;

        //static IngresoUsuario()
        //{
        //    client = new FirebaseClient(Config);
        //}


        //public async Task CargarUsuarioEnFirebase(string usuario,string psw)
        //{
        //    DocumentReference documentReference = client.Collection("Usuarios").Document(usuario);
        //        var user = new Cliente()
        //        {
        //            Usuario = usuario,
        //            Contrasenia = psw,
        //           // IdCliente = "01",
        //        };
        //        await documentReference.SetAsync(user);


        //}



        //public async Task<Dictionary<string,Cliente >>ObtenerUsuariosDeFirebase()
        //{
        //    FirebaseResponse response = await client.GetAsync("Usuarios");
        //    return response.ResultAs<Dictionary<string,Cliente>>();
        //}



        //public async Task CargarUsuarioEnFirebase(Cliente cliente)
        //{
        //    DocumentReference documentReference = client.Collection("Usuarios").Document(cliente.Usuario);
        //    Cliente usuario = new()
        //    {
        //        Usuario = cliente.Usuario,
        //        Contrasenia = cliente.Contrasenia,
        //        IdCliente = cliente.IdCliente,
        //    };
        //    await documentReference.SetAsync(usuario);

        //     FirebaseResponse response = await client.("Usuarios/" + cliente.Usuario, cliente);  
        //}
    }

