using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Context.DvdContext
{
    public class DvdContext : IDvdContext
    {
        public void AtualizarDvd(DVD dvd)
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();

            var dvdDoBanco = BuscarDvdPorId(dvd.Id);

            var dvdAtualizado = MapearParaDvd(dvdDoBanco, dvd);

            aplicacaoContext.DVDs.Update(dvdAtualizado);
            aplicacaoContext.SaveChanges();
        }

        private DVD MapearParaDvd(DVD dvdDoBanco, DVD dvd)
        {
            dvdDoBanco.Nome = dvd.Nome;
            dvdDoBanco.Genero = dvd.Genero;
            dvdDoBanco.Status = dvd.Status;

            return dvdDoBanco;
        }

        public DVD BuscarDvdPorId(int id)
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();
            return aplicacaoContext.DVDs.FirstOrDefault(x => x.Id == id);
        }

        public void CadastrarDvd(DVD cd)
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();
            aplicacaoContext.DVDs.Add(cd);
            aplicacaoContext.SaveChanges();
        }

        public void ExcluirDvd(int id)
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();

            var dvdExcluir = BuscarDvdPorId(id);

            aplicacaoContext.DVDs.Remove(dvdExcluir);
            aplicacaoContext.SaveChanges();
        }

        public List<DVD> ListarDvds()
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();

            var dvds = aplicacaoContext.DVDs;

            return dvds
                    .OrderBy(x => x.Nome)
                    .ToList();
        }
    
    }
}
