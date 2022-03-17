using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico.Livros
{
    public interface ILivroServico
    {
        void CadastrarLivro(Livro livro);

        Livro BuscarLivroPorId(int id);

        void AtualizarLivro(Livro livro);

        public List<Livro> ListarLivros();

        void ExcluirLivro(int id);
    }
}
