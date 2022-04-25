using System.ComponentModel.DataAnnotations;

namespace ControleContatos.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }
        
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
    }
}