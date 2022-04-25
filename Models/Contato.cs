using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleContatos.Models
{
    [Table("CONTATO")]
    public class Contato
    {
        
        [Key]
        [Display(Name ="Código")]
        public int Id { get; set; }

        [Display(Name ="Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name ="email")]
        [Column("Email")]
        public string Email { get; set; }

        [Display(Name ="Celular")]
        [Column("Celular")]
        public string Celular { get; set; }
    }
}