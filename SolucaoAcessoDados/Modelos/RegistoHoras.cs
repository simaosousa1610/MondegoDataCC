using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    [Table("RegistoHoras")]
    public class RegistoHoras
    {
        [Key]
        public int intCodigo { get; set; }

        [Required]
        public int intOperador { get; set; }

        [ForeignKey("intOperador")]
        public virtual Operadores Operadores { get; set; }

        [Required]
        public DateTime dtmInicio { get; set; }

        [Required]
        public DateTime dtmFim { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public float fltPrecoHora { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public float fltPrecoTotal { get; set; }

        [Required]
        public bool bitValidado { get; set; }

        [Required]
        public bool bitAtivo { get; set; }

    }
}
