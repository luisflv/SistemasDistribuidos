using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ComandosThread
{
    internal class Program
    {
        private static string _origem = @"";
        private static string _destino = @"";
        private static string _opcao = "";
        private static List<string> _arquivos;
        private static readonly object Lock = new object();
        private static Thread thread = new Thread(MoveFile);


        private static void Main(string[] args)
        {
            Menu();
            _arquivos = Directory.GetFiles(_origem).ToList();
            MenuComandos(thread = new Thread(MoveFile));


            Console.ReadKey();
        }

        private static void Menu()
        {
            Console.WriteLine("Digite o caminho da pasta de origem: ");
            _origem = Console.ReadLine();
            Console.WriteLine("Digite o caminho da pasta de destino: ");
            _destino = Console.ReadLine();
        }

        static void MenuOpcao()
        {
            Console.WriteLine("Digite o comando de execução da Thread: ");
            _opcao = Console.ReadLine();
        }
        private static void MenuComandos(Thread thread)
        {
            MenuOpcao();
            do
            {
                _arquivos = Directory.GetFiles(_origem).ToList();

                switch (_opcao)
                {
                    case "start":
                        Thread.Sleep(3000);
                        thread.Start();
                        MenuComandos(thread = new Thread(MoveFile));
                        break;
                    case "pause":
                        Thread.Sleep(3000);
                        thread.Interrupt();
                        MenuComandos(thread = new Thread(MoveFile));
                        break;
                    case "resume":
                        Thread.Sleep(3000);
                        thread.Resume();
                        MenuComandos(thread = new Thread(MoveFile));
                        break;
                    case "abort":
                        Thread.Sleep(3000);
                        thread.Abort();
                        MenuComandos(thread = new Thread(MoveFile));
                        break;
                    default:
                        Console.WriteLine("Comando incorreto");
                        break;
                }
            } while (_arquivos.Count > 0);
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

                        string newFilePath = Path.Combine(_destino, newFileName);

                        File.Move(item, newFilePath);
                    }
                }
            } while (_arquivos.Count > 0);
        }
    }
}
