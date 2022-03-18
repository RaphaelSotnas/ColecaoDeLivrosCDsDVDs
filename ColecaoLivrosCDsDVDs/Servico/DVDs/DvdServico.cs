using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico.DVDs
{
    public class DvdServico : IDvdServico
    {
        private readonly IColecaoRepository _colecaoRepository;
        public DvdServico(IColecaoRepository colecaoRepository)
        {
            _colecaoRepository = colecaoRepository;
        }

        public void AtualizarDvd(DVD dvd)
        {
            try
            {
                _colecaoRepository.AtualizarDvd(dvd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DVD BuscarDvdPorId(int id)
        {
            try
            {
                return _colecaoRepository.BuscarDvdPorId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CadastrarDvd(DVD cd)
        {
            try
            {
                _colecaoRepository.CadastrarDvd(cd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirDvd(int id)
        {
            try
            {
                _colecaoRepository.ExcluirDvd(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DVD> ListarDvds()
        {
            try
            {
                return _colecaoRepository.ListarDvds();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
