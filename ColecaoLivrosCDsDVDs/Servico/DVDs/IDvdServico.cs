using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico.DVDs
{
    public interface IDvdServico : IGenericoRepository<DVD>
    {
        bool EfetuarEmprestimoDvd(int idDvd);
    }
}
