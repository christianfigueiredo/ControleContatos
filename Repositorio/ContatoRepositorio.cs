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
        public Contato ListarPorId(int id)
        {
            return _dbcontext.Contato.FirstOrDefault(x=>x.Id==id);
        }
         public List<Contato> BuscarTodos()
        {
           return _dbcontext.Contato.ToList();
        }
        public Contato Adicionar(Contato contato)
        {
            //gravação no banco de dados
            _dbcontext.Contato.Add(contato);
            _dbcontext.SaveChanges();
            return contato; 

        }
        public Contato Atualizar(Contato contato)
        {
            Contato contatoDB = ListarPorId(contato.Id);
            
            if(contatoDB == null ) throw new System.Exception("Houve um erro na atualização do banco");
            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Celular = contato.Celular;
            _dbcontext.Contato.Update(contatoDB);
            _dbcontext.SaveChanges();
            return contatoDB;

        }

        public bool Apagar(int id)
        {
            Contato contatoDB = ListarPorId(id);
            if(contatoDB == null ) throw new System.Exception("Houve um erro na delecao do Registro");
            _dbcontext.Contato.Remove(contatoDB);
            _dbcontext.SaveChanges();
            return true;


        }
    }
}