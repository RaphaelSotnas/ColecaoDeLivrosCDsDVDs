using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Context.LivroContext
{
    public class LivroContext : ILivroContext
    {
        public void CadastrarLivro(Livro livro)
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();
            aplicacaoContext.Livros.Add(livro);
            aplicacaoContext.SaveChanges();
        }

        public Livro BuscarLivroPorId(int id)
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();
            return aplicacaoContext.Livros.FirstOrDefault(x => x.Id == id);
        }

        public List<Livro> ListarLivros()
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();
            var livros = aplicacaoContext.Livros;
            return livros
                .OrderBy(x => x.Nome)
                .ToList();
        }

        public void AtualizarLivro(Livro livro)
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();

            var livroDoBanco = BuscarLivroPorId(livro.Id);

            var livroAtualizado = MapearParaLivroAtualizado(livroDoBanco, livro);

            aplicacaoContext.Livros.Update(livroAtualizado);
            aplicacaoContext.SaveChanges();
        }

        private Livro MapearParaLivroAtualizado(Livro livroDoBanco, Livro livro)
        {
            livroDoBanco.Nome = livro.Nome;
            livroDoBanco.Autor = livro.Autor;
            livroDoBanco.Genero = livro.Genero;
            livroDoBanco.Status = livro.Status;

            return livroDoBanco;
        }

        public void ExcluirLivro(int id)
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();

            var livroExcluir = BuscarLivroPorId(id);

            aplicacaoContext.Livros.Remove(livroExcluir);
            aplicacaoContext.SaveChanges();
        }
    }
}
