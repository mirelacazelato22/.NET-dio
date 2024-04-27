using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
//organiza por afinidade//
{
    public class Pessoa
    //represnetando o molde de uma pessoa//
    {
        public string Nome {get;set;}
        public int Idade {get;set;}
        //o que minha pessoa tem//

        public void Apresentar ()
        //o que minha pessoa vai fazer -- método //
        {
            Console.WriteLine($"Meu nome é {Nome}, e tenho {Idade}, anos ");
            
            
        }
    }
    
}