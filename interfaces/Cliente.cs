using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal class Cliente: IPessoa
    {
        public string Nome { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Cliente: {Nome}");
        }

    }
}
