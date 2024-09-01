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
        public int intOperador { get; set; }
        public DateTime dtmInicio { get; set; }
        public DateTime dtmFim { get; set; }
        public float fltPrecoHora { get; set; }
        public float fltPrecoTotal { get; set; }
        public bool bitValidado { get; set; }
        public bool bitAtivo { get; set; }

        public void ValidateArgs()
        {
            if (intOperador <= 0)
            {
                throw new ArgumentException("Código do operador deve ser maior que zero");
            }
            if (dtmInicio == null)
            {
                throw new ArgumentException("Data de início não pode ser nula");
            }
            if (dtmFim == null)
            {
                throw new ArgumentException("Data de fim não pode ser nula");
            }
            if (fltPrecoHora <= 0)
            {
                throw new ArgumentException("Preço da hora deve ser maior que zero");
            }
            if (fltPrecoTotal <= 0)
            {
                throw new ArgumentException("Preço total deve ser maior que zero");
            }
        }
    }
}
