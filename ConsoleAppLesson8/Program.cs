using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppLesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\Users\User\source\repos\ConsoleAppLesson8";
            if (Directory.Exists(path))
            {
                Console.WriteLine("Исходная директория {0} существует", path);
                _DirectoryList(path);

                string[] vs = Directory.GetDirectories(path);
                foreach (string v in vs)
                {
                   _DirectoryList(v);
                }

            }
            else
            {
                Console.WriteLine("Указанной директории {0} не существует", path);
            }
            Console.ReadKey();
        }
        static void _DirectoryList(string _path)
        {
            string[] gD = Directory.GetDirectories(_path); 
            string[] gF = Directory.GetFiles(_path);
            Console.WriteLine("___");
            Console.WriteLine("Директория {0} содержит поддиректории", _path);
            foreach (string v in gD)
            {
                Console.WriteLine(" {0} ", v);
            }
            Console.WriteLine("Директория {0} содержит файлы", _path);
            foreach (string v in gF)
            {
                Console.WriteLine(" {0} ", v);
            }
        }
    }
}
