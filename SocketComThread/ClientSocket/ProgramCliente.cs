using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace ClientSocket
{
    class ProgramCliente
    {
        private static void Main(string[] args)
        {
            Thread thread = new Thread(() => ClienteSocket());
            thread.Start();
        }

        public static void ClienteSocket()
        {
            // Cria o socket client
            TcpClient client = new TcpClient();
            // Conecta o socket Server
            client.Connect("127.0.0.1", 2100);

            // Obtem o Stream de comunicação
            NetworkStream stream = client.GetStream();


            // Envia mensagem para o Servidor
            StreamWriter writer = new StreamWriter(stream);

            Console.WriteLine("Digite um texto: ");
            var msg = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            writer.WriteLine(msg);
            writer.Flush();

            // Recebe mensagem do Servidor
            StreamReader reader = new StreamReader(stream);
            var text = reader.ReadLine();

            Console.WriteLine(text);
            Console.ReadKey();
        } 
    }
}
