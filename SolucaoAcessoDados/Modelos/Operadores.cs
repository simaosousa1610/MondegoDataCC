using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    [Table("Operadores")]
    public class Operadores
    {
        [Key]
        public int intCodigo { get; set; }

        [Required]
        [StringLength(50)]
        [Column]
        public string strNome { get; set; }

        [Required]
        [Column]
        public byte[] strPasswordHash { get; set; }

        [Required]
        [Column]
        public float fltPrecoHora { get; set; }

        [Required]
        [Column]
        public bool bitAtivo { get; set; }
    }
}
