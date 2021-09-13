using System;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using Biblioteka;

namespace Client
{
    public class HandleServer : ISocket
    {
        private readonly  TcpClient clientSocket;
        private readonly  ModelInfo model;

        public HandleServer(string ip, int port, ModelInfo model) // nawiązywanie połączenia
        {
            clientSocket = new TcpClient(ip, port);
            this.model = model;
        }

        public ModelInfo Receive()
        {
            throw new NotSupportedException();
        }

        public void Send(ModelInfo model) //Wysyłanie pliku
        {
            var stream = clientSocket.GetStream();
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, model);

            stream.Close();
        }

        public void Start() //Wielowątkowość
        {
            var wątekKlient = new Thread(WyślijPlik);
            wątekKlient.Start();
        }

        public void WyślijPlik()
        {
            Send(model);
            clientSocket.Close();
        }
    }
}