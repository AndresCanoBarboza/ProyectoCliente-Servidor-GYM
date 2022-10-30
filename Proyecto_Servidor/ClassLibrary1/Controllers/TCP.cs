using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using Newtonsoft.Json;
using Entities.Models;

namespace ClassLibrary1.Controllers
{
    public static class TCP
    {
        private const int port = 15810;
        private const string ip = "127.0.0.1";
        private static Thread thServer;
        private static TcpListener servidor;
        private static bool power = false;

        public static void Iniciar()
        {
            if (!power)
            {
                power = true;
                servidor = new TcpListener(IPAddress.Parse(ip), port);
                thServer = new Thread(new ThreadStart(Escuchar));
                thServer.Start();
            }
        }

        public static void Escuchar()
        {
            servidor.Start();
            while (power)
            {
                TcpClient nuevo = servidor.AcceptTcpClient();
                Thread thClient = new Thread(new ParameterizedThreadStart(Comunicarse));
                thClient.Start(nuevo);
            }
        }

        public static void Comunicarse(object obj)
        {
            try
            {
                TcpClient cliente = (TcpClient)obj;
                BinaryReader reader = new BinaryReader(cliente.GetStream());
                BinaryWriter writer = new BinaryWriter(cliente.GetStream());
                while (power)
                {
                    MensajeSocket request = JsonConvert.DeserializeObject<MensajeSocket>(reader.ReadString());
                    MensajeSocket response = new MensajeSocket();
                    switch (request.idCliente)
                    {
                        case 1:
                            response = Conectado(JsonConvert.DeserializeObject<Cliente>(request.json));
                            break;
                        case 2:
                            response = Guardar(JsonConvert.DeserializeObject<Reserva>(request.json));
                            break;
                        case 3:
                            response = ListaReservas(JsonConvert.DeserializeObject<Cliente>(request.json));
                            break;
                    }
                    writer.Write(JsonConvert.SerializeObject(response));
                }
            }
            catch (Exception)
            {

            }
        }

        private static MensajeSocket Conectado(Cliente buscar)
        {
            Cliente encontrado = ConexionInicio.Iniciar(buscar.clienteId);

            return new MensajeSocket()
            {
                idCliente = 1,
                json = JsonConvert.SerializeObject(encontrado)
            };
        }
        private static MensajeSocket Guardar(Reserva nueva)
        {
            ConexionInicio.Guardar(nueva);

            return new MensajeSocket()
            {
                idCliente = 2
            };
        }
        private static MensajeSocket ListaReservas(Cliente buscar)
        {
            List<Reserva> lista = ConexionInicio.ListaReservas(buscar.clienteId);

            return new MensajeSocket()
            {
                idCliente = 3,
                json = JsonConvert.SerializeObject(lista)
            };
        }

    }
}
