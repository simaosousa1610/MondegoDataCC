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
        public int intOperador { get; set; }
        public int enuAcao { get; set; }
        public string jsoDados { get; set; }
        public DateTime dtmDataAcao { get; set; }

        public void ValidateArgs()
        {
            if (intOperador <= 0)
            {
                throw new ArgumentException("Código do operador deve ser maior que zero");
            }
            if (enuAcao <= 0)
            {
                throw new ArgumentException("Operação deve ser maior que zero");
            }
            if (dtmDataAcao == null)
            {
                throw new ArgumentException("Data da ação não pode ser nula");
            }
        }
    }

    
}
