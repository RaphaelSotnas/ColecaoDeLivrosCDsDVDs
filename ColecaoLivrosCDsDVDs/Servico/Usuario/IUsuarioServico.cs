using ColecaoLivrosCDsDVDs.Models;
using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico
{
    public interface IUsuarioServico : IGenericoRepository<Usuario>
    {
        Usuario EfetuarLogin(string login, string senha);
        Usuario DetalharUsuario(int id);
    }
}
