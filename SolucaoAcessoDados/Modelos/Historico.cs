using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Historico
    {
        public int IntCodigo { get; set; }
        public int IntOperador { get; set; }
        public int EnuAcao { get; set; }
        public string JsoDados { get; set; }
        public DateTime DtmDataAcao { get; set; }

        public void ValidateArgs()
        {
            if (IntOperador <= 0)
            {
                throw new ArgumentException("Código do operador deve ser maior que zero");
            }
            if (EnuAcao <= 0)
            {
                throw new ArgumentException("Operação deve ser maior que zero");
            }
            if (DtmDataAcao == null)
            {
                throw new ArgumentException("Data da ação não pode ser nula");
            }
        }
    }

    
}
