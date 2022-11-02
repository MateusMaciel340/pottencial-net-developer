using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// [1.8]: Configurando o método na controller
using frontend_asp_net_mvc.Context;

// [1.10]: Implementando o método criar novo POST
using frontend_asp_net_mvc.Models;

// [1.6]: Criando nossa primeira página
namespace frontend_asp_net_mvc.Controllers
{
    public class ContatoController : Controller
    {
        // [1.8]: Configurando o método na controller
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contatos = _context.Contatos.ToList();
            return View(contatos);
        }

        // [1.9]: Criando a página de novo contato
        public IActionResult Criar()
        {
            return View();
        }

        // [1.10]: Implementando o método criar novo POST
        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _context.Contatos.Add(contato);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(contato);
        }

        // [1.12]: Criando a página de edição
        public IActionResult Editar(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
                return RedirectToAction(nameof(Index));

            return View(contato);
        }

        // [1.13]: Criando o POST do editar
        [HttpPost]
        public IActionResult Editar(Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(contato.Id);

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // [1.14]: Criando a página de detalhes
        public IActionResult Detalhes(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
                return RedirectToAction(nameof(Index));

            return View(contato);
        }

        // [1.15]: Criando a página de deletar
        public IActionResult Deletar(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
                return RedirectToAction(nameof(Index));

            return View(contato);
        }

        // [1.16]: Criando o POST do Deletar
        [HttpPost]
        public IActionResult Deletar(Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(contato.Id);

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}