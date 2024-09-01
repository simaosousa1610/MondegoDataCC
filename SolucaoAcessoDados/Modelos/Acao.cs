using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    [Table("Acao")]
    public class Acao
    {
        [Key]
        public int intCodigo { get; set; }

        [Required]
        [Column]
        public string tipo { get; set; }
    }
}
