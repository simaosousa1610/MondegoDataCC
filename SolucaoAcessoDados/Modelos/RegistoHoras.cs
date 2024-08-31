using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class RegistoHoras
    {
        public int IntCodigo { get; set; }
        public int IntOperador { get; set; }
        public DateTime DtmInicio { get; set; }
        public DateTime DtmFim { get; set; }
        public float FltPrecoHora { get; set; }
        public float FltPrecoTotal { get; set; }
        public bool BitValidado { get; set; }
        public bool BitAtivo { get; set; }

        public void ValidateArgs()
        {
            if (IntOperador <= 0)
            {
                throw new ArgumentException("Código do operador deve ser maior que zero");
            }
            if (DtmInicio == null)
            {
                throw new ArgumentException("Data de início não pode ser nula");
            }
            if (DtmFim == null)
            {
                throw new ArgumentException("Data de fim não pode ser nula");
            }
            if (FltPrecoHora <= 0)
            {
                throw new ArgumentException("Preço da hora deve ser maior que zero");
            }
            if (FltPrecoTotal <= 0)
            {
                throw new ArgumentException("Preço total deve ser maior que zero");
            }
            if (BitValidado == null)
            {
                throw new ArgumentException("Validado deve ser verdadeiro ou falso");
            }
            if (BitAtivo == null)
            {
                throw new ArgumentException("Ativo deve ser verdadeiro ou falso");
            }
        }
    }
}
