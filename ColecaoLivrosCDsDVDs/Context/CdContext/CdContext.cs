using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Context.CdContext
{
    public class CdContext : ICdContext
    {
        public void CadastrarCd(CD cd)
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();
            aplicacaoContext.CDs.Add(cd);
            aplicacaoContext.SaveChanges();
        }

        public CD BuscarCdPorId(int id)
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();
            return aplicacaoContext.CDs.FirstOrDefault(x => x.Id == id);
        }

        public List<CD> ListarCds()
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();
            var cds = aplicacaoContext.CDs;
            return cds
                .OrderBy(x => x.Nome)
                .ToList();
        }

        public void AtualizarCd(CD cd)
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();

            var cdDoBanco = BuscarCdPorId(cd.Id);

            var cdAtualizado = MapearParaCdAtualizado(cdDoBanco, cd);

            aplicacaoContext.CDs.Update(cdAtualizado);
            aplicacaoContext.SaveChanges();
        }

        private CD MapearParaCdAtualizado(CD cdDoBanco, CD cd)
        {
            cdDoBanco.Nome = cd.Nome;
            cdDoBanco.Cantor = cd.Cantor;
            cdDoBanco.GeneroMusical = cd.GeneroMusical;
            cdDoBanco.Status = cd.Status;

            return cdDoBanco;
        }

        public void ExcluirCd(int id)
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();

            var cdExcluir = BuscarCdPorId(id);

            aplicacaoContext.CDs.Remove(cdExcluir);
            aplicacaoContext.SaveChanges();
        }
    }
}
