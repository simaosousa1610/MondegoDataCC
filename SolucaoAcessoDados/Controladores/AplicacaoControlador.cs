using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelos;
using System.Windows.Forms;
using System.Web.Mvc;

namespace Controladores
{
    public class AplicacaoControlador
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        public string MostrarAplicacoes()
        {
            // Fetch the list of applications from the context
            var apps = _context.Aplicacoes.ToList();

            // Check if the apps list is not null or empty
            if (apps == null || !apps.Any()) {
                return "No applications found!";
            }

            // Construct a string with application details
            var appsString = string.Join(Environment.NewLine,
                                         apps.Select(a => $"ID: {a.intCodigo}, Name: {a.strNome}, Active: {a.bitAtivo}"));

            return appsString;
        }

    }

}

