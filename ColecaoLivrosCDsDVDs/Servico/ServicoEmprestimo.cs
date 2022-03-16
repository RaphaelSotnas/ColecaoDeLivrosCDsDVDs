using ColecaoLivrosCDsDVDs.Models;
using ColecaoLivrosCDsDVDs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico
{
    public class ServicoEmprestimo : IServicoEmprestimo
    {
        private readonly IPessoaRepository _pessoaRepository;
        public ServicoEmprestimo(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }
        public void Emprestar(Pessoa pessoa, Item item)
        {
            var pessoaCadastrada = _pessoaRepository.CadastroPessoa(pessoa);

        }
    }
}
