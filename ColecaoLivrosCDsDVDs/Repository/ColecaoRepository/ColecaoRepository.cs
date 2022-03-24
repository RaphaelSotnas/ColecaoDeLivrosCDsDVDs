using ColecaoLivrosCDsDVDs.Context;
using ColecaoLivrosCDsDVDs.Context.CdContext;
using ColecaoLivrosCDsDVDs.Context.DvdContext;
using ColecaoLivrosCDsDVDs.Context.LivroContext;
using ColecaoLivrosCDsDVDs.Models;
using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Repository
{
    public class ColecaoRepository : IColecaoRepository
    {
        private readonly IUsuarioContext _usuarioContext;
        private readonly ILivroContext _livroContext;
        private readonly ICdContext _cdContext;
        private readonly IDvdContext _dvdContext;
        public ColecaoRepository(IUsuarioContext usuarioContext, ILivroContext livroContext, ICdContext cdContext, IDvdContext dvdContext)
        {
            _usuarioContext = usuarioContext;
            _livroContext = livroContext;
            _cdContext = cdContext;
            _dvdContext = dvdContext;
        }

        #region Usuario

        public void CadastrarUsuario(Usuario usuario)
        {
            _usuarioContext.Cadastrar(usuario);
        }

        public List<Usuario> ListarUsuarios()
        {
            return _usuarioContext.Listar();
        }

        public Usuario BuscarUsuarioPorId(int id)
        {
            return _usuarioContext.BuscarPorId(id);
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            var usuarioDoBanco = BuscarUsuarioPorId(usuario.Id);

            if (usuarioDoBanco.Nome == usuario.Nome
                 && usuarioDoBanco.Sobrenome == usuario.Sobrenome
                && usuarioDoBanco.Telefone == usuario.Telefone
                && usuarioDoBanco.Email == usuario.Email
                && usuarioDoBanco.Endereço == usuario.Endereço)
            {
                throw new Exception("As informações fornecidas para a edição são iguais as atuais");
            }
            _usuarioContext.Atualizar(usuario);
        }

        public void ExcluirUsuario(int id)
        {
            _usuarioContext.Excluir(id);
        }

        public Usuario EfetuarLogin(string login, string senha)
        {
            var usuarioDoBanco = _usuarioContext.EfetuarLogin(login, senha);
            if (usuarioDoBanco.Senha != senha)
                throw new Exception("Senha e login incompatíveis");
            return usuarioDoBanco;
        }

        #endregion

        #region Livro

        public void CadastrarLivro(Livro livro)
        {
            _livroContext.Cadastrar(livro);
        }

        public Livro BuscarLivroPorId(int id)
        {
            return _livroContext.BuscarPorId(id);
        }

        public List<Livro> ListarLivros()
        {
            return _livroContext.Listar();
        }

        public void ExcluirLivro(int id)
        {
            _livroContext.Excluir(id);
        }

        public void AtualizarLivro(Livro livro)
        {
            var livroDoBanco = BuscarLivroPorId(livro.Id);
            if (livroDoBanco.Nome == livro.Nome
                 && livroDoBanco.Autor == livro.Autor
                 && livroDoBanco.Genero == livro.Genero)
                throw new Exception("As informações fornecidas para a edição são iguais as atuais");

            _livroContext.Atualizar(livro);
        }

        public Usuario DetalharUsuarioLivro(int id)
        {
            var loginDoBanco = _usuarioContext.DetalharUsuarioLivro(id);
            if (loginDoBanco == null)
                throw new Exception("Este login não existe.");
            return loginDoBanco;
        }

        #endregion

        #region Cd

        public void CadastrarCd(CD cd)
        {
            _cdContext.Cadastrar(cd);
        }

        public CD BuscarCdPorId(int id)
        {
            return _cdContext.BuscarPorId(id);
        }

        public List<CD> ListarCds()
        {
            return _cdContext.Listar();
        }

        public void ExcluirCd(int id)
        {
            _cdContext.Excluir(id);
        }

        public void AtualizarCd(CD cd)
        {
            var cdDoBanco = BuscarCdPorId(cd.Id);
            if (cdDoBanco.Nome == cd.Nome
                 && cdDoBanco.Cantor == cd.Cantor
                 && cdDoBanco.GeneroMusical == cd.GeneroMusical
                 && cdDoBanco.Status == cd.Status)
                throw new Exception("As informações fornecidas para a edição são iguais as atuais");

            _cdContext.Atualizar(cd);
        }

        public Usuario DetalharUsuarioCd(int idCd)
        {
            var loginDoBanco = _usuarioContext.DetalharUsuarioCd(idCd);
            if (loginDoBanco == null)
                throw new Exception("Este login não existe.");
            return loginDoBanco;
        }

        #endregion

        #region DVD 

        public void CadastrarDvd(DVD cd)
        {
            _dvdContext.Cadastrar(cd);
        }

        public DVD BuscarDvdPorId(int id)
        {
            return _dvdContext.BuscarPorId(id);
        }

        public List<DVD> ListarDvds()
        {
            return _dvdContext.Listar();
        } 

        public void AtualizarDvd(DVD dvd)
        {
            var dvdDoBanco = BuscarDvdPorId(dvd.Id);
            if (dvdDoBanco.Nome == dvd.Nome
                 && dvdDoBanco.Genero == dvd.Genero
                 && dvdDoBanco.Status == dvd.Status)
                throw new Exception("As informações fornecidas para a edição são iguais as atuais");
            _dvdContext.Atualizar(dvd);
        }

        public void ExcluirDvd(int id)
        {
            _dvdContext.Excluir(id);
        }

        public Usuario DetalharUsuarioDvd(int idDvd)
        {
            var loginDoBanco = _usuarioContext.DetalharUsuarioDvd(idDvd);
            if (loginDoBanco == null)
                throw new Exception("Este login não existe.");
            return loginDoBanco;
        }

        #endregion
    }
}
