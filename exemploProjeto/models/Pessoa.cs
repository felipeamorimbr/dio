using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploProjeto.models
{
    public class Pessoa
    {   
        private string _Nome;
        private int _Idade;

        public string Nome 
        { 
            get => _Nome.ToUpper();
            set {
                if (value == ""){
                    throw new ArgumentException("O nome é inválido");
                }
                _Nome = value;
            } 
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade
        {
            get => _Idade;
            set
            {
                if(value < 0){
                    throw new ArgumentException("A idade é inválida");
                }
                _Idade = value;
            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {NomeCompleto} e tenho {Idade} anos.");
        }
    }
}