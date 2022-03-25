using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Repository;
using ColecaoLivrosCDsDVDs.Repository.EmprestimoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico.DVDs
{
    public class DvdServico : IDvdServico
    {
        private readonly IColecaoRepository _colecaoRepository;
        private readonly IEmprestimoRepository _emprestimoRepository;
        public DvdServico(IColecaoRepository colecaoRepository,
            IEmprestimoRepository emprestimoRepository)
        {
            _colecaoRepository = colecaoRepository;
            _emprestimoRepository = emprestimoRepository;
        }

        public bool Atualizar(DVD dvd)
        {
            try
            {
                return _colecaoRepository.AtualizarDvd(dvd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DVD BuscarPorId(int id)
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

        public bool Cadastrar(DVD cd)
        {
            try
            {
                return _colecaoRepository.CadastrarDvd(cd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EfetuarEmprestimoDvd(int idDvd)
        {
            try
            {
                return _emprestimoRepository.EfetuarEmprestimoDvd(idDvd);
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
                return _colecaoRepository.ExcluirDvd(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DVD> Listar()
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

        public List<DVD> ListarDisponiveis()
        {
            throw new NotImplementedException();
        }
    }
}
