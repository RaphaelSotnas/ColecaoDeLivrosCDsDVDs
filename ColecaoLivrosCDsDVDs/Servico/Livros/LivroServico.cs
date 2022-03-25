using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Repository;
using ColecaoLivrosCDsDVDs.Repository.EmprestimoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico.Livros
{
    public class LivroServico : ILivroServico
    {
        private readonly IColecaoRepository _colecaoRepository;
        private readonly IEmprestimoRepository _emprestimoRepository;
        public LivroServico(IColecaoRepository colecaoRepository,
            IEmprestimoRepository emprestimoRepository)
        {
            _colecaoRepository = colecaoRepository;
            _emprestimoRepository = emprestimoRepository;
        }

        public bool Cadastrar(Livro livro)
        {
            try
            {
                return _colecaoRepository.CadastrarLivro(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Atualizar(Livro livro)
        {
            try
            {
                return _colecaoRepository.AtualizarLivro(livro);
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

        public bool Excluir(int id)
        {
            try
            {
                return _colecaoRepository.ExcluirLivro(id);
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

        public bool EfetuarEmprestimoLivro(int idLivro)
        {
            try
            {
                return _emprestimoRepository.EfetuarEmprestimoLivro(idLivro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
