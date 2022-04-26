using System.Collections.Generic;
using ControleContatos.Models;

namespace ControleContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        Contato ListarPorId(int id);
         List<Contato> BuscarTodos();
         Contato Adicionar(Contato contato);

         Contato Atualizar(Contato contato);
         

    }
}