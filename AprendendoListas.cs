// Criando uma lista
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> clientes = new List<string>();
            clientes.Add("Yuri");
            clientes.Add("André");
            clientes.Add("marcelo");
            clientes.Add("mateus");
            string fornecedor = "guilherme prata";
            clientes.Add(fornecedor);

            Console.WriteLine("Valores foram inseridos :)");
            Console.ReadLine();
        }
    }
}

// Uma das várias formas de ler as informações de uma lista criada

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> clientes = new List<string>();
            clientes.Add("Yuri");
            clientes.Add("André");
            clientes.Add("marcelo");
            clientes.Add("mateus");
            string fornecedor = "guilherme prata";
            clientes.Add(fornecedor);

            Console.WriteLine("Valores foram inseridos :)");

            foreach (string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }
            
            Console.ReadLine();
        }
    }
}
