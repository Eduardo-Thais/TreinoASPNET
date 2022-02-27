using System.ComponentModel.DataAnnotations;

namespace CadeMeuMedico.Models
{
    public class UsuarioModel
    {
        [Key]
        public int IDUsuario { get; set; }
        public string Nome { get; set; }   
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}
