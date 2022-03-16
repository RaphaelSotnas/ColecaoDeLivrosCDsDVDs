using ColecaoLivrosCDsDVDs.Contrato;
using ColecaoLivrosCDsDVDs.Models;
using ColecaoLivrosCDsDVDs.Servico;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Controllers
{
    public class ColecaoController : Controller
    {
        //private readonly IServicoEmprestimo _servicoEmprestimo;

        //public ColecaoController(IServicoEmprestimo servicoEmprestimo)
        //{
        //    _servicoEmprestimo = servicoEmprestimo;
        //}

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CadastrarItem(Item item)
        {

            return View();
        }

        [HttpGet]
        public IActionResult CadastrarPessoa(PessoaRequest pessoa)
        {


            return View();
        }

        [HttpGet]
        public IActionResult ListarItens()
        {


            return View();
        }
    }
}
