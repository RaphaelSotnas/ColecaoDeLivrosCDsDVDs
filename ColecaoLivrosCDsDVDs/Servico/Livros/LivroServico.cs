using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico.Livros
{
    public class LivroServico : ILivroServico
    {
        protected readonly IColecaoRepository _colecaoRepository;
        public LivroServico(IColecaoRepository colecaoRepository)
        {
            _colecaoRepository = colecaoRepository;
        }

        public void CadastrarLivro(Livro livro)
        {
            try
            {
                _colecaoRepository.CadastrarLivro(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizarLivro(Livro livro)
        {
            try
            {
                _colecaoRepository.AtualizarLivro(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Livro BuscarLivroPorId(int id)
        {
            try
            {
                return _colecaoRepository.BuscarLivroPorId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirLivro(int id)
        {
            try
            {
                _colecaoRepository.ExcluirLivro(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Livro> ListarLivros()
        {
            try
            {
                return _colecaoRepository.ListarLivros();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
