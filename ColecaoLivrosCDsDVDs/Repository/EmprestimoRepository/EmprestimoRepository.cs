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

        public bool EfetuarEmprestimoLivro(int idLivro)
        {
            if (idLivro == 0)
            {
                throw new Exception("Não foi possível efetuar o empréstimo deste livro, ele não existe.");
            }
            return _livroContext.EfetuarEmprestimo(idLivro);
        }

        public bool EfetuarEmprestimoCd(int idCd)
        {
            if (idCd == 0)
            {
                throw new Exception("Não foi possível efetuar o empréstimo deste CD, ele não existe.");
            }
            return _cdContext.EfetuarEmprestimoCd(idCd);
        }

        public bool EfetuarEmprestimoDvd(int idDvd)
        {
            if (idDvd == 0)
            {
                throw new Exception("Não foi possível efetuar o empréstimo deste DVD, ele não existe.");
            }
            return _dvdContext.EfetuarEmprestimoDvd(idDvd);
        }
    }
}
