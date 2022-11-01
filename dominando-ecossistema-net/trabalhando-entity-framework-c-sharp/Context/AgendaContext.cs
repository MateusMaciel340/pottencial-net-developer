using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using trabalhando_entity_framework_c_sharp.Entities;

// [1.5]: Criando o Contexto
namespace trabalhando_entity_framework_c_sharp.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }
    }
}