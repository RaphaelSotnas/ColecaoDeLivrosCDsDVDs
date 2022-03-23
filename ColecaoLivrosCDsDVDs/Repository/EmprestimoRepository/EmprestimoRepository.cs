using ColecaoLivrosCDsDVDs.Context;
using ColecaoLivrosCDsDVDs.Context.CdContext;
using ColecaoLivrosCDsDVDs.Context.DvdContext;
using ColecaoLivrosCDsDVDs.Context.LivroContext;
using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Repository.EmprestimoRepository
{
    public class EmprestimoRepository : IEmprestimoRepository
    {
        private readonly IUsuarioContext _usuarioContext;
        private readonly ILivroContext _livroContext;
        private readonly ICdContext _cdContext;
        private readonly IDvdContext _dvdContext;

        public EmprestimoRepository(IUsuarioContext usuarioContext,
            ILivroContext livroContext,
            ICdContext cdContext,
            IDvdContext dvdContext)
        {
            _usuarioContext = usuarioContext;
            _livroContext = livroContext;
            _cdContext = cdContext;
            _dvdContext = dvdContext;
        }

        public void EfetuarEmprestimoLivro(int idLivro)
        {
            _livroContext.EfetuarEmprestimo(idLivro);
        }

        public void EfetuarEmprestimoCd(int idCd)
        {
            _cdContext.EfetuarEmprestimoCd(idCd);
        }

        public void EfetuarEmprestimoDvd(int idDvd)
        {
            _dvdContext.EfetuarEmprestimoDvd(idDvd);
        }
    }
}
