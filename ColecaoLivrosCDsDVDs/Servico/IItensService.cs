using ColecaoLivrosCDsDVDs.Models;
using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico
{
    public interface IItensService
    {
        public void Emprestar(Pessoa pessoa, Itens itens);
        void CadastrarPessoa(Pessoa pessoa);
        public List<Pessoa> ListarPessoas();
    }
}
