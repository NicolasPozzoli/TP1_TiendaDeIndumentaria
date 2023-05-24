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

        public async Task<FirebaseResponse> ActualizarStockProducto(Producto product,string id,int stock)
        {
            try
            {
                product.Stock=stock;
                return await Client.UpdateAsync("productos/" + id, product);
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

    
    }

