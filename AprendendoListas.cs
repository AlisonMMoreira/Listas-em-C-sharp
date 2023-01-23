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

// 2ª forma de exibir um determinado conteúdo de dentro da lista, é usando a função de tamanho, exemplo.

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


            //na linha abaixo é possível ver que o <code>FindAll</code> consegue filtrar os dados que conhetam até o tamanho determinado pelo desenvolvedor.
          List<string> filtrada = clientes.FindAll(cliente => cliente.Length < 5);
          Console.WriteLine("=====================");

          foreach (string cliente in filtrada)
          {
            Console.WriteLine(cliente);
          }

    }
  }
}
