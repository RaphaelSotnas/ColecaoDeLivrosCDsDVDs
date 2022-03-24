using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Repository;
using ColecaoLivrosCDsDVDs.Repository.EmprestimoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico.CDs
{
    public class CdServico : ICdServico
    {
        private readonly IColecaoRepository _colecaoRepository;
        private readonly IEmprestimoRepository _emprestimoRepository;
        public CdServico(IColecaoRepository colecaoRepository,
            IEmprestimoRepository emprestimoRepository)
        {
            _colecaoRepository = colecaoRepository;
            _emprestimoRepository = emprestimoRepository;
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

        public void EfetuarEmprestimoCd(int idCd)
        {
            try
            {
                _emprestimoRepository.EfetuarEmprestimoCd(idCd);
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

        public List<CD> ListarDisponiveis()
        {
            throw new NotImplementedException();
        }
    }
}
