using ColecaoLivrosCDsDVDs.Contrato;
using ColecaoLivrosCDsDVDs.Models;
using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Repository;
using ColecaoLivrosCDsDVDs.Servico;
using ColecaoLivrosCDsDVDs.Servico.Emprestimo;
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
        private readonly IEmprestimoServico _emprestimoServico;

        public UsuarioController(IUsuarioServico usuarioServico,
            IEmprestimoServico emprestimoServico)
        {
            _usuarioServico = usuarioServico;
            _emprestimoServico = emprestimoServico;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PaginaCadastrarUsuario(int idLivro, int idCd, int idDvd)
        {
            TempData["idLivroCadastro"] = idLivro;
            TempData["idCdCadastro"] = idCd;
            TempData["idDvdCadastro"] = idDvd;

            return View();
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(UsuarioRequest usuario, int idLivroCadastro, int idCdCadastro, int idDvdCadastro)
        {
            var request = MapearParaUsuario(usuario);

            if (idLivroCadastro != 0)
            {
                request.IdLivro = idLivroCadastro;
                _usuarioServico.Cadastrar(request);
                _emprestimoServico.EfetuarEmprestimoLivro(idLivroCadastro);
            }

            if (idCdCadastro != 0)
            {
                request.IdCd = idCdCadastro;
                _usuarioServico.Cadastrar(request);
                _emprestimoServico.EfetuarEmprestimoCd(idCdCadastro);
            }

            if (idDvdCadastro != 0)
            {
                request.IdDvd = idDvdCadastro;
                _usuarioServico.Cadastrar(request);
                _emprestimoServico.EfetuarEmprestimoDvd(idDvdCadastro);
            }
            
            return View("/Views/Emprestimo/Sucesso.cshtml");
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

        [HttpPost]
        public IActionResult DetalharUsuario(int idLivro, int idCd, int idDvd)
        {
            try
            {
                if(idLivro != 0)
                {
                    var usuario = _usuarioServico.DetalharUsuarioLivro(idLivro);
                    return View(usuario);
                }

                if (idCd != 0)
                {
                    var usuario = _usuarioServico.DetalharUsuarioCd(idCd);
                    return View(usuario);
                }

                if (idDvd != 0)
                {
                    var usuario = _usuarioServico.DetalharUsuarioDvd(idDvd);
                    return View(usuario);
                }
                return NotFound();
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
                TempData["idLogin"] = usuario.Id;
                TempData["login"] = usuario.Login;

                return Redirect("Index");
            }

            return Redirect("Index");
        }

        public IActionResult EfetuarLogout()
        {

            ViewData["loginId"] = null;
            ViewData["login"] = null;

            return RedirectToAction("Index");
        }

        public IActionResult PaginaInexistente()
        {
            return View("/Views/Usuario/LoginInexistente");
        }
    }
}
