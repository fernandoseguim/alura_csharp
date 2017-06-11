using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorTextoByCMD
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem vindo ao Editor de Texto do CMD!");
            Console.WriteLine("Digite um texto");
            
            string line = Console.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = Console.ReadLine();
            }


        }
    }
}
