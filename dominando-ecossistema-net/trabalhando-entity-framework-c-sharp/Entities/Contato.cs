using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// [1.4]: Criando a classe entidade
namespace trabalhando_entity_framework_c_sharp.Entities
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}