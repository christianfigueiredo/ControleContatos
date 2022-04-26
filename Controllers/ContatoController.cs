﻿using System;
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
        public IActionResult ApagarConfirmacao(int id)
        {
            Contato contato = _contatoRepositorio.ListarPorId(id);

            return View(contato);
        }
        public IActionResult Apagar(int id)
        {
            try
            {
               bool apagado = _contatoRepositorio.Apagar(id);
               if(apagado)
               {
                   TempData["MensagemSucesso"] = "Contato apagado com sucesso!";                

               }
               else
               {
                    TempData["MensagemErro"]="Ops, não conseguimos apagar seu contato";
               }
                 return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                
                TempData["MensagemErro"]=$"Ops, não conseguimos apagar seu contato, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }

        }
        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            try
            {
                if(ModelState.IsValid)
            {
                 _contatoRepositorio.Adicionar(contato);
                 TempData["MensagemSucesso"] = "Contato cadastrado com sucesso!";
                 return RedirectToAction("Index");
            }
            return View(contato);
            }
            catch (System.Exception erro)
            {
                
                TempData["MensagemErro"]=$"Ops, não conseguimos cadastrar seu contato, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
           
        }

        [HttpPost]
        public IActionResult Alterar(Contato contato)
        {
           try
           {
                if(ModelState.IsValid)
            {
                  _contatoRepositorio.Atualizar(contato);
                   TempData["MensagemSucesso"] = "Contato alterado com sucesso!";
                  return RedirectToAction("Index");

            }
            return View("Editar",contato);

           }
           catch (System.Exception erro)
           {
               
               TempData["MensagemErro"]=$"Ops, não conseguimos atualizar seu contato, tente novamente, detalhe do erro: {erro.Message}";
               return RedirectToAction("Index");
           }
          
        }

               
    }
}
