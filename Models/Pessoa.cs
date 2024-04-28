using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Models
//organiza por afinidade//


{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Nome = "mirela";
            Idade = 23;
          Console.WriteLine($"Olá meu nome é {Nome} \n e tenho {Idade} anos");

        }
    }
}