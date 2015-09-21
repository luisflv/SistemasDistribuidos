using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadMonitor
{
    class Program
    {
        
        private static int opcao;
        private static List<string> _arquivos;
        private static readonly object Lock = new object();
        private static string caminhoOrigem = @"";
        private static string caminhoDestino = @"";
        private static void Main(string[] args)
        {
            Menu();

            _arquivos = Directory.GetFiles(caminhoOrigem).ToList();

            Thread thread = new Thread(MoveFile);

            MenuOpcoes(thread);

            Console.ReadKey();
        }
        private static void MoveFile()
        {
            do
            {
                lock (Lock)
                {
                    string item = _arquivos.FirstOrDefault();



                    if (File.Exists(item))
                    {
                        _arquivos.Remove(item);

                        FileInfo newFile = new FileInfo(item);

                        string newFileName = newFile.Name.Replace(newFile.Extension, "") + newFile.Extension;

                        string newFilePath = Path.Combine(caminhoDestino, newFileName);

                        File.Move(item, newFilePath);


                    }
                }
            } while (_arquivos.Count > 0);
        }
        
        private static void Menu()
        {
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║    Informe o caminho de origem:    ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            caminhoOrigem = Console.ReadLine();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║    Informe o caminho de destino:   ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            caminhoDestino = Console.ReadLine();
        }

        private static void MenuOpcoes(Thread thread)
        {
            Console.Clear();

            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║     Informe a opcao desejada:     ║");           
            Console.WriteLine("║              1- START             ║");
            Console.WriteLine("║              2- PAUSE             ║");
            Console.WriteLine("║              3- RESUME            ║");
            Console.WriteLine("║              4- EXIT              ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    thread.Start();
                    //Console.WriteLine("Start...");
                    //Console.ReadKey();
                    MenuOpcoes(thread);

                    break;
                case 2:
                    Console.Clear();
                    thread.Interrupt();
                    //Console.WriteLine("Pause...");
                    //Console.ReadKey();
                    MenuOpcoes(thread);

                    break;
                case 3:
                    Console.Clear();
                    thread.Resume();
                    //Console.WriteLine("Resume...");
                    //Console.ReadKey();
                    MenuOpcoes(thread);

                    break;
                case 4:
                    Console.Clear();
                    thread.Suspend();
                    //Console.WriteLine("Suspend");
                    //Console.ReadKey();
                    MenuOpcoes(thread);

                    break;
                default:
                    Console.WriteLine("Este comando nao e valido!Tente novamente.");
                    break;
            }
        }

      
    }
}
