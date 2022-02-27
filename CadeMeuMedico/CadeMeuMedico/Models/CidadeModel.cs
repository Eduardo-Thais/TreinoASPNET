using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadeMeuMedico.Models
{
    public class CidadeModel
    {
        [Key]
        public int IDCidade { get; set; }
        public string Nome { get; set; }

        
        public virtual ICollection<MedicoModel> FKMedico { get; set; }
        
    }
}
