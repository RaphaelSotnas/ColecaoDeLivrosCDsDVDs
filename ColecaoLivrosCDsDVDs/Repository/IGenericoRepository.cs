using ColecaoLivrosCDsDVDs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Repository
{
    public interface IGenericoRepository<T>
    {
        bool Cadastrar(T entidade);

        T BuscarPorId(int id);

        List<T> Listar();

        bool Atualizar(T entidade);

        bool Excluir(int id);
    }
}
