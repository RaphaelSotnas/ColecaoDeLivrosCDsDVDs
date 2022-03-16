using ColecaoLivrosCDsDVDs.Models;
using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico
{
    public class ItensService : IItensService
    {
        private readonly IColecaoRepository _colecaoRepository;
        public ItensService(IColecaoRepository colecaoRepository)
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

        public void Emprestar(Pessoa pessoa, Itens Itens)
        {
            
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
    }
}
