using ColecaoLivrosCDsDVDs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Repository
{
    public interface IGenericoRepository<T>
    {
        void Cadastrar(T entidade);

        T BuscarPorId(int id);

        List<T> Listar();

        void Atualizar(T entidade);

        void Excluir(int id);
    }
}
