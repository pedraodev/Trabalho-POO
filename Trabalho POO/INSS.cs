using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    internal class INSS
    {
        public double Aliquota { get; set; }
        
        public double Desconto { get; set; }

        public double DescontoINSS(double salario = 1500)

        //Metodo para calcular o desconto do INSS
        {
            double descontoINSS = 0;


            if (salario <= 1320)
            {
                descontoINSS = 0;
            }
            else if (salario < 2571.29)
            {
                descontoINSS = salario * 0.9;
            }
            else if (salario < 3856.95)
            {
                descontoINSS = salario * 0.12;
            }
            else
            {
                descontoINSS = salario * 0.14;
            }
                Desconto = descontoINSS;

                return descontoINSS;
            

        }

            
    }
}
