using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    internal class salariomes
    {
        public double valorhora { get; set; }

        public double horastrabalhadas { get; set; }

        public double valorsalario()
        {
            return valorhora * horastrabalhadas;
        }
        public double SalarioLiquido()
        {
            return 0;
        }
    }
    
}
