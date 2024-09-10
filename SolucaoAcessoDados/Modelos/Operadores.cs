using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;

namespace Modelos
{
    [Table("Operadores")]
    public class Operadores
    {
        [Key]
        public int intCodigo { get; set; }

        [Required]
        [StringLength(50)]
        public string strNome { get; set; }

        [Required]
        public byte[] strPasswordHash { get; set; }

        [Required]
        public byte[] strPasswordSalt { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public float fltPrecoHora { get; set; }

        [Required]
        public bool bitAtivo { get; set; }

        public void SetPassword(string password)
        {
            using (var hmac = new HMACSHA512())
            {
                strPasswordSalt = hmac.Key; // 64 bytes
                strPasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public bool VerifyPassword(string password)
        {
            using (var hmac = new HMACSHA512(strPasswordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != strPasswordHash[i]) return false;
                }
            }
            return true;
        }
    }
}
