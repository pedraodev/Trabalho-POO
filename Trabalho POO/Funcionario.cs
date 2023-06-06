using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    internal class Funcionario
    {
        public string Nome { get; set; }

        //método que tem como função retornar o nome do usuário

        public double CPF { get; set; }
        
        //método que tem como função retornar o CPF do usuário

        public string Endereço { get; set; }
        
        //método que tem como função retornar o Endereço do usuário

        public string Matricula { get; set; }
        
        //método que tem como função retornar a matricula do usuário

        public string cargo { get; set; }
        
        //método que tem como função retornar o cargo do usuário
        public string informacoesbasicas() 
        {
            return Nome + Matricula + cargo;
        }
        
        //Método que tem como função retornar as informações básicas do Funcionário no demonstrativo simples

        public string infocompleta()
        {
            return Nome + CPF + Endereço + Matricula + cargo;
        }
        
        //Método que tem como função retornar as informações completas do Funcionário no demonstrativo completo

    }
}
