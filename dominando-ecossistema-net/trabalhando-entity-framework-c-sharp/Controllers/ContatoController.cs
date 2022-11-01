using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using trabalhando_entity_framework_c_sharp.Context;
using trabalhando_entity_framework_c_sharp.Entities;

// [1.8]: Criando a controller e o endpoint de Create
namespace trabalhando_entity_framework_c_sharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {

        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            //return Ok(contato);

            // [1.15]: Alterando o endpoint create
            return CreatedAtAction(nameof(ObterPorId), new { id = contato.Id }, contato);
        }

        // [1.9]: Criando o endpoint obter por ID
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
                return NotFound();

            return Ok(contato);
        }

        // [1.10]: Criando o endpoint de update
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
                return NotFound();

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
        }

        // [1.11]: Criando o endpoint de delete
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
                return NotFound();

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();
            return NoContent();
        }

        // [1.12]: Criando o endpoint de obter por nome
        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));
            return Ok(contatos);
        }
    }
}