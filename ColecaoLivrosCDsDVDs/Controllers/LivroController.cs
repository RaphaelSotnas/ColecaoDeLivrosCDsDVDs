using ColecaoLivrosCDsDVDs.Contrato;
using ColecaoLivrosCDsDVDs.Models;
using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Servico.Livros;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroServico _livroServico;
        public LivroController(ILivroServico livroServico)
        {
            _livroServico = livroServico;        
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PaginaCadastrarLivro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarLivro(LivroRequest request)
        {
            var livro = MapearLivro(request);

            _livroServico.Cadastrar(livro);

            return RedirectToAction("ListarLivros");
        }

        private Livro MapearLivro(LivroRequest request)
        {
            return new Livro
            {
                Autor = request.Autor,
                Genero = request.Genero,
                Nome = request.Nome,
                Status = request.Status,
            };
        }

        [HttpGet]
        public IActionResult PaginaEditarLivro(int id)
        {
            if (id == 0)
                return BadRequest();

            var livro = _livroServico.BuscarPorId(id);
            if (livro == null)
                return NotFound();

            return View(livro);
        }

        [HttpPost]
        public IActionResult EditarLivro(Livro livro)
        {
            try
            {
                _livroServico.Atualizar(livro);
                return RedirectToAction("ListarLivros");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public IActionResult ListarLivros()
        {
            try
            {
                var livros = _livroServico.Listar();
                return View(livros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public IActionResult PaginaDetalhesLivro(int id)
        {
            if (id == 0)
                return BadRequest();

            var livro = _livroServico.BuscarPorId(id);
            if (livro == null)
                return NotFound();

            return View(livro);
        }

        [HttpGet]
        public IActionResult PaginaExcluirLivro(int id)
        {
            if (id == 0)
                return BadRequest();

            var livro = _livroServico.BuscarPorId(id);
            if (livro == null)
                return NotFound();

            return View(livro);
        }

        [HttpPost]
        public IActionResult ExcluirLivro(int id)
        {
            try
            {
                _livroServico.Excluir(id);
                return RedirectToAction("ListarLivros");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

