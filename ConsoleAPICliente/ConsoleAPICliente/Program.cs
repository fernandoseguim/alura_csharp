using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPICliente
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const string URI = "http://localhost:56434/api/Carrinho/1";
            string conteudo;
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(URI);
            request.Method = "GET";
            request.Accept = "application/xml";

            WebResponse response = request.GetResponse();
            using(Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                conteudo = reader.ReadToEnd();
            }
            Console.Write(conteudo);
            Console.ReadKey();
        }
    }
}
