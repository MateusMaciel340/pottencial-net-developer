using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedades_metodos_construtores.Models
{
    public class Pessoa
    {
        // [1.15]: Trabalhando com construtores
        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)
        {
            // [1.16]: Implementando construtor
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // [1.3]: Propriedades na prática

        // [1.5]: Validações no GET e SET
        private string _nome;

        // [1.7]: Validando a propriedade idade
        private int _idade;

        public string Nome
        {
            /* get
            {
                return _nome.ToUpper();
            } */

            // [1.6]: Body Expressions
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vázio!");
                }

                _nome = value;
            }
        }

        // [1.9]: Propriedades somente leitura
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que 0!");
                }

                _idade = value;
            }
        }

        // [1.4]: Criando um método
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto} - Idade: {Idade}");
        }
    }
}