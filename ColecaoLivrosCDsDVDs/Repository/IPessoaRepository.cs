using ColecaoLivrosCDsDVDs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Repository
{
    public interface IPessoaRepository
    {
        public bool CadastroPessoa(Pessoa pessoa);
    }
}
