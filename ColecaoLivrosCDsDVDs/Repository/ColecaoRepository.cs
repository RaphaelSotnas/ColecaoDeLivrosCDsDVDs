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
        public void CadastrarPessoa(Pessoa pessoa)
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();
            aplicacaoContext.Pessoas.Add(pessoa);
            aplicacaoContext.SaveChanges();
        }

        public List<CD> ListarCDs()
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();
            var cds = aplicacaoContext.CDs;
            return cds
                .OrderBy(x => x.Nome)
                .ToList();
        }

        public List<DVD> ListarDVDs()
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();
            var dvds = aplicacaoContext.DVDs;
            return dvds
                .OrderBy(x => x.Nome)
                .ToList();
        }

        public List<Pessoa> ListarPessoas()
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();
            var pessoas = aplicacaoContext.Pessoas;
            return pessoas
                .OrderBy(x => x.Nome)
                .ToList();
        }
    }
}
