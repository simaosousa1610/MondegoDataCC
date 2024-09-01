using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    [Table("Aplicacao")]
    public class Aplicacao
    {
        [Key]
        public int intCodigo { get; set; }

        [Required]
        public string strNome { get; set; }
        
        [Required]
        public bool bitAtivo { get; set; }

    }
}
