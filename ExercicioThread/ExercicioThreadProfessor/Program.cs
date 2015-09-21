using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExercicioThreadProfessor
{
    class Program
    {

        private static List<string> sourceFiles;

        private static readonly object locker = new object();

        private static readonly string InputPath = @"C:\PASTA_ORIGEM\";

        private static readonly string OutputPath = @"C:\PASTA_DESTINO\";

        //thread mover arquivo
        static void Main(string[] args)
        {

            //Thread.CurrentThread.Name = "T1";

            sourceFiles = Directory.GetFiles(InputPath).ToList();

            Thread t1 = new Thread(MoveFiles);
            Thread t2 = new Thread(MoveFiles);


            t1.Name = "T1";
            t2.Name = "T2";

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine("Arquivos copiados com sucesso!");

            Console.ReadKey();

        }

        private static void MoveFiles()
        {

            do
            {
                lock (locker);
                string item = sourceFiles.FirstOrDefault();

                if (File.Exists(item))
                {

                    sourceFiles.Remove(item);

                    FileInfo file = new FileInfo(item);

                    //arquivo1-T1.txt
                    string newFileName = file.Name.Replace(file.Extension, "")
                        + "-" + Thread.CurrentThread.Name 
                        + file.Extension;

                    //C:\temp\NewLog\arquivo-T1.txt
                    string newFIlePath = Path.Combine(OutputPath, newFileName);

                    //CTRL X AND CTRL Z
                    File.Move(item, newFIlePath);

                   // Console.WriteLine("Caminho: {0} - Nome: {1} - Extensao {2}", item, file.FullName, file.Extension);
                }  
                
            } while (sourceFiles.Count > 0);
        }

    }
}
