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
                // check if theres an user with active status that has access to the backoffice
                var backOfficeApp = _context.Aplicacoes.FirstOrDefault(ap => ap.strNome == "BackOffice");
                if (backOfficeApp == null) return -1;

                var operadores = _context.Operadores.Where(o => o.bitAtivo == true).ToList();
                if (operadores.Count == 0) return 1;

                var acessos = _context.Acesso.Where(a => a.intAplicacao == backOfficeApp.intCodigo).ToList();
                if (acessos.Count == 0) return 1;

                var backOfficeUsers = operadores
                    .Join(acessos, o => o.intCodigo, a => a.intOperador, (o, a) => new { o, a })
                    .Where(oa => oa.a.bitAtivo == true)
                    .ToList();

                if (backOfficeUsers.Count == 0) return 1;

                return 0;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;
        }

        public string CheckCredentials(string username, string password)
        {
            // Hash the password
            using (var sha1 = new SHA1CryptoServiceProvider())
            {
                var passwordHash = Encoding.ASCII.GetBytes(password);
                var passwordHashed = sha1.ComputeHash(passwordHash);

                try
                {
                    var backOfficeApp = _context.Aplicacoes.FirstOrDefault(ap => ap.strNome == "BackOffice");
                    if (backOfficeApp == null) return "Application not found.";

                    // Load the operator into memory
                    var operador = _context.Operadores
                        .Where(o => o.strNome == username)
                        .ToList()
                        .FirstOrDefault(o => o.strPasswordHash.SequenceEqual(passwordHashed));

                    if (operador == null) return "Not found.";

                    var acesso = _context.Acesso.FirstOrDefault(a => a.intAplicacao == backOfficeApp.intCodigo && a.intOperador == operador.intCodigo);
                    return acesso == null ? "Not found." : "Found.";
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return e.Message;
                }
            }
        }

        public string criarOperadorBackOffice(string username, string password)
        {
            using (var sha1 = new SHA1CryptoServiceProvider())
            {
                var passwordHash = Encoding.ASCII.GetBytes(password);
                var passwordHashed = sha1.ComputeHash(passwordHash);

                try
                {
                    using (var transaction = _context.Database.BeginTransaction())
                    {
                        // Obtém a aplicação BackOffice
                        var backOfficeApp = _context.Aplicacoes.FirstOrDefault(ap => ap.strNome == "BackOffice");
                        if (backOfficeApp == null) return "No backoffice";

                        var operador = new Operadores
                        {
                            strNome = username,
                            strPasswordHash = passwordHashed,
                            fltPrecoHora = 0.0f,
                            bitAtivo = true
                        };

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

                        // debug the result of the add operation
                        Console.WriteLine($"Acesso intCodigo: {acesso.intCodigo}");
                        Console.WriteLine($"Acesso intOperador: {acesso.intOperador}");
                        Console.WriteLine($"Acesso intAplicacao: {acesso.intAplicacao}");
                        Console.WriteLine($"Acesso strToken: {acesso.strToken}");
                        Console.WriteLine($"Acesso bitAtivo: {acesso.bitAtivo}");

                        _context.SaveChanges();

                        transaction.Commit();

                        return "Success";
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception Message: " + e.Message);
                    
                    if( e.InnerException != null ) {
                        Console.WriteLine("Inner Exception Message: " + e.InnerException.Message);
                    }
                    throw;

                    return e.StackTrace;
                }
            }
        }


    }
}
