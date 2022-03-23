using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Context.LivroContext
{
    public class LivroContext : ILivroContext
    {
        private readonly AplicacaoContext _aplicacaoContext;
        public LivroContext(AplicacaoContext aplicacaoContext)
        {
            _aplicacaoContext = aplicacaoContext;
        }
        public void Cadastrar(Livro livro)
        {
            _aplicacaoContext.Livros.Add(livro);
            _aplicacaoContext.SaveChanges();
        }

        public Livro BuscarPorId(int id)
        {
            return _aplicacaoContext.Livros.FirstOrDefault(x => x.Id == id);
        }

        public List<Livro> Listar()
        {
            var livros = _aplicacaoContext.Livros;
            return livros
                .OrderBy(x => x.Nome)
                .ToList();
        }

        public void Atualizar(Livro livro)
        {
            var livroDoBanco = BuscarPorId(livro.Id);

            var livroAtualizado = MapearParaLivroAtualizado(livroDoBanco, livro);

            _aplicacaoContext.Livros.Update(livroAtualizado);
            _aplicacaoContext.SaveChanges();
        }

        private Livro MapearParaLivroAtualizado(Livro livroDoBanco, Livro livro)
        {
            livroDoBanco.Nome = livro.Nome;
            livroDoBanco.Autor = livro.Autor;
            livroDoBanco.Genero = livro.Genero;
            livroDoBanco.Status = livro.Status;

            return livroDoBanco;
        }

        public void Excluir(int id)
        {
            var livroExcluir = BuscarPorId(id);

            _aplicacaoContext.Livros.Remove(livroExcluir);
            _aplicacaoContext.SaveChanges();
        }
    }
}
