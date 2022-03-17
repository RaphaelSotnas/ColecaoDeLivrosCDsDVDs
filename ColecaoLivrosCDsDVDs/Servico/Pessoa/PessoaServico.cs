using ColecaoLivrosCDsDVDs.Models;
using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico
{
    public class PessoaServico : IPessoaServico
    {
        private readonly IColecaoRepository _colecaoRepository;
        public PessoaServico(IColecaoRepository colecaoRepository)
        {
            _colecaoRepository = colecaoRepository;
        }

        public void CadastrarPessoa(Pessoa pessoa)
        {
            try
            {
                _colecaoRepository.CadastrarPessoa(pessoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Pessoa BuscarPessoaPorId(int id)
        {
            try
            {
                return _colecaoRepository.BuscarPessoaPorId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Pessoa> ListarPessoas()
        {
            try 
            {
                return _colecaoRepository.ListarPessoas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizarPessoa(Pessoa pessoa)
        {
            try
            {
                _colecaoRepository.AtualizarPessoa(pessoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirPessoa(int id)
        {
            try
            {
                _colecaoRepository.ExcluirPessoa(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
