using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Aplicacao
    {
        public int IntCodigo { get; set; }
        public string StrNome { get; set; }
        public bool BitAtivo { get; set; }

        public void ValidateArgs()
        {
            if (StrNome == null || StrNome.Length == 0)
            {
                throw new ArgumentException("Nome da aplicação não pode ser vazio");
            }
            if (BitAtivo == null)
            {
                throw new ArgumentException("Ativo deve ser verdadeiro ou falso");
            }
        }
    }
}
