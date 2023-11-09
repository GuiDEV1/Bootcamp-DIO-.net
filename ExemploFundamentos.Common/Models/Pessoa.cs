using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exemplos_fundamentos.Models;

namespace ExemploFundamentos.Common.Models
{
    public class Pessoa
    {
       public string? Nome { get; set; }
       public int Idade { get; set; } 
       public string? NomeRepresentanteLegal { get; set; } 

       public void Apresentar()
       {
         Console.WriteLine($"Olá, meu nome é {Nome}, \n e tenho {Idade} anos");
       }
    }
}
