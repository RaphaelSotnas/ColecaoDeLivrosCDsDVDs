using ColecaoLivrosCDsDVDs.Context;
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
        public ColecaoRepository(IPessoaContext pessoaContext)
        {
            _pessoaContext = pessoaContext;
        }

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
            _pessoaContext.AtualizarPessoa(pessoa);
        }

        public void ExcluirPessoa(int id)
        {
            _pessoaContext.ExcluirPessoa(id);
        }

        public List<CD> ListarCDs()
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();
            var cds = aplicacaoContext.CDs;
            return cds
                .OrderBy(x => x.Nome)
                .ToList();
        }

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
