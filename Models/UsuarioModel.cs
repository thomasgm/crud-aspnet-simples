using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace AppMVC.Models
{
    public class UsuarioModel
    {
        [Key]

        public int Id { get; set; }
        [MaxLength(60)]

        public string Nome { get; set; }
        [MaxLength(80)]

        public string Email { get; set; }
        [MaxLength(10, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
        [MinLength(6, ErrorMessage = "O campo {0} deve ter no mínimo {1} caracteres.")]

        public string Senha { get; set; }
        public bool Administrador { get; set; } = false;

        public bool Ativo { get; set; } = true;

        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public DateTime? DataDaInativacao { get; set; }
    }
}
