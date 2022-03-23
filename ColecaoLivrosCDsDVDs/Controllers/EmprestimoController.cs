using ColecaoLivrosCDsDVDs.Servico.CDs;
using ColecaoLivrosCDsDVDs.Servico.DVDs;
using ColecaoLivrosCDsDVDs.Servico.Livros;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Controllers
{
    public class EmprestimoController : Controller
    {
        private readonly ICdServico _cdServico;
        private readonly IDvdServico _dvdServico;
        private readonly ILivroServico _livroServico;
        public EmprestimoController(ICdServico cdServico, 
            IDvdServico dvdServico,
            ILivroServico livroServico)
        {
            _cdServico = cdServico;
            _dvdServico = dvdServico;
            _livroServico = livroServico;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PaginaDeEmprestimo()
        {
            return View();
        }

    }
}
