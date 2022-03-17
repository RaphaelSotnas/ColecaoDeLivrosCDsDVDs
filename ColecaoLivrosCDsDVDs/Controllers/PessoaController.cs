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
    public class PessoaController : Controller
    {
        private readonly IPessoaServico _pessoaServico;

        public PessoaController(IPessoaServico pessoaServico)
        {
            _pessoaServico = pessoaServico;
        }

        public IActionResult Index()
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

            _pessoaServico.CadastrarPessoa(request);

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
        public IActionResult PaginaEditarPessoa(int id)
        {
            if (id == 0)
                return BadRequest();

            var pessoa = _pessoaServico.BuscarPessoaPorId(id);
            if (pessoa == null)
                return NotFound();

            return View(pessoa);
        }

        [HttpPost]
        public IActionResult EditarPessoa(Pessoa pessoa)
        {
            try
            {
                _pessoaServico.AtualizarPessoa(pessoa);
                return RedirectToAction("ListarPessoas");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public IActionResult ListarPessoas()
        {
            try
            {
                var pessoas = _pessoaServico.ListarPessoas();
                return View(pessoas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public IActionResult PaginaDetalhesPessoa(int id)
        {
            if (id == 0)
                return BadRequest();

            var pessoa = _pessoaServico.BuscarPessoaPorId(id);
            if (pessoa == null)
                return NotFound();

            return View(pessoa);
        }

        [HttpGet]
        public IActionResult PaginaExcluirPessoa(int id)
        {
            if (id == 0)
                return BadRequest();

            var pessoa = _pessoaServico.BuscarPessoaPorId(id);
            if (pessoa == null)
                return NotFound();

            return View(pessoa);
        }

        [HttpPost]
        public IActionResult ExcluirPessoa(int id)
        {
            try
            {
                _pessoaServico.ExcluirPessoa(id);
                return RedirectToAction("ListarPessoas");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
