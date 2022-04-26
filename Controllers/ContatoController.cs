using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ControleContatos.Models;
using ControleContatos.Repositorio;

namespace ControleContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            List<Contato> contatos = _contatoRepositorio.BuscarTodos();
            
            return View(contatos);
        }
        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            Contato contato = _contatoRepositorio.ListarPorId(id);

            return View(contato);
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        }

               
    }
}
