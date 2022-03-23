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
    public class UsuarioController : Controller
    {
        private readonly IUsuarioServico _usuarioServico;

        public UsuarioController(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PaginaCadastrarUsuario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(UsuarioRequest usuario)
        {
            var request = MapearParaUsuario(usuario);

            _usuarioServico.Cadastrar(request);

            return RedirectToAction("ListarUsuarios");
        }

        private Usuario MapearParaUsuario(UsuarioRequest usuario)
        {
            return new Usuario
            {
                Login = usuario.Login,
                Senha = usuario.Senha,
                Email = usuario.Email,
                Endereço = usuario.Endereço,
                Nome = usuario.Nome,
                Sobrenome = usuario.Sobrenome,
                Telefone = usuario.Telefone,
            };
        }

        [HttpGet]
        public IActionResult PaginaEditarUsuario(int id)
        {
            if (id == 0)
                return BadRequest();

            var usuario = _usuarioServico.BuscarPorId(id);
            if (usuario == null)
                return NotFound();

            return View(usuario);
        }

        [HttpPost]
        public IActionResult EditarUsuario(Usuario usuario)
        {
            try
            {
                _usuarioServico.Atualizar(usuario);
                return RedirectToAction("ListarUsuarios");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public IActionResult ListarUsuarios()
        {
            try
            {
                var usuarios = _usuarioServico.Listar();
                return View(usuarios);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public IActionResult PaginaDetalhesUsuario(int id)
        {
            if (id == 0)
                return BadRequest();

            var usuario = _usuarioServico.BuscarPorId(id);
            if (usuario == null)
                return NotFound();

            return View(usuario);
        }

        [HttpGet]
        public IActionResult PaginaExcluirUsuario(int id)
        {
            if (id == 0)
                return BadRequest();

            var usuario = _usuarioServico.BuscarPorId(id);
            if (usuario == null)
                return NotFound();

            return View(usuario);
        }

        [HttpPost]
        public IActionResult ExcluirUsuario(int id)
        {
            try
            {
                _usuarioServico.Excluir(id);
                return RedirectToAction("ListarUsuarios");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public IActionResult PaginaLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EfetuarLogin(string login, string senha)
        {
            var usuario = _usuarioServico.EfetuarLogin(login, senha);
            if (usuario != null)
            {
                TempData["loginId"] = usuario.Id;
                TempData["login"] = usuario.Login;

                return Redirect("/Emprestimo/Index");
            }

            return Redirect("Index");
        }

        public IActionResult EfetuarLogout()
        {

            ViewData["loginId"] = null;
            ViewData["login"] = null;

            return RedirectToAction("Index");
        }
    }
}
