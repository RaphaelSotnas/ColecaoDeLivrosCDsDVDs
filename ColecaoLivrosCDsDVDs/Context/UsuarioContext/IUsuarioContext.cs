using ColecaoLivrosCDsDVDs.Models;
using ColecaoLivrosCDsDVDs.Models.Entidades;
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
        Usuario DetalharUsuario(int id);
        void EfetuarEmprestimo(Livro livro);
        //void EfetuarEmprestimo(CD cd);
        //void EfetuarEmprestimo(DVD dvd);
    }
}
