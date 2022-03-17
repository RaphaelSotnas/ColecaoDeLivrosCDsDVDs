using ColecaoLivrosCDsDVDs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Context
{
    public interface IPessoaContext
    {
        void CadastrarPessoa(Pessoa pessoa);
        Pessoa BuscarPessoaPorId(int id);
        List<Pessoa> ListarPessoas();
        void AtualizarPessoa(Pessoa pessooa);
        void ExcluirPessoa(int id);
    }
}
