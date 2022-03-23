using ColecaoLivrosCDsDVDs.Models;
using ColecaoLivrosCDsDVDs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Context
{
    public interface IUsuarioContext : IGenericoRepository<Usuario>
    {
        Usuario EfetuarLogin(string login, string senha);
    }
}
