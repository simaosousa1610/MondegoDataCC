using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Modelos
{
    public class Acesso
    {
        public int IntCodigo { get; set; }
        public int IntOperador { get; set; }
        public int IntAplicacao { get; set; }
        public string StrToken { get; set; }
        public bool BitAtivo { get; set; }
        
        public void ValidateArgs()
        {
            if (IntOperador <= 0)
            {
                throw new ArgumentException("Código do operador deve ser maior que zero");
            }
            if (IntAplicacao <= 0)
            {
                throw new ArgumentException("Código da aplicação deve ser maior que zero");
            }
            if (BitAtivo == null)
            {
                throw new ArgumentException("Ativo deve ser verdadeiro ou falso");
            }
        }
    }
}
