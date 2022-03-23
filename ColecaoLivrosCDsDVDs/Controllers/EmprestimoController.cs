using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Servico.CDs;
using ColecaoLivrosCDsDVDs.Servico.DVDs;
using ColecaoLivrosCDsDVDs.Servico.Emprestimo;
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
        private readonly IEmprestimoServico _emprestimoServico;
        public EmprestimoController(ICdServico cdServico,
            IDvdServico dvdServico,
            ILivroServico livroServico,
            IEmprestimoServico emprestimoServico)
        {
            _cdServico = cdServico;
            _dvdServico = dvdServico;
            _livroServico = livroServico;
            _emprestimoServico = emprestimoServico;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EfetuarEmprestimoLivro(int id)
        {
            _emprestimoServico.EfetuarEmprestimoLivro(id);
            return Redirect("Index");
        }

        [HttpPost]
        public IActionResult EfetuarEmprestimoCd(int cd)
        {
            _emprestimoServico.EfetuarEmprestimoCd(cd);
            return Redirect("Index");
        }

        [HttpPost]
        public IActionResult EfetuarEmprestimoDvd(int cd)
        {
            _emprestimoServico.EfetuarEmprestimoDvd(cd);
            return Redirect("Index");
        }
    }
}
