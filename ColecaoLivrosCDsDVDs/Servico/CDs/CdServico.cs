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

        public bool Atualizar(CD cd)
        {
            try
            {
                return _colecaoRepository.AtualizarCd(cd);
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

        public bool Cadastrar(CD cd)
        {
            try
            {
                return _colecaoRepository.CadastrarCd(cd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EfetuarEmprestimoCd(int idCd)
        {
            try
            {
                return _emprestimoRepository.EfetuarEmprestimoCd(idCd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Excluir(int id)
        {
            try
            {
                return _colecaoRepository.ExcluirCd(id);
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
