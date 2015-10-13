using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServidosSocket
{
    class ProgramServidor
    {
        private static string msg = "";
        private static void Main(string[] args)
        {
            ServidorSocket();
        }


        private static void ThreadChat(TcpClient socket)
        {
            new Thread(() => StartWriteThread(socket)).Start();
            new Thread(() => StartReaderThread(socket)).Start();

        }

        private static void StartReaderThread(TcpClient socket)
        {
            NetworkStream stream = socket.GetStream();

            StreamReader reader = new StreamReader(stream);

            while (msg != "exit")
            {
                msg = reader.ReadLine();
                Console.WriteLine(msg);
            }
        }

        private static void StartWriteThread(TcpClient socket)
        {
            NetworkStream stream = socket.GetStream();

            StreamWriter writer = new StreamWriter(stream);

            Console.WriteLine("Digite um texto: ");
            msg = string.Empty;

            while (msg != "exit")
            {
                msg = Console.ReadLine();
                writer.WriteLine(msg);
                writer.Flush();
            }
        }

        public static void ServidorSocket()
        {
            int port = 5000;
            string ip = "172.16.2.80";

            IPAddress ipAddress = IPAddress.Parse(ip);

            //Cria o Socket Server
            TcpListener server = new TcpListener(ipAddress, port);
            //Inicia o Socket
            server.Start();

            while (true)
            {
               ThreadChat(server.AcceptTcpClient());
            }
        }
    }
}
