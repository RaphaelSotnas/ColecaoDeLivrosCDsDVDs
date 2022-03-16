using ColecaoLivrosCDsDVDs.Contrato;
using ColecaoLivrosCDsDVDs.Models;
using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Repository;
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
        private readonly IItensService _itensService;

        public ColecaoController(IItensService itensService)
        {
            _itensService = itensService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CadastrarItem(Itens item)
        {

            return View();
        }

        [HttpGet]
        public IActionResult PaginaCadastrarPessoa()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarPessoa(PessoaRequest pessoa)
        {
            var request = MapearParaPessoa(pessoa);

            _itensService.CadastrarPessoa(request);

            return RedirectToAction("ListarPessoas");
        }

        private Pessoa MapearParaPessoa(PessoaRequest pessoa)
        {
            return new Pessoa
            {
                Email = pessoa.Email,
                Endereço = pessoa.Endereço,
                Nome = pessoa.Nome,
                Sobrenome = pessoa.Sobrenome,
                Telefone = pessoa.Telefone,
            };
        }

        [HttpGet]
        public IActionResult ListarItens()
        {


            return View();
        }

        [HttpGet]
        public IActionResult ListarPessoas()
        {
            try
            {
                var pessoas = _itensService.ListarPessoas();
                return View(pessoas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
