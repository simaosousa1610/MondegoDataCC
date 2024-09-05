using Modelos;
using System;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Controladores
{
    public class LoginControlador
    {
        public ApplicationDbContext _context = new ApplicationDbContext();

        public int checkIfNoBackOfficeUsers()
        {
            try
            {
                // check if there are any backoffice users in the database with ative access  
                var backOfficeApp = _context.Aplicacoes.FirstOrDefault(ap => ap.strNome == "BackOffice");
                if (backOfficeApp == null) return -1;

                var backOfficeUsers = _context.Acesso
                    .Where(a => a.intAplicacao == backOfficeApp.intCodigo)
                    .ToList()
                    .Where(a => a.bitAtivo == true)
                    .ToList();

                return backOfficeUsers.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;
        }

        public string CheckCredentials(string username, string password, int app)
        {
            try
            {
                // Verificar se o usuário existe e se está ativo
                var operador = _context.Operadores.FirstOrDefault(op => op.strNome == username);
                if (operador == null || !operador.bitAtivo) return "Invalid username or password";

                switch (app)
                {
                    case 1:
                        // Verificar se o usuário tem acesso ao BackOffice
                        var backOfficeApp = _context.Aplicacoes.FirstOrDefault(ap => ap.strNome == "BackOffice");
                        if (backOfficeApp == null) return "No backoffice available";

                        var acesso = _context.Acesso.FirstOrDefault(ac => ac.intOperador == operador.intCodigo && ac.intAplicacao == backOfficeApp.intCodigo);
                        if (acesso == null || !acesso.bitAtivo) return "No access to BackOffice";
                        break;
                    case 2:
                        // Verificar se o usuário tem acesso ao FrontOffice
                        var frontOfficeApp = _context.Aplicacoes.FirstOrDefault(ap => ap.strNome == "FrontOffice");
                        if (frontOfficeApp == null) return "No frontoffice available";

                        var acessoFrontOffice = _context.Acesso.FirstOrDefault(ac => ac.intOperador == operador.intCodigo && ac.intAplicacao == frontOfficeApp.intCodigo);
                        if (acessoFrontOffice == null || !acessoFrontOffice.bitAtivo) return "No access to FrontOffice";
                        break;
                    case 3:
                        // Verificar se o usuário tem acesso ao API
                        var apiApp = _context.Aplicacoes.FirstOrDefault(ap => ap.strNome == "API");
                        if (apiApp == null) return "No API available";

                        var acessoAPI = _context.Acesso.FirstOrDefault(ac => ac.intOperador == operador.intCodigo && ac.intAplicacao == apiApp.intCodigo);
                        if (acessoAPI == null || !acessoAPI.bitAtivo) return "No access to API";
                        break;
                    default:
                        return "Invalid application";
                }

                // Verificar se a senha está correta
                if (!operador.VerifyPassword(password)) return "Wrong Password";

                return "Login Successfull";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Error";
            }
        }

        public string criarOperadorBackOffice(string username, string password)
        {
            try
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    // Obtém a aplicação BackOffice
                    var backOfficeApp = _context.Aplicacoes.FirstOrDefault(ap => ap.strNome == "BackOffice");
                    if (backOfficeApp == null) return "No backoffice available";

                    float fltPrecoHoraFloat = (float) 0;

                    var operador = new Operadores
                    {
                        strNome = username,
                        fltPrecoHora = fltPrecoHoraFloat, 
                        bitAtivo = true
                    };

                    operador.SetPassword(password);

                    _context.Operadores.Add(operador);
                    _context.SaveChanges(); // Salva para garantir que o operador tenha um intCodigo gerado

                    var acesso = new Acesso
                    {
                        intOperador = operador.intCodigo, // Usa o intCodigo gerado
                        intAplicacao = backOfficeApp.intCodigo,
                        strToken = null, // Permite valor nulo para strToken
                        bitAtivo = true
                    };

                    acesso = _context.Acesso.Add(acesso);

                    _context.SaveChanges();

                    transaction.Commit();

                    return "Login Successfull";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Message: " + e.Message);

                if (e.InnerException != null)
                {
                    Console.WriteLine("Inner Exception Message: " + e.InnerException.Message);
                }
                return "Error";
            }
        }
    }
}
