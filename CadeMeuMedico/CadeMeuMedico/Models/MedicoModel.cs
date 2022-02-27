using System.ComponentModel.DataAnnotations;

namespace CadeMeuMedico.Models
{
    public class MedicoModel
    {
        [Key]
        public int IDMedico { get; set; }
        public string CRM { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Email { get; set; }
        public bool AtendePorConvenio { get; set; }
        public bool TemClinica { get; set; }
        public string WebsiteBlog { get; set; }

        //Criação das chaves estrangeiras para se conectar com tabela cidade e especialidade
        public virtual CidadeModel FKCidade { get; set; }
        public virtual EspecialidadeModel FKEspecialidade { get; set; }


    }
}
