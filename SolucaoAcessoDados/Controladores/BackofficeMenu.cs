using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    
    public class BackofficeMenu
    {
        public ApplicationDbContext _context = new ApplicationDbContext();
        public List<Operadores> ListOperadores()
        {
            var operadores = _context.Operadores.ToList();
            return operadores;
        }

        public List<Acesso> ListAcessos()
        {
            var acessos = _context.Acesso.ToList();
            return acessos;
        }

        public List<Aplicacao> ListAplicacoes()
        {
            var aplicacoes = _context.Aplicacoes.ToList();
            return aplicacoes;
        }

        public List<RegistoHoras> ListRegistosHoras()
        {
            var registosHoras = _context.RegistosHoras.ToList();
            return registosHoras;
        }

        public List<Historico> ListHistorico()
        {
            var historico = _context.Historico.ToList();
            return historico;
        }

        public Operadores GetOperador(int id)
        {
            var operador = _context.Operadores.Find(id);
            return operador;
        }

        public Acesso GetAcesso(int id)
        {
            var acesso = _context.Acesso.Find(id);
            return acesso;
        }

        public Aplicacao GetAplicacao(int id)
        {
            var aplicacao = _context.Aplicacoes.Find(id);
            return aplicacao;
        }

        public RegistoHoras GetRegistoHoras(int id)
        {
            var registoHoras = _context.RegistosHoras.Find(id);
            return registoHoras;
        }

        public Historico GetHistorico(int id)
        {
            var historico = _context.Historico.Find(id);
            return historico;
        }

        public Acao GetAcao(int id)
        {
            var acao = _context.Acao.Find(id);
            return acao;
        }

        public List<Acao> ListAcao()
        {
            var acoes = _context.Acao.ToList();
            return acoes;
        }


        public int EditOperador(Operadores operador)
        {
            try
            {
                var operadorInDb = _context.Operadores.Find(operador.intCodigo);
                if(operadorInDb == null){ return -1; }
                operadorInDb.strNome = operador.strNome;
                operadorInDb.fltPrecoHora = operador.fltPrecoHora;
                operadorInDb.bitAtivo = operador.bitAtivo;

                _context.SaveChanges();

                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public int AddOperador(Operadores operador)
        {
            try
            {
                _context.Operadores.Add(operador);
                _context.SaveChanges();

                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public int EditAcesso(Acesso acesso)
        {
            try
            {
                var acessoInDb = _context.Acesso.Find(acesso.intCodigo);
                if (acessoInDb == null) { return -1; }
                acessoInDb.intOperador = acesso.intOperador;
                acessoInDb.strToken = acesso.strToken;
                acessoInDb.bitAtivo = acesso.bitAtivo;
                _context.SaveChanges();

                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public int AddAcesso(Acesso acesso)
        {
            try
            {
                _context.Acesso.Add(acesso);
                _context.SaveChanges();

                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
                return -1;
            }
        }
    }
}
