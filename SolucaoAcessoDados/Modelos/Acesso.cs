using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    [Table("Acesso")]
    public class Acesso
    {
        [Key]
        public int intCodigo { get; set; }

        [Required]
        public int intOperador { get; set; }

        [ForeignKey("intOperador")]
        public virtual Operadores Operadores { get; set; }

        [Required]
        public int intAplicacao { get; set; }

        [ForeignKey("intAplicacao")]
        public virtual Aplicacao Aplicacao { get; set; }

        [StringLength(250)]
        public string strToken { get; set; }

        [Required]
        public bool bitAtivo { get; set; }
    }
}
