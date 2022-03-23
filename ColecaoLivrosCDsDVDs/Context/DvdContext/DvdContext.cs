using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Context.DvdContext
{
    public class DvdContext : IDvdContext
    {
        private readonly AplicacaoContext _aplicacaoContext;
        public DvdContext(AplicacaoContext aplicacaoContext)
        {
            _aplicacaoContext = aplicacaoContext;
        }
        public void Atualizar(DVD dvd)
        {
            var dvdDoBanco = BuscarPorId(dvd.Id);

            var dvdAtualizado = MapearParaDvd(dvdDoBanco, dvd);

            _aplicacaoContext.DVDs.Update(dvdAtualizado);
            _aplicacaoContext.SaveChanges();
        }

        private DVD MapearParaDvd(DVD dvdDoBanco, DVD dvd)
        {
            dvdDoBanco.Nome = dvd.Nome;
            dvdDoBanco.Genero = dvd.Genero;
            dvdDoBanco.Status = dvd.Status;

            return dvdDoBanco;
        }

        public DVD BuscarPorId(int id)
        {
            return _aplicacaoContext.DVDs.FirstOrDefault(x => x.Id == id);
        }

        public void Cadastrar(DVD cd)
        {
            _aplicacaoContext.DVDs.Add(cd);
            _aplicacaoContext.SaveChanges();
        }

        public void Excluir(int id)
        {
            var dvdExcluir = BuscarPorId(id);

            _aplicacaoContext.DVDs.Remove(dvdExcluir);
            _aplicacaoContext.SaveChanges();
        }

        public List<DVD> Listar()
        {
            var dvds = _aplicacaoContext.DVDs;

            return dvds
                    .OrderBy(x => x.Nome)
                    .ToList();
        }
    
    }
}
