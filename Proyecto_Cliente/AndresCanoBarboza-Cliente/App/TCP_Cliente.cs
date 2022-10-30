using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;
using System.IO;
using Entities.Models;
using Newtonsoft.Json;

namespace App
{
    public static class TCP_Cliente
    {
        private const int port = 15810;
        private const string ip = "127.0.0.1";
        private static TcpClient servidor;
        private static BinaryReader reader;
        private static BinaryWriter writer;

        private static Cliente conectado;
        public static string error;

        public static void Conectar(Cliente conectar)
        {
            try
            {
                servidor = new TcpClient(ip, port);
                reader = new BinaryReader(servidor.GetStream());
                writer = new BinaryWriter(servidor.GetStream());

                MensajeSocket request = new MensajeSocket()
                {
                    idCliente = 1,
                    json = JsonConvert.SerializeObject(conectar)
                };

                writer.Write(JsonConvert.SerializeObject(request));

                MensajeSocket response = JsonConvert.DeserializeObject<MensajeSocket>(reader.ReadString());
                conectado = JsonConvert.DeserializeObject<Cliente>(response.json);
                if (conectado.clienteId == string.Empty)
                {
                    error = "CREDENCIALES INCORRECTAS";
                }
                else
                {
                    error = "";
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }
        }


    }
}
