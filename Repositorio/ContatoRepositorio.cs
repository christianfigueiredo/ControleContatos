using System.Collections.Generic;
using System.Linq;
using ControleContatos.Data;
using ControleContatos.Models;

namespace ControleContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly DBContext _dbcontext;
        public ContatoRepositorio(DBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public Contato Adicionar(Contato contato)
        {
            //gravação no banco de dados
            _dbcontext.Contato.Add(contato);
            _dbcontext.SaveChanges();
            return contato; 

        }

        public List<Contato> BuscarTodos()
        {
           return _dbcontext.Contato.ToList();
        }
    }
}