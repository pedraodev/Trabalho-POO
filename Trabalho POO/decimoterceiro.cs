using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    internal class decimoterceiro
    {
        public double salarioliquido { get; set; }

        public double mesestrabalhados { get; set; }

        public double calculodecimo()
        {
            return salarioliquido * mesestrabalhados / 12;
        }

        public double valordecimo()
        {
            return calculodecimo();
        }
    }
}
