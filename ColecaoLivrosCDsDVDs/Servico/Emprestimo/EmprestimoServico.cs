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

        public bool EfetuarEmprestimoLivro(int id)
        {
            try
            {
                return _emprestimoRepository.EfetuarEmprestimoLivro(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EfetuarEmprestimoCd(int id)
        {
            try
            {
                return _emprestimoRepository.EfetuarEmprestimoCd(id);
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
    }
}
