using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    [Table("Historico")]
    public class Historico
    {
        [Key]
        public int intCodigo { get; set; }

        [Required]
        public int intOperador { get; set; }

        [ForeignKey("intOperador")]
        public virtual Operadores Operadores { get; set; }

        [Required]
        public int enuAcao { get; set; }
        
        public string jsoDados { get; set; }

        [Required]
        public DateTime dtmDataAcao { get; set; }

    }
}
