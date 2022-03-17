using ColecaoLivrosCDsDVDs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Context
{
    public class PessoaContext : IPessoaContext
    {
        public void CadastrarPessoa(Pessoa pessoa)
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();
            aplicacaoContext.Pessoas.Add(pessoa);
            aplicacaoContext.SaveChanges();
        }

        public void AtualizarPessoa(Pessoa pessoa)
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();

            var objPessoa = BuscarPessoaPorId(pessoa.Id);

            MapearParaPessoaAtualizada(pessoa, objPessoa);

            aplicacaoContext.Pessoas.Update(objPessoa);
            aplicacaoContext.SaveChanges();
        }
        private object MapearParaPessoaAtualizada(Pessoa pessoa, Pessoa objPessoa)
        {
            objPessoa.Nome = pessoa.Nome;
            objPessoa.Sobrenome = pessoa.Sobrenome;
            objPessoa.Telefone = pessoa.Telefone;
            objPessoa.Email = pessoa.Email;
            objPessoa.Endereço = pessoa.Endereço;

            return objPessoa;
        }

        public Pessoa BuscarPessoaPorId(int id)
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();
            return aplicacaoContext.Pessoas.FirstOrDefault(x => x.Id == id);
        }


        public void ExcluirPessoa(int id)
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();
            var pessoaExcluir = BuscarPessoaPorId(id);
            aplicacaoContext.Pessoas.Remove(pessoaExcluir);
            aplicacaoContext.SaveChanges();
        }

        public List<Pessoa> ListarPessoas()
        {
            AplicacaoContext aplicacaoContext = new AplicacaoContext();
            var pessoas = aplicacaoContext.Pessoas;
            return pessoas
                .OrderBy(x => x.Nome)
                .ToList();
        }
    }
}
