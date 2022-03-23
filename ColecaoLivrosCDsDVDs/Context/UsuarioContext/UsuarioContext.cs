using ColecaoLivrosCDsDVDs.Models;
using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Context
{
    public class UsuarioContext : IUsuarioContext
    {
        private readonly AplicacaoContext _aplicacaoContext;
        public UsuarioContext(AplicacaoContext aplicacaoContext)
        {
            _aplicacaoContext = aplicacaoContext;
        }
        public void Cadastrar(Usuario usuario)
        {
            _aplicacaoContext.Usuarios.Add(usuario);
            _aplicacaoContext.SaveChanges();
        }

        public void Atualizar(Usuario usuario)
        {
            var objUsuario = BuscarPorId(usuario.Id);

            MapearParaUsuarioAtualizada(usuario, objUsuario);

            _aplicacaoContext.Usuarios.Update(objUsuario);
            _aplicacaoContext.SaveChanges();
        }
        private object MapearParaUsuarioAtualizada(Usuario usuario, Usuario objUsuario)
        {
            objUsuario.Nome = usuario.Nome;
            objUsuario.Sobrenome = usuario.Sobrenome;
            objUsuario.Telefone = usuario.Telefone;
            objUsuario.Email = usuario.Email;
            objUsuario.Endereço = usuario.Endereço;

            return objUsuario;
        }

        public Usuario BuscarPorId(int id)
        {
            return _aplicacaoContext.Usuarios.FirstOrDefault(x => x.Id == id);
        }


        public void Excluir(int id)
        {
            var usuarioExcluir = BuscarPorId(id);
            _aplicacaoContext.Usuarios.Remove(usuarioExcluir);
            _aplicacaoContext.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            var usuarios = _aplicacaoContext.Usuarios;
            return usuarios
                .OrderBy(x => x.Nome)
                .ToList();
        }

        public Usuario EfetuarLogin(string login, string senha)
        {
            return _aplicacaoContext.Usuarios.FirstOrDefault(x => x.Login == login);
        }

        public Usuario DetalharUsuario(int id)
        {
            return _aplicacaoContext.Usuarios.FirstOrDefault(x => x.IdLivro == id);
        }

        public void EfetuarEmprestimo(Livro livro)
        {
            throw new NotImplementedException();
        }
    }
}
