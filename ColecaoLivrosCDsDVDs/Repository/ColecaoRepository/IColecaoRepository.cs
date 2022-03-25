using ColecaoLivrosCDsDVDs.Models;
using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Repository
{
    public interface IColecaoRepository
    {
        #region Usuario

        bool CadastrarUsuario(Usuario usuario);

        Usuario BuscarUsuarioPorId(int id);

        List<Usuario> ListarUsuarios();

        bool AtualizarUsuario(Usuario pessooa);

        bool ExcluirUsuario(int id);

        Usuario EfetuarLogin(string login, string senha);

        Usuario DetalharUsuarioLivro(int idLivro);

        Usuario DetalharUsuarioCd(int idCd);

        Usuario DetalharUsuarioDvd(int idDvd);

        #endregion

        #region Livros

        bool CadastrarLivro(Livro livro);

        Livro BuscarLivroPorId(int id);

        List<Livro> ListarLivros();

        bool AtualizarLivro(Livro livro);

        bool ExcluirLivro(int id);

        #endregion

        #region Cd

        bool CadastrarCd(CD cd);

        CD BuscarCdPorId(int id);

        public List<CD> ListarCds();

        bool AtualizarCd(CD cd);

        bool ExcluirCd(int id);

        #endregion

        #region Dvd
        bool CadastrarDvd(DVD cd);

        DVD BuscarDvdPorId(int id);

        public List<DVD> ListarDvds();

        bool AtualizarDvd(DVD dvd);

        bool ExcluirDvd(int id);

        #endregion
    }
}
