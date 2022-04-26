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

        [Required(ErrorMessage = "Digite o nome do contato.")]
        [Display(Name ="Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o email do contato.")]
        [EmailAddress(ErrorMessage = "O e-mail informado nao é válido.")]
        [Display(Name ="email")]
        [Column("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o celular do contato.")]
        [Phone(ErrorMessage = "o Celular informado não é válido.")]
        [Display(Name ="Celular")]
        [Column("Celular")]
        public string Celular { get; set; }
    }
}