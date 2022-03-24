using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Repository.EmprestimoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico.Emprestimo
{
    public class EmprestimoServico : IEmprestimoServico
    {
        private readonly IEmprestimoRepository _emprestimoRepository;
        public EmprestimoServico(IEmprestimoRepository emprestimoRepository)
        {
            _emprestimoRepository = emprestimoRepository;
        }

        public void EfetuarEmprestimoLivro(int id)
        {
            try
            {
                _emprestimoRepository.EfetuarEmprestimoLivro(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EfetuarEmprestimoCd(int id)
        {
            try
            {
                _emprestimoRepository.EfetuarEmprestimoCd(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EfetuarEmprestimoDvd(int idDvd)
        {
            try
            {
                _emprestimoRepository.EfetuarEmprestimoDvd(idDvd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
