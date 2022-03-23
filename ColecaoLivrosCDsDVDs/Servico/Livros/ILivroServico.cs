using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico.Livros
{
    public interface ILivroServico : IGenericoRepository<Livro>
    {
        void EfetuarEmprestimoLivro(int idLivro);   
    }
}
