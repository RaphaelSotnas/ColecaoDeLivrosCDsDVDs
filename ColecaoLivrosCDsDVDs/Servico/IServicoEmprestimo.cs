using ColecaoLivrosCDsDVDs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico
{
    public interface IServicoEmprestimo
    {
        public void Emprestar(Pessoa pessoa, Item item);
    }
}
