using ColecaoLivrosCDsDVDs.Models;
using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico
{
    public interface IPessoaServico
    {
        void CadastrarPessoa(Pessoa pessoa);
        Pessoa BuscarPessoaPorId(int id);
        void AtualizarPessoa(Pessoa pessoa);
        public List<Pessoa> ListarPessoas();
        void ExcluirPessoa(int id);
    }
}
