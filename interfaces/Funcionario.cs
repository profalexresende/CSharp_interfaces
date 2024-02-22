using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal class Funcionario: IPessoa
    {

        public string Nome { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Funcionário: {Nome}");
        }

    }
}
