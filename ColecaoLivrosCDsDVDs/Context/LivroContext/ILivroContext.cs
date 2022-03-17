using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Context.LivroContext
{
    public interface ILivroContext
    {
        void CadastrarLivro(Livro livro);

        Livro BuscarLivroPorId(int id);

        public List<Livro> ListarLivros();

        void AtualizarLivro(Livro livro);

        void ExcluirLivro(int id);
    }
}
