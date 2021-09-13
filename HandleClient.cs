using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using Biblioteka;

namespace Server
{
    public class HandleClient : ISocket 
    {
        private readonly TcpClient clientSocket;

        public HandleClient(TcpClient clientSocket) 
        {
            this.clientSocket = clientSocket;
        }

        public void Start()
        {
           var clientThread = new Thread(OdbiórPliku);
           clientThread.Start();
        }

        public void OdbiórPliku() 
        {
            ModelInfo model = Receive();
            
            File.WriteAllBytes(model.FileName + model.Extension, model.Data);
            Console.WriteLine("Zapisano " + model.FileName + model.Extension);
        }

        public ModelInfo Receive()
        {
            NetworkStream stream = clientSocket.GetStream();
            IFormatter formatter = new BinaryFormatter();

            ModelInfo model = (ModelInfo) formatter.Deserialize(stream);
            return model;
        }

        public void Send(ModelInfo model)
        {
           
        }
    }
}