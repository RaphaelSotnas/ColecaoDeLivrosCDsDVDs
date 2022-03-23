using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico.CDs
{
    public class CdServico : ICdServico
    {
        private readonly IColecaoRepository _colecaoRepository;
        public CdServico(IColecaoRepository colecaoRepository)
        {
            _colecaoRepository = colecaoRepository;
        }

        public void Atualizar(CD cd)
        {
            try
            {
                _colecaoRepository.AtualizarCd(cd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CD BuscarPorId(int id)
        {
            try
            {
                return _colecaoRepository.BuscarCdPorId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Cadastrar(CD cd)
        {
            try
            {
                _colecaoRepository.CadastrarCd(cd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _colecaoRepository.ExcluirCd(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CD> Listar()
        {
            try
            {
                return _colecaoRepository.ListarCds();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
