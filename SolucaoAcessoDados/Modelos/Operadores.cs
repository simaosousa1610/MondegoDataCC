using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Modelos
{
    public class Operadores
    {
        public int IntCodigo { get; set; }
        private string StrNome { get; set; }
        public byte[] StrPasswordHash { get; set; }
        public float FltPrcoHora { get; set; }
        public bool BitAtivo { get; set; }
        
        public void ValidateArgs ()
        {
            if (StrNome == null || StrNome.Length == 0)
            {
                throw new ArgumentException("Nome do operador não pode ser vazio");
            }
            if (StrPasswordHash == null || StrPasswordHash.Length == 0)
            {
                throw new ArgumentException("Senha do operador não pode ser vazia");
            }
            if (FltPrcoHora <= 0)
            {
                throw new ArgumentException("Preço da hora deve ser maior que zero");
            }
            if (BitAtivo == null)
            {
                throw new ArgumentException("Ativo deve ser verdadeiro ou falso");
            }
        }
    }
}
