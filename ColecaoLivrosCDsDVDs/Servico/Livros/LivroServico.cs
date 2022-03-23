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

        public void Cadastrar(Livro livro)
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

        public void Atualizar(Livro livro)
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

        public Livro BuscarPorId(int id)
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

        public void Excluir(int id)
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

        public List<Livro> Listar()
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
