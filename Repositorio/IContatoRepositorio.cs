using System.Collections.Generic;
using ControleContatos.Models;

namespace ControleContatos.Repositorio
{
    public interface IContatoRepositorio
    {
         List<Contato> BuscarTodos();
         Contato Adicionar(Contato contato);
         

    }
}