using ColecaoLivrosCDsDVDs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Context
{
    public interface IPessoaContext
    {
        void ExcluirPessoa(int id);
        void AtualizarPessoa(Pessoa pessooa);
        Pessoa BuscarPessoaPorId(int id);
        void CadastrarPessoa(Pessoa pessoa);
        List<Pessoa> ListarPessoas();
    }
}
