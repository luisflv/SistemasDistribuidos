﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExercicioThread
{
    class Program
    {
        

             private const String diretorioOrigem = "C:\\Programming\\arquivos-teste-threads-csharp\\";
        private const String diretorioDestino = "C:\\Programming\\arquivos-teste-threads-csharp-copiados\\";

        static void Main(string[] args)
        {

            List<String> files = new List<String>();
            files.AddRange(Directory.GetFiles(diretorioOrigem));

            Thread thread1 = new Thread(() => { Move(files.GetRange(0, 5)); });
            thread1.Name = "thread1";
            thread1.Start();

            Thread thread2 = new Thread(() => { Move(files.GetRange(6, 5)); });
            thread2.Name = "thread2";
            thread2.Start();
        }

        static void Move(List<String> files) {
            files.ForEach(file => 
            {
                String arquivo = Path.GetFileName(file);
                File.Move(diretorioOrigem + arquivo, diretorioDestino + Thread.CurrentThread.Name + "." + arquivo);
            });
        }
        }
    
}