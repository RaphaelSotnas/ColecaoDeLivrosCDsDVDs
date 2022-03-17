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
        #region Pessoa

        void CadastrarPessoa(Pessoa pessoa);

        Pessoa BuscarPessoaPorId(int id);

        List<Pessoa> ListarPessoas();
        void AtualizarPessoa(Pessoa pessooa);

        void ExcluirPessoa(int id);

        #endregion

        #region Livros

        void CadastrarLivro(Livro livro);

        Livro BuscarLivroPorId(int id);

        public List<Livro> ListarLivros();

        void AtualizarLivro(Livro livro);

        void ExcluirLivro(int id);

        #endregion

        #region Cd

        void CadastrarCd(CD cd);

        CD BuscarCdPorId(int id);

        public List<CD> ListarCds();

        void AtualizarCd(CD cd);

        void ExcluirCd(int id);

        #endregion

        #region Dvd

        #endregion
    }
}
