using ColecaoLivrosCDsDVDs.Context;
using ColecaoLivrosCDsDVDs.Context.CdContext;
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
        private readonly IPessoaContext _pessoaContext;
        private readonly ILivroContext _livroContext;
        private readonly ICdContext _cdContext;
        public ColecaoRepository
            (IPessoaContext pessoaContext,
            ILivroContext livroContext,
            ICdContext cdContext
            )
        {
            _pessoaContext = pessoaContext;
            _livroContext = livroContext;
            _cdContext = cdContext;
        }

        #region Pessoa

        public void CadastrarPessoa(Pessoa pessoa)
        {
            _pessoaContext.CadastrarPessoa(pessoa);
        }

        public List<Pessoa> ListarPessoas()
        {
            return _pessoaContext.ListarPessoas();
        }

        public Pessoa BuscarPessoaPorId(int id)
        {
            return _pessoaContext.BuscarPessoaPorId(id);
        }

        public void AtualizarPessoa(Pessoa pessoa)
        {
            var pessoaDoBanco = BuscarPessoaPorId(pessoa.Id);

            if (pessoaDoBanco.Nome == pessoa.Nome
                 && pessoaDoBanco.Sobrenome == pessoa.Sobrenome
                && pessoaDoBanco.Telefone == pessoa.Telefone
                && pessoaDoBanco.Email == pessoa.Email
                && pessoaDoBanco.Endereço == pessoa.Endereço)
            {
                throw new Exception("As informações fornecidas para a edição são iguais as atuais");
            }
            _pessoaContext.AtualizarPessoa(pessoa);
        }

        public void ExcluirPessoa(int id)
        {
            _pessoaContext.ExcluirPessoa(id);
        }

        #endregion

        #region Livro

        public void CadastrarLivro(Livro livro)
        {
            _livroContext.CadastrarLivro(livro);
        }

        public Livro BuscarLivroPorId(int id)
        {
            return _livroContext.BuscarLivroPorId(id);
        }

        public List<Livro> ListarLivros()
        {
            return _livroContext.ListarLivros();
        }

        public void ExcluirLivro(int id)
        {
            _livroContext.ExcluirLivro(id);
        }

        public void AtualizarLivro(Livro livro)
        {
            var livroDoBanco = BuscarLivroPorId(livro.Id);
            if (livroDoBanco.Nome == livro.Nome
                 && livroDoBanco.Autor == livro.Autor
                 && livroDoBanco.Genero == livro.Genero)
                throw new Exception("As informações fornecidas para a edição são iguais as atuais");

            _livroContext.AtualizarLivro(livro);
        }

        #endregion

        #region Cd

        public void CadastrarCd(CD cd)
        {
            _cdContext.CadastrarCd(cd);
        }

        public CD BuscarCdPorId(int id)
        {
            return _cdContext.BuscarCdPorId(id);
        }

        public List<CD> ListarCds()
        {
            return _cdContext.ListarCds();
        }

        public void ExcluirCd(int id)
        {
            _cdContext.ExcluirCd(id);
        }

        public void AtualizarCd(CD cd)
        {
            var cdDoBanco = BuscarCdPorId(cd.Id);
            if (cdDoBanco.Nome == cd.Nome
                 && cdDoBanco.Cantor == cd.Cantor
                 && cdDoBanco.GeneroMusical == cd.GeneroMusical
                 && cdDoBanco.Status == cd.Status)
                throw new Exception("As informações fornecidas para a edição são iguais as atuais");

            _cdContext.AtualizarCd(cd);
        }

        #endregion

        //public List<DVD> ListarDVDs()
        //{
        //    AplicacaoContext aplicacaoContext = new AplicacaoContext();
        //    var dvds = aplicacaoContext.DVDs;
        //    return dvds
        //        .OrderBy(x => x.Nome)
        //        .ToList();
        //}
    }
}
