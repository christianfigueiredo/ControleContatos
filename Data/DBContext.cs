
using ControleContatos.Models;

using Microsoft.EntityFrameworkCore;

namespace ControleContatos.Data
{
    public class DBContext : DbContext
    {

        
        
        public DBContext(DbContextOptions<DBContext> options): base(options){}
        public DbSet<Contato> Contato {get;set;}
        public DbSet<Usuario> Usuario {get;set;}
       
    }

}