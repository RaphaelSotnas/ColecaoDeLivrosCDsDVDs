using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Context.CdContext
{
    public class CdContext : ICdContext
    {
        private readonly AplicacaoContext _aplicacaoContext;
        public CdContext(AplicacaoContext aplicacaoContext)
        {
            _aplicacaoContext = aplicacaoContext;
        }
        public void Cadastrar(CD cd)
        {
            _aplicacaoContext.CDs.Add(cd);
            _aplicacaoContext.SaveChanges();
        }

        public CD BuscarPorId(int id)
        {
            return _aplicacaoContext.CDs.FirstOrDefault(x => x.Id == id);
        }

        public List<CD> Listar()
        {
            var cds = _aplicacaoContext.CDs;
            return cds
                .OrderBy(x => x.Nome)
                .ToList();
        }

        public void Atualizar(CD cd)
        {
            var cdDoBanco = BuscarPorId(cd.Id);

            var cdAtualizado = MapearParaCdAtualizado(cdDoBanco, cd);

            _aplicacaoContext.CDs.Update(cdAtualizado);
            _aplicacaoContext.SaveChanges();
        }

        private CD MapearParaCdAtualizado(CD cdDoBanco, CD cd)
        {
            cdDoBanco.Nome = cd.Nome;
            cdDoBanco.Cantor = cd.Cantor;
            cdDoBanco.GeneroMusical = cd.GeneroMusical;
            cdDoBanco.Status = cd.Status;

            return cdDoBanco;
        }

        public void Excluir(int id)
        {
            var cdExcluir = BuscarPorId(id);

            _aplicacaoContext.CDs.Remove(cdExcluir);
            _aplicacaoContext.SaveChanges();
        }

        public void EfetuarEmprestimoCd(int idCd)
        {
            var cdDoBanco = _aplicacaoContext.CDs.FirstOrDefault(x => x.Id == idCd);
            cdDoBanco.Status = Enum.Status.Indisponivel;
            _aplicacaoContext.SaveChanges();
        }

    }
}
