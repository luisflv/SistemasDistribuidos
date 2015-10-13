using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServidorSocket
{
    class Program
    {
        static void Main(string[] args)
        {

            int portNumber = 3000;

            IPAddress ip = IPAddress.Parse("127.0.0.1");

            TcpListener server = new TcpListener(ip, portNumber);

            server.Start();

            while (true){
                TcpClient client = server.AcceptTcpClient();

                NetworkStream  stream = client.GetStream();

                //Envia mensagem para o cliente
                StreamWriter writer = new StreamWriter(stream);

                Console.WriteLine("Digite um texto:");

                var msg = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                writer.WriteLine(msg);

                writer.Flush();

                //Recebe mensagem do cliente
                StreamReader reader = new StreamReader(stream);


                var text = reader.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(text);

            }




             

        }
    }
}
